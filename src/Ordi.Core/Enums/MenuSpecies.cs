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
        Web = 1,
        /// <summary>
        /// 菜单组
        /// </summary>
        [Description("菜单组")]
        Group = 2,
        /// <summary>
        /// 下拉菜单
        /// </summary>
        [Description("下拉菜单")]
        DropDown = 3,
        /// <summary>
        /// 对话框
        /// </summary>
        [Description("对话框")]
        ShowDiaglog = 4
    }
}
