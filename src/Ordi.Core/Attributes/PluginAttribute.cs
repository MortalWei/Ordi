using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ordi.Attributes
{
    /// <summary>
    /// 插件基本信息
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class PluginAttribute : Attribute
    {
        public PluginAttribute()
        {
        }

        /// <summary>
        /// 插件唯一标识
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 插件名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 插件说明
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 插件种类
        /// </summary>
        public string Category { get; set; }
    }
}
