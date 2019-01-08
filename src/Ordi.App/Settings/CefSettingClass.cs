using CefSharp;
using System;
using System.IO;
using System.Windows.Forms;

namespace Ordi
{
    public class CefSettingClass
    {
        public const string CefLibName = "CefSharp";
        public const string LocalesName = "locales";
        public const string LogsName = "CefSharp.log";

        /// <summary>
        /// 初始化CEF的配置
        /// </summary>
        public static void InitializeCefSetting()
        {
            var browser = Path.Combine(Application.StartupPath, CefLibName, "CefSharp.BrowserSubprocess.exe");
            var locales = Path.Combine(Application.StartupPath, CefLibName, LocalesName);
            var res = Path.Combine(Application.StartupPath, CefLibName);
            var logs = Path.Combine(Application.StartupPath, LogsName);


            //var browser = Path.Combine(Application.StartupPath, @"Library\Cef", "CefSharp.BrowserSubprocess.exe");
            //var locales = Path.Combine(Application.StartupPath, @"Library\Cef", "locales");
            //var res = Path.Combine(Application.StartupPath, @"Library\Cef");
            //var logs = Path.Combine(Application.StartupPath, @"CefSharp.log");

            //var browser = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Library\Cef", "CefSharp.BrowserSubprocess.exe");
            //var locales = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Library\Cef", "locales");
            //var res = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Library\Cef");
            //var logs = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"CefSharp.log");

            CefSettings settings = new CefSettings
            {
                Locale = "zh-CN",
                BrowserSubprocessPath = browser,
                LocalesDirPath = locales,
                ResourcesDirPath = res,
                LogFile = logs
            };
            Cef.Initialize(settings);
            Cef.EnableHighDPISupport();
        }
    }
}