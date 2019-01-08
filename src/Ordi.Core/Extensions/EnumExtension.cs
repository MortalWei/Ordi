using Ordi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace Ordi
{
    /// <summary>
    /// Enum扩展辅助类
    /// </summary>
    public static class EnumExtension
    {
        /// <summary>
        /// Enum转换成值列表
        /// </summary>
        /// <param name="args">
        /// 枚举类型
        /// </param>
        /// <param name="ignoreStr">
        /// 值忽略列表,多个值以","分隔.例:"1,2,3"
        /// </param>
        /// <returns>EnumObject集合</returns>
        public static List<EnumObject> ToList(this Type args, string ignoreStr = "")
        {
            if (!args.IsEnum)
            {
                throw new InvalidOperationException();
            }

            var result = new List<EnumObject>();
            var ignores = ignoreStr.Split(',');
            var fields = args.GetFields();
            foreach (FieldInfo field in fields)
            {
                if (!field.FieldType.IsEnum)
                {
                    continue;
                }

                var value = (int)args.InvokeMember(field.Name, BindingFlags.GetField, null, null, null, CultureInfo.InvariantCulture);
                if (Array.IndexOf(ignores, value) > -1)
                {
                    continue;
                }
                var name = args.InvokeMember(field.Name, BindingFlags.GetField, null, null, null, CultureInfo.InvariantCulture).ToString();

                var arr = field.GetCustomAttributes(typeof(DescriptionAttribute), false);

                var desc = arr.Length > 0 ? ((DescriptionAttribute)arr[0]).Description : string.Empty;

                result.Add(new EnumObject
                {
                    Id = value,
                    Name = name,
                    Desc = desc
                });
            }
            return result;
        }

        /// <summary>
        /// 转换枚举说明
        /// </summary>
        /// <param name="args"></param>
        /// <returns>
        /// 若没有Description属性,则返回枚举名称
        /// </returns>
        public static string ToDesc(this Enum args)
        {
            var field = args.GetType().GetField(args.ToString());
            var attrs = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attrs.Length > 0 ? attrs[0].Description : args.ToString();
        }

        /// <summary>
        /// 转换枚举值列表
        /// </summary>
        /// <param name="args"></param>
        /// <param name="split">位枚举分隔符</param>
        /// <returns>
        /// 非位域直接返回值
        /// 位域返回值列表,使用split分隔 例:"1,2,3",位域返回的是开方后的值
        /// </returns>
        public static string ToValues(this Enum args, string split = ",")
        {
            var names = args.ToString().Split(',');
            string[] res = new string[names.Length];
            var type = args.GetType();
            for (int i = 0; i < names.Length; i++)
            {
                var field = type.GetField(names[i].Trim());
                if (field == null) continue;
                res[i] = GetValue(field);
            }
            return string.Join(split, res);
        }

        /// <summary>
        /// 获取枚举的值
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        private static string GetValue(FieldInfo field)
        {
            var att = (int)field.GetValue(field.Name);
            var result = att.ToPower();
            return result.ToString();
        }
    }
}
