using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace Ordi
{
    public class OrdiConvert
    {
        public delegate void PropertySetter(object instance, object val);
        //public static PropertySetter CreateSetter(PropertyInfo property)
        //{
        //    var type = property.DeclaringType;
        //    var dm = new DynamicMethod("", null, new[] { typeof(object), typeof(object) }, type);
        //    //=== IL ===
        //    var il = dm.GetILGenerator();
        //    il.Emit(OpCodes.Ldarg_0);
        //    il.Emit(OpCodes.Ldarg_1);
        //    if (property.PropertyType.IsValueType)//判断属性类型是否是值类型
        //    {
        //        il.Emit(OpCodes.Unbox, property.PropertyType);//如果是值类型就拆箱
        //    }
        //    else
        //    {
        //        il.Emit(OpCodes.Castclass, property.PropertyType);//否则强转
        //    }
        //    il.Emit(OpCodes.Callvirt, property.GetSetMethod());
        //    il.Emit(OpCodes.Ret);
        //    //=== IL ===
        //    return (PropertySetter)dm.CreateDelegate(typeof(PropertySetter));
        //}
        public static List<T> ConvertToModels<T>(DataSet ds) where T : new()
        {
            var prop = ObjectProperty.GetProperties(typeof(T));
            List<T> list = new List<T>(ds.Tables[0].Rows.Count);
            var cols = ds.Tables[0].Columns;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                T m = new T();
                foreach (var p in prop)
                {
                    if (cols.Contains(p.Info.Name))
                    {
                        var val = row[p.Info.Name];
                        if ((val is DBNull) == false)
                        {
                            p.Setter(m, val);
                        }
                    }
                }
                list.Add(m);
            }
            return list;
        }
    }

    /**
     * 引用: 玩转动态编译 - 高级篇：三,实例属性的读取与设置
     * https://www.cnblogs.com/blqw/p/3261240.html
     */
}
