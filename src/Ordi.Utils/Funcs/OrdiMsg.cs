using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ordi.Utils.Funcs
{
    public sealed class OrdiMsg
    {
        /// <summary>
        /// 消息框拥有者句柄
        /// </summary>
        public static IWin32Window Handle { get; private set; }

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
