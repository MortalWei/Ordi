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
        public string Id { get; set; }
        /// <summary>
        /// 应用名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 应用简介
        /// </summary>
        public string About { get; set; }
    }
}
