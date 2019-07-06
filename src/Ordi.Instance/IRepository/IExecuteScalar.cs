using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordi
{
    /// <summary>
    /// 脚本执行库
    /// </summary>
    internal interface IExecuteScalar
    {
        /// <summary>
        /// 执行查询,并返回结果集中第一行第一列的值
        /// </summary>
        /// <param name="sqlStr">待执行的脚本</param>
        /// <returns></returns>
        object ExecuteScalar(string sqlStr);

        /// <summary>
        /// 执行查询,并返回结果集中第一行第一列的值
        /// </summary>
        /// <param name="sqlStr">待执行的脚本</param>
        /// <param name="timeOut">超时时间</param>
        /// <returns></returns>
        object ExecuteScalar(string sqlStr, int timeOut);

        /// <summary>
        /// 执行查询,并返回结果集中第一行第一列的值
        /// </summary>
        /// <param name="sqlStr">待执行的脚本</param>
        /// <param name="dbs">参数集合</param>
        /// <returns></returns>
        object ExecuteScalar(string sqlStr, DbParameter[] dbs);

        /// <summary>
        /// 执行查询,并返回结果集中第一行第一列的值
        /// </summary>
        /// <param name="sqlStr">待执行的脚本</param>
        /// <param name="dbs">参数集合</param>
        /// <param name="timeOut">超时时间</param>
        /// <returns></returns>
        object ExecuteScalar(string sqlStr, DbParameter[] dbs, int timeOut);

        /// <summary>
        /// 执行查询,并返回结果集中第一行第一列的值
        /// </summary>
        /// <param name="sqlStr">待执行的脚本</param>
        /// <param name="dbs">参数集合</param>
        /// <param name="commandType">脚本类型</param>
        /// <returns></returns>
        object ExecuteScalar(string sqlStr, DbParameter[] dbs, CommandType commandType);

        /// <summary>
        /// 执行查询,并返回结果集中第一行第一列的值
        /// </summary>
        /// <param name="sqlStr">待执行的脚本</param>
        /// <param name="dbs">参数集合</param>
        /// <param name="commandType">脚本类型</param>
        /// <param name="timeOut">超时时间</param>
        /// <returns></returns>
        object ExecuteScalar(string sqlStr, DbParameter[] dbs, CommandType commandType, int timeOut);
    }
}
