using Ordi.Reflection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Linq;
using Ordi.Attributes;

namespace Ordi
{
    public class ObjectProperty
    {
        /// <summary> 
        /// 属性信息
        /// </summary>
        public PropertyInfo Info { get; set; }
        /// <summary> 
        /// Set方法委托
        /// </summary>
        public PropertySetter Setter { get; set; }
        ////缓存
        //static readonly Dictionary<Type, ObjectProperty[]> Cache = new Dictionary<Type, ObjectProperty[]>();
        //缓存
        static readonly Dictionary<Type, Tuple<string, ObjectProperty>[]> Cache = new Dictionary<Type, Tuple<string, ObjectProperty>[]>();

        //数据类型和对应的强制转换方法的methodinfo，供实体属性赋值时调用
        private static readonly Dictionary<Type, MethodInfo> ConvertMethods = new Dictionary<Type, MethodInfo>()
        {
            {typeof(int),typeof(Convert).GetMethod("ToInt32",new Type[]{typeof(object)})},
            {typeof(Int16),typeof(Convert).GetMethod("ToInt16",new Type[]{typeof(object)})},
            {typeof(Int64),typeof(Convert).GetMethod("ToInt64",new Type[]{typeof(object)})},
            {typeof(DateTime),typeof(Convert).GetMethod("ToDateTime",new Type[]{typeof(object)})},
            {typeof(decimal),typeof(Convert).GetMethod("ToDecimal",new Type[]{typeof(object)})},
            {typeof(Double),typeof(Convert).GetMethod("ToDouble",new Type[]{typeof(object)})},
            {typeof(Boolean),typeof(Convert).GetMethod("ToBoolean",new Type[]{typeof(object)})},
            {typeof(string),typeof(Convert).GetMethod("ToString",new Type[]{typeof(object)})}
        };


        /// <summary> 
        /// [ typeof(Object),typeof(Object) ]
        /// </summary>
        private static readonly Type[] Types2Object = { typeof(Object), typeof(Object) };

        /// <summary> 
        /// 获取一个类中的所有公开实例属性和它们的Set方法委托
        /// </summary>
        public static Tuple<string, ObjectProperty>[] GetProperties(Type type)
        {
            Tuple<string, ObjectProperty>[] arr;
            if (Cache.TryGetValue(type, out arr))//优先从缓存中获取
            {
                return arr;
            }
            PropertyInfo[] ps = type.GetProperties();
            var cols = CheckProperty(ps);
            arr = new Tuple<string, ObjectProperty>[cols.Count];//  new ObjectProperty[cols.Count];
            for (int i = 0; i < cols.Count; i++)
            {
                ObjectProperty op = new ObjectProperty();
                op.Info = cols[i].Item2;
                op.Setter = CreateSetter(op.Info);  //之前定义的方法
                arr[i] = new Tuple<string, ObjectProperty>(cols[i].Item1, op);
            }
            Cache.Add(type, arr); //加入缓存
            return arr;
        }

        ///// <summary> 
        ///// 获取一个类中的所有公开实例属性和它们的Set方法委托
        ///// </summary>
        //public static ObjectProperty[] GetProperties(Type type)
        //{
        //    ObjectProperty[] arr;
        //    if (Cache.TryGetValue(type, out arr))//优先从缓存中获取
        //    {
        //        return arr;
        //    }
        //    PropertyInfo[] ps = type.GetProperties();
        //    var cols = CheckProperty(ps);
        //    arr = new ObjectProperty[cols.Count];
        //    for (int i = 0; i < cols.Count; i++)
        //    {
        //        ObjectProperty op = new ObjectProperty();
        //        op.Info = cols[i].Item2;
        //        op.Setter = CreateSetter(op.Info);  //之前定义的方法
        //        arr[i] = op;
        //    }
        //    Cache.Add(type, arr); //加入缓存
        //    return arr;
        //}

        /// <summary>
        /// 获取可用于转换的列
        /// </summary>
        /// <param name="ps"></param>
        private static List<Tuple<string, PropertyInfo>> CheckProperty(PropertyInfo[] ps)
        {
            List<Tuple<string, PropertyInfo>> list = new List<Tuple<string, PropertyInfo>>(); ;
            foreach (var property in ps)
            {
                var ddd = property.GetCustomAttributes(typeof(DataFieldAttribute), false);
                if (ddd.Length == 1)
                {
                    var attr = (DataFieldAttribute)ddd[0];
                    if (!string.IsNullOrWhiteSpace(attr.FieldName))
                    {
                        list.Add(new Tuple<string, PropertyInfo>(attr.FieldName, property));
                    }
                }
                else
                {
                    list.Add(new Tuple<string, PropertyInfo>(property.Name, property));
                }
            }
            return list;
        }

        /// <summary> 创建指定属性的Set方法委托
        /// </summary>
        public static PropertySetter CreateSetter(PropertyInfo property, Type owner = null)
        {
            if (owner == null)
                owner = property.DeclaringType;
            var dm = new DynamicMethod("", null, Types2Object, owner);
            //=== IL ===
            var il = dm.GetILGenerator();

            il.Emit(OpCodes.Ldarg_0);
            il.Emit(OpCodes.Ldarg_1);
            if (property.PropertyType.IsValueType || property.PropertyType == typeof(string))//判断属性类型是否是值类型
            {
                var cur = Nullable.GetUnderlyingType(property.PropertyType);

                ConvertMethods.TryGetValue(cur ?? property.PropertyType, out MethodInfo info);
                
                if (info != null)
                {
                    il.Emit(OpCodes.Call, ConvertMethods[cur == null ? property.PropertyType : cur]);
                    if (cur != null)
                    {
                        il.Emit(OpCodes.Newobj, property.PropertyType.GetConstructor(new Type[] { cur }));
                    }
                }
                else
                {
                    il.Emit(OpCodes.Unbox_Any, property.PropertyType);//如果是值类型就拆箱
                }
            }
            else
            {
                il.Emit(OpCodes.Castclass, property.PropertyType);//否则强转
            }

            il.Emit(OpCodes.Callvirt, property.GetSetMethod());
            il.Emit(OpCodes.Ret);
            //=== IL ===
            return (PropertySetter)dm.CreateDelegate(typeof(PropertySetter));
        }

        /// <summary> 
        /// IL类型转换指令
        /// </summary>
        private static void EmitCast(ILGenerator il, Type type, bool check = true)
        {
            if (type.IsValueType)
            {
                il.Emit(OpCodes.Unbox_Any, type);
                if (check && Nullable.GetUnderlyingType(type) == null)
                {
                    var t = il.DeclareLocal(type);
                    il.Emit(OpCodes.Stloc, t);
                    il.Emit(OpCodes.Ldloca_S, t);
                }
            }
            else
            {
                il.Emit(OpCodes.Castclass, type);
            }
        }

        /// <summary> 
        /// 如果是数组,则获取数组中元素的类型
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        private static Type GetOwnerType(MemberInfo member)
        {
            //owner 是一个接口、一个数组、一个开放式泛型类型或一个泛型类型或方法的类型参数。
            Type type = member.ReflectedType;
            while (true)
            {
                if (type.IsArray)
                {
                    type = member.ReflectedType.GetElementType();
                }
                else if (
                    type.IsGenericParameter ||
                    type.IsInterface)
                {
                    return typeof(object);
                }
                else
                {
                    return type;
                }
            }
        }
    }
}
