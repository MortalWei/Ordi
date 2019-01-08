using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ordi.Status
{
    public enum OrdiEventState
    {
        /// <summary>
        /// 等待=0
        /// </summary>
        Waiting = 0,
        /// <summary>
        /// 成功=1
        /// </summary>
        Succeed = 1,
        /// <summary>
        /// 失败=2
        /// </summary>
        Failure = 2,
        /// <summary>
        /// 警告=3
        /// </summary>
        Warning = 3,
        /// <summary>
        /// 取消=4
        /// </summary>
        Cancel = 4,
        /// <summary>
        /// 异常=5
        /// </summary>
        Exception = 5,
        /// <summary>
        /// 无效=7
        /// </summary>
        Invalid = 6
    }
}
