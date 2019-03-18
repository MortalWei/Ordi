using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;

namespace Ordi.Utils.Proxy
{
    public static class WcfProxy
    {
        public static TReturn DoWork<T, TReturn>(T proxy, Func<T, TReturn> method) where T : ICommunicationObject, new()
        {
            using (proxy as IDisposable)
            {
                return proxy.Using(method);
            }
        }

        public static TReturn Using<T, TReturn>(this T proxy, Func<T, TReturn> method) where T : ICommunicationObject, new()
        {
            try
            {
                var _Endpoint = proxy.GetType().GetProperty("Endpoint").GetValue(proxy, null) as ServiceEndpoint;
                if (!RetryWcfPing(_Endpoint.Address.Uri.Host, _Endpoint.Address.Uri.Port))
                {
                    var _msg = "IP地址:" + _Endpoint.Address.Uri.Host + "端口：" + _Endpoint.Address.Uri.Port + "无法链接!\r\n请保持网络通畅！";
                    return default(TReturn);
                }
                else
                {
                    if (proxy.State == CommunicationState.Closed || proxy.State == CommunicationState.Faulted)
                        proxy = new T();
                    var _ret = method(proxy);
                    proxy.Abort();
                    return _ret;
                }
            }
            catch (CommunicationException ex)
            {
                proxy.Abort();
                Logs.Error("CommunicationException", ex);
                return default(TReturn);
            }
            catch (TimeoutException ex)
            {
                proxy.Abort();
                Logs.Error("TimeoutException", ex);
                return default(TReturn);
            }
            catch (Exception ex)
            {
                proxy.Abort();
                Logs.Error("契约Exception", ex);
                return default(TReturn);
            }
        }

        public static bool RetryWcfPing(string _Ip, int _Port)
        {
            var _Rt = false;
            IPEndPoint _Point = new IPEndPoint(IPAddress.Parse(_Ip.ToLower().Replace("localhost", "127.0.0.1")), _Port);
            Socket _Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                _Socket.ReceiveTimeout = 1000;
                _Socket.Connect(_Point);
                _Rt = true;
            }
            catch (Exception ex)
            {
                Logs.Error("Ping地址不通，执行方法RetryWcfPing，错误如下：", ex);
                _Rt = false;
            }
            finally
            {
                _Socket.Close();
                _Socket.Dispose();
            }
            return _Rt;
        }
    }
}
