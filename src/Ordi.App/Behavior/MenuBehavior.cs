using Ordi.Attributes;
using Ordi.Entities;
using Ordi.Utils.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ordi.App.Behavior
{
    /// <summary>
    /// 菜单&部件
    /// </summary>
    internal sealed class MenuBehavior
    {
        /// <summary>
        /// 初始化系统菜单
        /// </summary>
        public static void InitializeSystemMenu()
        {
            if (OrdiVar.Menus == null)
            {
                OrdiVar.Menus = new List<MenuModel>();
            }

            AddMenus(System.Reflection.Assembly.GetCallingAssembly(), 1);
        }

        private static void AddMenus(System.Reflection.Assembly assembly, int serial)
        {
            var types = assembly.GetTypes().Where(c => c.GetCustomAttributes(typeof(MenuAttribute), false).Length > 0);
            if (types == null || types.Count() == 0) return;

            foreach (Type tp in types)
            {
                var attr = tp.GetCustomAttributes(typeof(MenuAttribute), false)?[0] as MenuAttribute;
                var menu = new MenuModel()
                {
                    Id = string.IsNullOrEmpty(attr.Id) ? tp.Namespace + tp.Name : attr.Id,
                    Name = string.IsNullOrEmpty(attr.Name) ? tp.Name : attr.Name,
                    ShowName = string.IsNullOrEmpty(attr.Name) ? tp.Name : attr.Name,
                    Category = attr.Category,
                    About = attr.Description,
                    Species = Enums.MenuSpecies.Winform,
                    Path = System.IO.Path.GetFileName(assembly.Location),
                    NameSpace = tp.Namespace,
                    ClassName = tp.Name,
                    State = Enums.MenuState.Normal,
                    Sort = serial++
                };
                OrdiVar.Menus.Add(menu);
            }
        }

        /// <summary>
        /// 初始化本地可用菜单
        /// </summary>
        public static void InitializeLocalMenu()
        {
            var folderPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Apps");
            var filePaths = System.IO.Directory.GetFiles(folderPath, "*.Utils.dll");

            var domain = LoaderBehavior.CreateDomain("InitializeLocalMenuDomain");

            if (OrdiVar.Menus == null)
            {
                OrdiVar.Menus = new List<MenuModel>();
            }
            var serial = 1;
            foreach (var path in filePaths)
            {
                var dllName = System.IO.Path.GetFileName(path);

                var loader = domain.CreateInstanceFromAndUnwrap(path, dllName.Replace(".dll", ".") + "RemoteLoader") as ILoader;

                var ass = loader.LoadAssembly(path);

                AddMenus(ass, serial);

                //var types = ass.GetTypes().Where(c => c.GetCustomAttributes(typeof(MenuAttribute), false).Length > 0);
                //if (types == null || types.Count() == 0) return;

                //foreach (Type tp in types)
                //{
                //    var attr = tp.GetCustomAttributes(typeof(MenuAttribute), false)?[0] as MenuAttribute;
                //    var menu = new MenuModel()
                //    {
                //        Id = string.IsNullOrEmpty(attr.Id) ? tp.Namespace + tp.Name : attr.Id,
                //        Name = string.IsNullOrEmpty(attr.Name) ? tp.Name : attr.Name,
                //        ShowName = string.IsNullOrEmpty(attr.Name) ? tp.Name : attr.Name,
                //        Category = attr.Category,
                //        About = attr.Description,
                //        Species = Enums.MenuSpecies.Winform,
                //        Path = System.IO.Path.GetFileName(ass.Location),
                //        NameSpace = tp.Namespace,
                //        ClassName = tp.Name,
                //        State = Enums.MenuState.Normal,
                //        Sort = serial++
                //    };
                //    OrdiVar.Menus.Add(menu);
                //}
            }
            AppDomain.Unload(domain);
        }

        /// <summary>
        /// 初始化本地可用插件
        /// </summary>
        public static void InitializeLocalPlugin()
        {
            var folderPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins");
            var filePaths = System.IO.Directory.GetFiles(folderPath, "*.Plugin.dll");

            var domain = LoaderBehavior.CreateDomain("InitializeLocalMenuDomain");

            if (OrdiVar.Menus == null)
            {
                OrdiVar.Menus = new List<MenuModel>();
            }
            var serial = 1;
            foreach (var path in filePaths)
            {
                var dllName = System.IO.Path.GetFileName(path);

                var loader = domain.CreateInstanceFromAndUnwrap(path, dllName.Replace(".dll", ".") + "RemoteLoader") as ILoader;

                var ass = loader.LoadAssembly(path);

                var types = ass.GetTypes().Where(c => c.GetCustomAttributes(typeof(MenuAttribute), false).Length > 0);
                if (types == null || types.Count() == 0) return;

                foreach (Type tp in types)
                {
                    var attr = tp.GetCustomAttributes(typeof(MenuAttribute), false)?[0] as MenuAttribute;
                    var menu = new MenuModel()
                    {
                        Id = string.IsNullOrEmpty(attr.Id) ? tp.Namespace + tp.Name : attr.Id,
                        Name = string.IsNullOrEmpty(attr.Name) ? tp.Name : attr.Name,
                        ShowName = string.IsNullOrEmpty(attr.Name) ? tp.Name : attr.Name,
                        About = attr.Description,
                        Species = Enums.MenuSpecies.Winform,
                        Path = System.IO.Path.GetFileName(ass.Location),
                        NameSpace = tp.Namespace,
                        ClassName = tp.Name,
                        State = Enums.MenuState.Normal,
                        Sort = serial++
                    };
                    OrdiVar.Menus.Add(menu);
                }
            }
            AppDomain.Unload(domain);
        }
    }
}
