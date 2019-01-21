using Ordi.Enums;
using System;

namespace Ordi.Browser.BrowserHandlers
{
    public class BrowserEventArgs : EventArgs
    {
        public BrowserEventArgs()
        {
            State = OrdiEventState.Waiting;
        }

        public BrowserEventArgs(string args1) : this()
        {
            Parameter1 = args1;
        }

        public BrowserEventArgs(string args1, string args2) : this(args1)
        {
            Parameter2 = args2;
        }

        public BrowserEventArgs(string args1, string args2, string args3) : this(args1, args2)
        {
            Parameter3 = args3;
        }

        /// <summary>
        /// JS调用.NET方法默认参数1
        /// </summary>
        public string Parameter1 { get; set; }
        /// <summary>
        /// JS调用.NET方法默认参数1
        /// </summary>
        public string Parameter2 { get; set; }
        /// <summary>
        /// JS调用.NET方法默认参数1
        /// </summary>
        public string Parameter3 { get; set; }
        /// <summary>
        /// JS调用.NET方法状态
        /// </summary>
        public OrdiEventState State { get; set; }
        /// <summary>
        /// .NET返回值
        /// </summary>
        public string Result { get; set; }
    }
}
