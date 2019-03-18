using Ordi.sBusiness;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.ServiceModel;

namespace Ordi.ConsoleHost
{
    class Program
    {
        [DllImport("User32.dll ", CharSet = CharSet.None, ExactSpelling = false)]
        private static extern int FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll ", CharSet = CharSet.None, ExactSpelling = false)]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, IntPtr bRevert);

        [DllImport("user32.dll ", CharSet = CharSet.None, ExactSpelling = false)]
        private static extern int RemoveMenu(IntPtr hMenu, int nPos, int flags);

        static void Main(string[] args)
        {
            #region Event
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            #endregion Event

            Console.Title = "Ordi Service";
            string str = string.Concat(Environment.CurrentDirectory, "\\Ordi.ConsoleHost.exe");
            int num = FindWindow(null, str);
            IntPtr systemMenu = GetSystemMenu((IntPtr)num, IntPtr.Zero);
            RemoveMenu(systemMenu, 61536, 0);

            using (ServiceHost host = new ServiceHost(typeof(LoginBusiness)))
            {
                try
                {
                    host.Open();
                    DateTime now = DateTime.Now;
                    Console.WriteLine(string.Concat("Start Time：", now.ToString("yyyy-MM-dd HH:mm:ss")));
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Ordi Service Start-up！");
                    Console.ReadKey();
                    bool flag = true;
                    while (flag)
                    {
                        string str1 = Console.ReadLine().Trim();
                        if (str1 == "exit")
                        {
                            flag = false;
                        }
                        else if (str1 == "help")
                        {
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("Enter 'Exit', Close the service.");
                            Console.WriteLine("----------------------------------");
                        }
                        else
                        {
                            Console.WriteLine(string.Format("'{0}' is an invalid command.\r\nEnter 'help' to see the command help.", str1));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logs.Error("服务异常", ex);
                }
                finally
                {
                    host.Close();
                }
            }
        }

        /// <summary>
        /// 解析失败的程序集加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            AssemblyName assemblyName = new AssemblyName(args.Name);

            var assemblyAllName = assemblyName.Name + ".dll";

            if (Ordi.Files.OrdiFile.LibFiles != null && Ordi.Files.OrdiFile.LibFiles.Exists(c => c.Name == assemblyAllName))
            {
                var file = Ordi.Files.OrdiFile.LibFiles.Find(c => c.Name == assemblyAllName);
                return Assembly.LoadFile(file.FullName);
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
