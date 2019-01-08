using DevExpress.XtraEditors;
using System;
using System.IO;
using System.Windows.Forms;
using Ordi;

namespace Ordi.App
{
    public partial class FmLogin : XtraForm
    {
        private Browser.OrdiBrowser Browser;

        private string LoginFilePath = Path.Combine(Application.StartupPath, "Html", "login.html");

        /// <summary>
        /// 登录界面
        /// </summary>
        public FmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化加载界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FmLogin_Load(object sender, EventArgs e)
        {
            Browser = new Browser.OrdiBrowser(LoginFilePath)
            {
                Dock = DockStyle.Fill
            };

            Controls.Add(Browser);

            RegisterBrowserEvent();
        }

        /// <summary>
        /// 订阅Browser事件
        /// 提供JS调用.NET方法入口
        /// </summary>
        private void RegisterBrowserEvent()
        {
            Browser.JsCallNetExecute += Browser_JsCallNetExecute;
        }

        /// <summary>
        /// JS调用.NET方法 通过该事件实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Browser_JsCallNetExecute(object sender, Browser.BrowserHandlers.BrowserEventArgs e)
        {
            e.Result = true.ToIntStr();
        }
    }
}