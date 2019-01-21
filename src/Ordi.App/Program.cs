using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using Ordi.App.Behavior;
using Ordi.Browser.Settings;
using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Ordi.App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            #region Event
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.ThreadException += Application_ThreadException;
            Logs.Debug("事件订阅完成");
            #endregion Event

            #region Browser注册
            CefSettingClass.InitializeCefSetting();
            Logs.Debug("CefSharp初始化");
            #endregion Browser注册

            #region Dev皮肤注册
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            SkinManager.EnableMdiFormSkins();//多文档皮肤支持
            UserLookAndFeel.Default.SetSkinStyle("Office 2013 Dark Gray");//设置默认皮肤样式
            #endregion Dev皮肤注册

            #region Default
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            #endregion Default

            #region Login
            FmLogin fm = new FmLogin();
            if (fm.ShowDialog() == DialogResult.OK)
            {
                MenuBehavior.InitializeLocal();
                Application.Run(new FmMain());
            }
            else
            {
                MenuBehavior.InitializeLocal();
                Application.Run(new FmMain());
            }
            #endregion Login

        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Logs.Fatal("CurrentDomain_UnhandledException", e.ExceptionObject as Exception);
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Logs.Fatal("Application_ThreadException", e.Exception);
        }

        /// <summary>
        /// 解析失败的程序集会在此处加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private static System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            AssemblyName assemblyName = new AssemblyName(args.Name);

            var assemblyAllName = assemblyName.Name + ".dll";
            //加载CefSharp相关库
            if (args.Name.StartsWith("CefSharp"))
            {
                string assemblyPath = Path.Combine(Application.StartupPath, CefSettingClass.LibraryName, CefSettingClass.CefLibName, assemblyAllName);
                return File.Exists(assemblyPath) ? Assembly.LoadFile(assemblyPath) : null;
            }

            //判断程序集的区域性
            if (!assemblyName.CultureInfo.Equals(CultureInfo.InvariantCulture))
            {
                assemblyAllName = string.Format(@"{0}\{1}", assemblyName.CultureInfo, assemblyAllName);
            }

            using (Stream stream = executingAssembly.GetManifestResourceStream(assemblyAllName))
            {
                if (stream == null) return null;

                var assemblyRawBytes = new byte[stream.Length];
                stream.Read(assemblyRawBytes, 0, assemblyRawBytes.Length);
                return Assembly.Load(assemblyRawBytes);
            }
        }
    }
}
