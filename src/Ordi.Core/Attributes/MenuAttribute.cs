using System;

namespace Ordi.Attributes
{
    /// <summary>
    /// 菜单基本信息
    /// 请填写Id,Name,Description属性
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class MenuAttribute : Attribute
    {
        public MenuAttribute() { }

        /// <summary>
        /// 菜单唯一标识
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 菜单说明
        /// </summary>
        public string Description { get; set; }
    }
}
