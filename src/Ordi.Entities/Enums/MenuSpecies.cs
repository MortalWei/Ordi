using System.ComponentModel;

namespace Ordi.Enums
{
    /// <summary>
    /// 菜单种类
    /// </summary>
    public enum MenuSpecies
    {
        /// <summary>
        /// 窗体菜单
        /// </summary>
        [Description("窗体菜单")]
        Winform = 0,
        /// <summary>
        /// 网页菜单
        /// </summary>
        [Description("网页菜单")]
        Web = 1
    }
}
