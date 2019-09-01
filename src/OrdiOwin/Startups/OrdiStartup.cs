using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(OrdiOwin.Startups.OrdiStartup))]
namespace OrdiOwin.Startups
{
    public class OrdiStartup
    {
        public void Configuration(IAppBuilder app)
        {
#if DEBUG
            app.UseErrorPage();
#endif
            OrdiOwin.Core.StartHandling.GetConfiguration(app);
            //HttpConfiguration config = new HttpConfiguration();
            //config.Filters.Add(new ExceptionHandlingAttribute());
            //config.Filters.Add(new ActionHandlingFilter());
            //config.Services.Replace(typeof(IAssembliesResolver), new ExtendedDefaultAssembliesResolver());
            //config.Routes.MapHttpRoute(
            //    name: "DefaultAPi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //    );

            ////config.Formatters.JsonFormatter.UseDataContractJsonSerializer = true;
            ////config.Formatters.Remove(config.Formatters.XmlFormatter);
            ////config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            //config.Formatters.XmlFormatter.UseXmlSerializer = true;
            //config.Formatters.Remove(config.Formatters.JsonFormatter);

            //app.UseWebApi(config);
        }
    }
}
