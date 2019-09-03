using Autofac;
using Microsoft.Owin.Hosting;
using OrdiOwin.Core.Filters;
using OrdiOwin.Core.Settings;
using Autofac.Integration.WebApi;
using System;
using System.Linq;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using Owin;

namespace OrdiOwin.Core
{
    /// <summary>
    /// SelfHost模式
    /// </summary>
    public class StartHandling
    {
        public static void StartEventRegister()
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            AppDomain.CurrentDomain.FirstChanceException += CurrentDomain_FirstChanceException;
        }

        public static StartOptions GetOptions()
        {
            var options = new StartOptions();
            options.Urls.Add("http://localhost:8080");
            options.Urls.Add("http://127.0.0.1:8080");
#if !DEBUG
            options.Urls.Add("http://*:8080");
#endif
            return options;
        }

        public static void GetConfiguration(Owin.IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            config.Filters.Add(new ExceptionHandlingAttribute());
            config.Filters.Add(new ActionHandlingFilter());

            config.Services.Replace(typeof(IAssembliesResolver), new ExtendedDefaultAssembliesResolver());
            config.Routes.MapHttpRoute(
                name: "DefaultAPi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );

            //config.Formatters.JsonFormatter.UseDataContractJsonSerializer = true;
            //config.Formatters.Remove(config.Formatters.XmlFormatter);
            //config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            config.Formatters.XmlFormatter.UseXmlSerializer = true;
            config.Formatters.Remove(config.Formatters.JsonFormatter);

            var builder = new ContainerBuilder();
            //builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            //var types = config.Services.GetAssembliesResolver().GetAssemblies().SelectMany(c => c.GetTypes());
            //var type = typeof(ApiController);
            //var list = types.Where(c => type.IsAssignableFrom(type) && c.IsClass && !c.IsAbstract);
            //builder.RegisterApiControllers(list.ToArray());

            //var assemblies = config.Services.GetAssembliesResolver().GetAssemblies();

            foreach (var item in config.Services.GetAssembliesResolver().GetAssemblies())
            {
                if (item.FullName.IndexOf(".Controller", StringComparison.OrdinalIgnoreCase) > -1)
                    builder.RegisterApiControllers(item);
            }

            //builder.RegisterApiControllers(config.Services.GetAssembliesResolver().GetAssemblies())
            builder.RegisterWebApiFilterProvider(config);
            //builder.RegisterType<CustomActionFilter>()
            //    .AsWebApiActionFilterFor<TestController>()
            //    .InstancePerRequest();
            builder.Register(c => new Logger()).As<ILogger>().InstancePerRequest();
            //builder.Register(c=>c.)


            // Create and assign a dependency resolver for Web API to use.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            app.UseAutofacMiddleware(container);
            app.UseAutofacWebApi(config);
            app.UseWebApi(config);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine(e.ExceptionObject.ToString());
        }

        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            AssemblyName assemblyName = new AssemblyName(args.Name);

            var assemblyAllName = assemblyName.Name + ".dll";

            Console.WriteLine(assemblyAllName);

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

        private static void CurrentDomain_FirstChanceException(object sender, System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs e)
        {
            Console.WriteLine("FirstChanceException:\r\n" + e.ToString());
        }
    }
}
