using Ordi.Entities;
using System.Collections.Generic;

namespace Ordi
{
    /// <summary>
    /// 应用相关变量集
    /// </summary>
    public static class PubVar
    {
        /// <summary>
        /// 当前应用已经注册的菜单
        /// </summary>
        public static List<MenuModel> Menus { get; set; }

        /// <summary>
        /// 当前应用Id
        /// </summary>
        public static string AppId { get; set; }

        /// <summary>
        /// 当前应用已经打开的菜单(RibbonPage)
        /// </summary>
        public static List<MenuModel> OpenedMenus { get; set; }

        /// <summary>
        /// 当前选中(显示)的菜单(RibbonPage)
        /// </summary>
        public static MenuModel SelectedMenu { get; set; }
    }
}
