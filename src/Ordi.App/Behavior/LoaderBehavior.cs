using System;
using System.Security.Policy;

namespace Ordi.App.Behavior
{
    /// <summary>
    /// 程序集加载
    /// </summary>
    internal sealed class LoaderBehavior
    {
        /// <summary>
        /// 获取新的应用程序域
        /// </summary>
        /// <param name="friendlyName">域名称</param>
        /// <returns></returns>
        public static AppDomain CreateDomain(string friendlyName)
        {
            AppDomainSetup setup = new AppDomainSetup();
            setup.ApplicationBase = AppDomain.CurrentDomain.BaseDirectory;
            //setup.PrivateBinPath = folderPath;
            //setup.CachePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cache");
            //setup.ShadowCopyFiles = "true";
            //setup.ShadowCopyDirectories = AppDomain.CurrentDomain.BaseDirectory;
            setup.DisallowBindingRedirects = false;
            //setup.ConfigurationFile = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
            setup.ApplicationName = "Shadow";
            // Set up the Evidence
            Evidence baseEvidence = AppDomain.CurrentDomain.Evidence;
            Evidence evidence = new Evidence(baseEvidence);

            AppDomain domain = AppDomain.CreateDomain(friendlyName, evidence, setup);

            return domain;
        }
    }
}
