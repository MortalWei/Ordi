using Ordi.IBusiness;
using Ordi.Utils.Proxy;
using System.Data;

namespace Ordi.App.Proxy
{
    /// <summary>
    /// 
    /// </summary>
    public class LoginFactory : WcfBase<ILoginBusiness>
    {
        public LoginFactory() : base("net.tcp://localhost:10101/OrdiServer")
        {

        }

        public LoginFactory(string hostAddress) : base(hostAddress)
        {

        }

        public DataSet GetData()
        {
            return WcfProxy.DoWork(this, proxy => proxy.Channel.GetStaff("0"));
        }
    }
}
