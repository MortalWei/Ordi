using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Ordi.Utils.Proxy
{
    /// <summary>
    /// WCF代理
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class WcfBase<T> : ClientBase<T> where T : class
    {
        /// <summary>
        /// WCF代理
        /// </summary>
        public WcfBase() { }

        protected WcfBase(string hostAddress) : base(NetTcp, new EndpointAddress(hostAddress))
        {
            ContractDescription contract = this.Endpoint.Contract;

            foreach (OperationDescription operation in contract.Operations)
            {
                DataContractSerializerOperationBehavior behavior = operation.Behaviors.Find<DataContractSerializerOperationBehavior>();
                if (behavior == null)
                {
                    behavior = new DataContractSerializerOperationBehavior(operation);
                    operation.Behaviors.Add(behavior);
                }
                behavior.MaxItemsInObjectGraph = int.MaxValue;
                behavior.IgnoreExtensionDataObject = true;
            }
            HostAddress = hostAddress;
        }

        /// <summary>
        /// 主机地址
        /// </summary>
        public string HostAddress { get; protected set; }

        /// <summary>
        /// TCP协议绑定
        /// </summary>
        private static NetTcpBinding NetTcp
        {
            get
            {
                return new NetTcpBinding
                {
                    Security = new NetTcpSecurity()
                    {
                        Mode = SecurityMode.None,
                        Transport = new TcpTransportSecurity() { ClientCredentialType = TcpClientCredentialType.Windows },
                        Message = new MessageSecurityOverTcp() { ClientCredentialType = MessageCredentialType.Windows }
                    },
                    MaxBufferPoolSize = int.MaxValue,
                    MaxBufferSize = int.MaxValue,
                    MaxReceivedMessageSize = int.MaxValue,
                    CloseTimeout = TimeSpan.FromMinutes(2),
                    OpenTimeout = TimeSpan.FromMinutes(2),
                    SendTimeout = TimeSpan.FromMinutes(2),
                    ReceiveTimeout = TimeSpan.FromMinutes(10),
                    ReliableSession = new OptionalReliableSession() { InactivityTimeout = TimeSpan.FromHours(8), Enabled = true, Ordered = true },
                    ReaderQuotas = new System.Xml.XmlDictionaryReaderQuotas()
                    {
                        MaxArrayLength = int.MaxValue,
                        MaxBytesPerRead = int.MaxValue,
                        MaxDepth = int.MaxValue,
                        MaxNameTableCharCount = int.MaxValue,
                        MaxStringContentLength = int.MaxValue
                    },
                    TransferMode = TransferMode.Buffered
                };
            }
        }
    }
}
