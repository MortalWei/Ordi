using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using static Ordi.OrdiConvert;

namespace Ordi
{
    public class ObjectProperty
    {
        /// <summary> 属性信息
        /// </summary>
        public PropertyInfo Info { get; set; }
        /// <summary> Set方法委托
        /// </summary>
        public PropertySetter Setter { get; set; }
        //缓存
        static readonly Dictionary<Type, ObjectProperty[]> Cache = new Dictionary<Type, ObjectProperty[]>();

        /// <summary> 获取一个类中的所有公开实例属性和它们的Set方法委托
        /// </summary>
        public static ObjectProperty[] GetProperties(Type type)
        {
            ObjectProperty[] arr;
            if (Cache.TryGetValue(type, out arr))//优先从缓存中获取
            {
                return arr;
            }
            PropertyInfo[] ps = type.GetProperties();
            arr = new ObjectProperty[ps.Length];
            for (int i = 0; i < ps.Length; i++)
            {
                ObjectProperty op = new ObjectProperty();
                op.Info = ps[i];
                op.Setter = CreateSetter(op.Info);  //之前定义的方法
                arr[i] = op;
            }
            Cache.Add(type, arr); //加入缓存
            return arr;
        }
        /// <summary> 创建指定属性的Set方法委托
        /// </summary>
        public static PropertySetter CreateSetter(PropertyInfo property)
        {
            var type = property.DeclaringType;//--实体
            var dm = new DynamicMethod("", null, new[] { typeof(object), typeof(object) }, type);//实体的动态
            //=== IL ===
            var il = dm.GetILGenerator();
            //var local = il.DeclareLocal(property.PropertyType, false);

            il.Emit(OpCodes.Ldarg_0);
            il.Emit(OpCodes.Ldarg_1);

            if (property.PropertyType.IsValueType)//判断属性类型是否是值类型
            {
                il.Emit(OpCodes.Unbox_Any, property.PropertyType);//如果是值类型就拆箱
            }
            else
            {
                il.Emit(OpCodes.Castclass, property.PropertyType);//否则强转
            }
            //il.Emit(OpCodes.Stloc, local);
            //il.Emit(OpCodes.Ldarg, local);


            il.Emit(OpCodes.Callvirt, property.GetSetMethod());
            il.Emit(OpCodes.Ret);
            //=== IL ===
            return (PropertySetter)dm.CreateDelegate(typeof(PropertySetter));
        }
    }
}
