using System.Data;
using System.Data.Common;

namespace Ordi
{
    /// <summary>
    /// 执行脚本库
    /// </summary>
    internal interface IExecute
    {
        /// <summary>
        /// 执行脚本,并返回受影响行数
        /// </summary>
        /// <param name="sqlStr">待执行的脚本</param>
        /// <returns>-1:表示失败</returns>
        int Execute(string sqlStr);

        /// <summary>
        /// 执行脚本,并返回受影响行数
        /// </summary>
        /// <param name="sqlStr">待执行的脚本</param>
        /// <param name="timeOut">超时时间</param>
        /// <returns>-1:表示失败</returns>
        int Execute(string sqlStr, int timeOut);

        /// <summary>
        /// 执行脚本,并返回受影响行数
        /// </summary>
        /// <param name="sqlStr">待执行的脚本</param>
        /// <param name="dbs">参数集合</param>
        /// <returns>-1:表示失败</returns>
        int Execute(string sqlStr, DbParameter[] dbs);

        /// <summary>
        /// 执行脚本,并返回受影响行数
        /// </summary>
        /// <param name="sqlStr">待执行的脚本</param>
        /// <param name="dbs">参数集合</param>
        /// <param name="timeOut">超时时间</param>
        /// <returns>-1:表示失败</returns>
        int Execute(string sqlStr, DbParameter[] dbs, int timeOut);

        /// <summary>
        /// 执行脚本,并返回受影响行数
        /// </summary>
        /// <param name="sqlStr">待执行的脚本</param>
        /// <param name="dbs">参数集合</param>
        /// <param name="commandType">脚本类型</param>
        /// <returns>-1:表示失败</returns>
        int Execute(string sqlStr, DbParameter[] dbs, CommandType commandType);

        /// <summary>
        /// 执行脚本,并返回受影响行数
        /// </summary>
        /// <param name="sqlStr">待执行的脚本</param>
        /// <param name="dbs">参数集合</param>
        /// <param name="commandType">脚本类型</param>
        /// <param name="timeOut">超时时间</param>
        /// <returns>-1:表示失败</returns>
        int Execute(string sqlStr, DbParameter[] dbs, CommandType commandType, int timeOut);
    }
}
