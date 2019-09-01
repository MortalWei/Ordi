using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web.Http.Dispatcher;

namespace OrdiOwin.Core.Settings
{
    public class ExtendedDefaultAssembliesResolver : DefaultAssembliesResolver    {        public override ICollection<Assembly> GetAssemblies()        {            ControllerSection settings = ControllerSection.GetSection();            if (null != settings)            {                foreach (ControllerElement element in settings.Controllers)                {
                    var files = Ordi.Files.OrdiFile.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Controllers"), "*.dll");

                    if (files != null && files.Exists(c => c.Name == element.ControllerName))
                    {
                        var file = files.Find(c => c.Name == element.ControllerName);
                        //Assembly.LoadFile(file.FullName);
                        var assemblyName2 = AssemblyName.GetAssemblyName(file.FullName);
                        if (!AppDomain.CurrentDomain.GetAssemblies().Any(assembly => AssemblyName.ReferenceMatchesDefinition(assembly.GetName(), assemblyName2)))
                        {
                            AppDomain.CurrentDomain.Load(assemblyName2);
                        }

                        continue;
                    }

                    AssemblyName assemblyName = AssemblyName.GetAssemblyName(element.ControllerName);
                    if (!AppDomain.CurrentDomain.GetAssemblies().Any(assembly => AssemblyName.ReferenceMatchesDefinition(assembly.GetName(), assemblyName)))
                    {
                        AppDomain.CurrentDomain.Load(assemblyName);
                    }
                }            }            return base.GetAssemblies();        }    }
}
