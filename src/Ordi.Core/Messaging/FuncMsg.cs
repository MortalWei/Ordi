using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ordi.Messaging
{
    /// <summary>
    /// 消息提醒
    /// a.气泡式消息提醒框
    /// b.对话式消息提醒框
    /// </summary>
    public class FuncMsg
    {
        /// <summary>
        /// 消息框拥有者句柄
        /// </summary>
        public static IWin32Window Handle { get; protected set; }

        public void ShowMsg()
        {

        }

        /// <summary>
        /// 设置消息框拥有者句柄
        /// </summary>
        /// <param name="handle"></param>
        public static void SetHandle(IWin32Window handle)
        {
            Handle = handle;
        }
    }
}
