using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Ordi
{
    public class ILoader : MarshalByRefObject
    {
        public ILoader()
        {
        }

        public Assembly LoadAssembly(string dllName)
        {
            return Assembly.LoadFrom(dllName);
        }
    }
}
