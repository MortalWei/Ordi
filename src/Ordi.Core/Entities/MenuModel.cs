using Ordi.Enums;
using System;
using System.Runtime.Serialization;

namespace Ordi.Entities
{
    /// <summary>
    /// 菜单信息
    /// </summary>
    [Serializable]
    [DataContract]
    public sealed class MenuModel
    {
        /// <summary>
        /// 菜单Id
        /// </summary>
        [DataMember]
        public string Id { get; set; }

        /// <summary>
        /// 父级菜单Id
        /// </summary>
        [DataMember]
        public string Parid { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// 菜单显示名称
        /// </summary>
        [DataMember]
        public string ShowName { get; set; }

        /// <summary>
        /// 菜单种类
        /// </summary>
        [DataMember]
        public string Category { get; set; }

        /// <summary>
        /// 菜单简介
        /// </summary>
        [DataMember]
        public string About { get; set; }

        /// <summary>
        /// 菜单种类
        /// </summary>
        [DataMember]
        public MenuSpecies Species { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [DataMember]
        public int Sort { get; set; }

        /// <summary>
        /// 路径
        /// DLL名称或URL
        /// </summary>
        [DataMember]
        public string Path { get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [DataMember]
        public string NameSpace { get; set; }

        /// <summary>
        /// 类名
        /// </summary>
        [DataMember]
        public string ClassName { get; set; }

        /// <summary>
        /// 菜单状态
        /// </summary>
        [DataMember]
        public MenuState State { get; set; }
    }
}
