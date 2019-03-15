using System;

namespace Ordi.Attributes
{
    /// <summary>
    /// 字段对应属性.用于序列化
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class DataFieldAttribute : Attribute
    {
        /// <summary>
        /// 字段名
        /// </summary>
        public string FieldName { get; private set; }

        /// <summary>
        /// 显示名称
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 字段对应属性
        /// </summary>
        /// <param name="fieldName"></param>
        public DataFieldAttribute(string fieldName)
        {
            FieldName = fieldName;
        }
    }
}
