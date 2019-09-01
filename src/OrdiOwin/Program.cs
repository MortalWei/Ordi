using Microsoft.Owin.Hosting;
using System;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace OrdiOwin
{
    class Program
    {
        static void Main(string[] args)
        {
            Core.StartHandling.StartEventRegister();

            var options = Core.StartHandling.GetOptions();

            using (WebApp.Start<Startups.OrdiStartup>(options))
            {
                Console.WriteLine("Ordi Owin Service Start");

                var startFlag = true;
                while (startFlag)
                {
                    var str = Console.ReadLine();
                    switch (str)
                    {
                        case "exit":
                            startFlag = false;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
