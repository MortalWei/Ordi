using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdiOwin.Core.Middlewares
{
    public class IpMiddleware : OwinMiddleware
    {
        public override Task Invoke(IOwinContext context)
        {
            throw new NotImplementedException();
        }
    }
}
