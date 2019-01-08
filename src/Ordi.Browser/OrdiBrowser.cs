using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CefSharp.WinForms;
using CefSharp;

namespace Ordi.Browser
{
    /// <summary>
    /// 封装CefSharp浏览器
    /// </summary>
    public partial class OrdiBrowser : UserControl
    {
        /// <summary>
        /// CefSharp Browser
        /// </summary>
        private ChromiumWebBrowser Browser { get; set; }

        /// <summary>
        /// 浏览器是否初始化
        /// </summary>
        private bool IsInitialize { get; set; }

        /// <summary>
        /// Web Url
        /// </summary>
        private string Url { get; set; }

        /// <summary>
        /// JS调用.NET处理事件
        /// 由.Net调用方订阅 Event-Driven
        /// </summary>
        public event EventHandler<BrowserHandlers.BrowserEventArgs> JsCallNetExecute;

        #region Structure
        /// <summary>
        /// 构造:默认
        /// </summary>
        public OrdiBrowser()
        {
            InitializeComponent();

            if (ParentForm != null)
            {
                ParentForm.FormClosing += ParentForm_FormClosing;
            }
        }

        /// <summary>
        /// 构造:传入Url地址
        /// </summary>
        /// <param name="url"></param>
        public OrdiBrowser(string url) : this()
        {
            Url = url;
        }
        #endregion

        #region Event Register
        /// <summary>
        /// 事件:父级Form关闭时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Browser.Load("about:blank");
        }

        /// <summary>
        /// 事件:初始化加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrdiBrowser_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            LoadCefSharp();
        }

        /// <summary>
        /// 加载Html页面
        /// </summary>
        private void LoadCefSharp()
        {
            if (string.IsNullOrEmpty(Url)) { return; }

            Browser = new ChromiumWebBrowser(Url) { Dock = DockStyle.Fill };
            Browser.MenuHandler = new BrowserHandlers.BrowserHandlers();
            Browser.RegisterJsObject("ordi", new BrowserHandlers.BrowserBound(this), false);
            Browser.IsBrowserInitializedChanged += Browser_IsBrowserInitializedChanged;
            this.Controls.Add(Browser);
            IsInitialize = true;
        }

        /// <summary>
        /// Browser初始化完成后触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Browser_IsBrowserInitializedChanged(object sender, IsBrowserInitializedChangedEventArgs e)
        {
            Browser.SetZoomLevel(0);//清除显示比例设置
        }
        #endregion

        #region About JS Call .NET 
        /// <summary>
        /// 异步调用:JS调用.Net方法,返回值,回调JS方法
        /// </summary>
        /// <param name="args1"></param>
        /// <param name="args2"></param>
        /// <param name="args3"></param>
        /// <returns></returns>
        internal string ExecuteAsyncCallBack(string args1, string args2, string args3)
        {
            var EventArgs = new BrowserHandlers.BrowserEventArgs(args1, args2, args3);
            JsCallNetExecute?.Invoke(this, EventArgs);
            return EventArgs?.State == Status.OrdiEventState.Succeed ? EventArgs.Result : string.Empty;
        }

        /// <summary>
        /// JS调用.Net方法,返回值,无回调
        /// </summary>
        /// <param name="args1"></param>
        /// <param name="args2"></param>
        /// <param name="args3"></param>
        internal string ExecuteCall(string args1, string args2, string args3)
        {
            var EventArgs = new BrowserHandlers.BrowserEventArgs(args1, args2, args3);
            JsCallNetExecute?.Invoke(this, EventArgs);
            return EventArgs?.State == Status.OrdiEventState.Succeed ? EventArgs.Result : string.Empty;
        }

        /// <summary>
        /// JS调用.Net方法,无返回值,无回调
        /// </summary>
        /// <param name="args1"></param>
        /// <param name="args2"></param>
        /// <param name="args3"></param>
        internal void DirectExecute(string args1, string args2, string args3)
        {
            var EventArgs = new BrowserHandlers.BrowserEventArgs(args1, args2, args3);
            JsCallNetExecute?.Invoke(this, EventArgs);
        }
        #endregion

        #region Browser Behavior
        /// <summary>
        /// 前进
        /// </summary>
        public void Back()
        {
            Browser?.Back();
        }

        /// <summary>
        /// 后退
        /// </summary>
        public void Forward()
        {
            Browser?.Forward();
        }

        /// <summary>
        /// 刷新
        /// </summary>
        public void Reload()
        {
            if (IsInitialize)
                Browser?.Reload();
            else
                LoadCefSharp();
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="ignoreCache"></param>
        public void Reload(bool ignoreCache)
        {
            if (IsInitialize)
                Browser?.Reload(ignoreCache);
            else
                LoadCefSharp();
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="uri"></param>
        public void Reload(Uri uri)
        {
            Reload(uri.ToString());
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="url"></param>
        public void Reload(string url)
        {
            if (IsInitialize)
                Browser?.Load(url);
            else
            {
                Url = url;
                LoadCefSharp();
            }
        }

        /// <summary>
        /// 开发者工具
        /// </summary>
        public void ShowDevTools()
        {
            Browser?.ShowDevTools();
        }

        /// <summary>
        /// 关闭开发者工具
        /// </summary>
        public void CloseDevTools()
        {
            Browser?.CloseDevTools();
        }
        #endregion
    }
}
