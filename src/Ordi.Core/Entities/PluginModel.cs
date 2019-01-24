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
        [DataMember]
        public string Id { get; set; }
        /// <summary>
        /// 插件名称
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// 插件说明
        /// </summary>
        [DataMember]
        public string Description { get; set; }
        /// <summary>
        /// 插件路径
        /// </summary>
        [DataMember]
        public string Path { get; set; }
        /// <summary>
        /// 命名空间
        /// </summary>
        [DataMember]
        public string NameSpace { get; set; }
        /// <summary>
        /// 类
        /// </summary>
        [DataMember]
        public string ClassName { get; set; }
        /// <summary>
        /// 插件状态
        /// </summary>
        [DataMember]
        public MenuState State { get; set; }
    }
}
