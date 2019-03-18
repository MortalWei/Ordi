using Ordi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ordi.Utils.Data
{
    public sealed class OrdiVar
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
