using Ordi.Attributes;
using Ordi.Enums;
using System;
using System.Runtime.Serialization;

namespace Ordi.Entities
{
    /// <summary>
    /// 应用信息
    /// </summary>
    [Serializable]
    [DataContract]
    public sealed class AppModel
    {
        /// <summary>
        /// 应用Id
        /// </summary>
        [DataField("EMPID", DisplayName = "唯一标识", Description = "员工唯一标识")]
        [DataMember]
        public string Id { get; set; }
        /// <summary>
        /// 应用名称
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// 应用简介
        /// </summary>
        [DataMember]
        public string About { get; set; }
        /// <summary>
        /// 应用种类
        /// </summary>
        [DataMember]
        public AppSpecies Species { get; set; }
        [DataMember]
        public string HomePage { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        [DataMember]
        public int Sort { get; set; }
    }
}
