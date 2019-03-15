using Ordi.Attributes;
using Ordi.Enums;
using System;
using System.Runtime.Serialization;

namespace Ordi.Entities
{
    /// <summary>
    /// 插件信息
    /// </summary>
    [DataContract]
    [Serializable]
    public class PluginModel
    {
        /// <summary>
        /// 插件Id
        /// </summary>
        [DataField("PID", DisplayName = "插件唯一标识", Description = "插件唯一标识")]
        [DataMember]
        public string Id { get; set; }

        /// <summary>
        /// 插件名称
        /// </summary>
        [DataField("PNAME", DisplayName = "插件名称", Description = "插件名称")]
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// 插件说明
        /// </summary>
        [DataField("PDESCRIPTION", DisplayName = "插件说明", Description = "插件说明")]
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// 插件路径
        /// </summary>
        [DataField("FILEPATH", DisplayName = "插件路径", Description = "插件所在控件的物理路径")]
        [DataMember]
        public string Path { get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [DataField("NAMESPACE", DisplayName = "命名空间", Description = "命名空间")]
        [DataMember]
        public string NameSpace { get; set; }

        /// <summary>
        /// 类
        /// </summary>
        [DataField("CLASSNAME", DisplayName = "类", Description = "类")]
        [DataMember]
        public string ClassName { get; set; }

        /// <summary>
        /// 插件状态
        /// </summary>
        [DataField("STATE", DisplayName = "状态", Description = "状态")]
        [DataMember]
        public MenuState State { get; set; }
    }
}
