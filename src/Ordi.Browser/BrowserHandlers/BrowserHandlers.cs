using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ordi.Browser.BrowserHandlers
{
    /// <summary>
    /// 浏览器右键菜单处理
    /// </summary>
    internal class BrowserHandlers : IContextMenuHandler
    {
        private const int ShowDevTools = 26501;
        private const int CloseDevTools = 26502;

        /// <summary>
        /// 设置右键菜单
        /// </summary>
        /// <param name="browserControl"></param>
        /// <param name="browser"></param>
        /// <param name="frame"></param>
        /// <param name="parameters"></param>
        /// <param name="model"></param>
        public void OnBeforeContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
        {
#if DEBUG
            model.Clear();
            model.AddItem((CefMenuCommand)ShowDevTools, "Show DevTools");
            model.AddItem((CefMenuCommand)CloseDevTools, "Close DevTools");
#endif
        }

        /// <summary>
        /// 菜单响应事件
        /// </summary>
        /// <param name="browserControl"></param>
        /// <param name="browser"></param>
        /// <param name="frame"></param>
        /// <param name="parameters"></param>
        /// <param name="commandId"></param>
        /// <param name="eventFlags"></param>
        /// <returns></returns>
        public bool OnContextMenuCommand(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
        {
#if DEBUG
            if ((int)commandId == ShowDevTools)
            {
                browser.ShowDevTools();
            }
            if ((int)commandId == CloseDevTools)
            {
                browser.CloseDevTools();
            }
#endif
            return false;
        }

        public void OnContextMenuDismissed(IWebBrowser browserControl, IBrowser browser, IFrame frame)
        {

        }

        /// <summary>
        /// 菜单加载状态处理
        /// </summary>
        /// <param name="browserControl"></param>
        /// <param name="browser"></param>
        /// <param name="frame"></param>
        /// <param name="parameters"></param>
        /// <param name="model"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public bool RunContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
        {
#if DEBUG
            return false;
#else
            return true;
#endif
        }
    }
}

