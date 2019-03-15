using System;

namespace Ordi.Attributes
{
    /// <summary>
    /// 枚举对应属性.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    public class DataEnumAttribute : Attribute
    {
        /// <summary>
        /// 显示名称
        /// </summary>
        public string ShowName { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 枚举对应属性
        /// </summary>
        public DataEnumAttribute() { }
    }
}
