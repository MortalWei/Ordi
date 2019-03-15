using Ordi.IBusiness;
using Ordi.Proxy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Ordi.App.Proxy
{
    /// <summary>
    /// 
    /// </summary>
    public class LoginProxy : WcfProxy<ILoginBusiness>
    {
        public LoginProxy()
        {
        }

        protected LoginProxy(string hostAddress) : base(hostAddress)
        {
        }

        public DataSet GetData()
        {

        }
    }
}
