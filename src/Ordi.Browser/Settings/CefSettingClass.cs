using CefSharp;
using System.IO;
using System.Windows.Forms;

namespace Ordi.Browser.Settings
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