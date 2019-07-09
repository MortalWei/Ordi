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
    /// 执行脚本库
    /// </summary>
    public interface IQuery
    {
        /// <summary>
        /// 执行脚本,并返回DataSet结果集
        /// </summary>
        /// <param name="sqlStr">待执行的脚本</param>
        /// <returns></returns>
        DataSet Query(string sqlStr);

        /// <summary>
        /// 执行脚本,并返回DataSet结果集
        /// </summary>
        /// <param name="sqlStr">待执行的脚本</param>
        /// <param name="timeOut">超时时间</param>
        /// <returns></returns>
        DataSet Query(string sqlStr, int timeOut);

        /// <summary>
        /// 执行脚本,并返回DataSet结果集
        /// </summary>
        /// <param name="sqlStr">待执行的脚本</param>
        /// <param name="dbs">参数集合</param>
        /// <returns></returns>
        DataSet Query(string sqlStr, DbParameter[] dbs);

        /// <summary>
        /// 执行脚本,并返回DataSet结果集
        /// </summary>
        /// <param name="sqlStr">待执行的脚本</param>
        /// <param name="dbs">参数集合</param>
        /// <param name="timeOut">超时时间</param>
        /// <returns></returns>
        DataSet Query(string sqlStr, DbParameter[] dbs, int timeOut);

        /// <summary>
        /// 执行脚本,并返回DataSet结果集
        /// </summary>
        /// <param name="sqlStr">待执行的脚本</param>
        /// <param name="dbs">参数集合</param>
        /// <param name="commandType">脚本类型</param>
        /// <returns></returns>
        DataSet Query(string sqlStr, DbParameter[] dbs, CommandType commandType);

        /// <summary>
        /// 执行脚本,并返回DataSet结果集
        /// </summary>
        /// <param name="sqlStr">待执行的脚本</param>
        /// <param name="dbs">参数集合</param>
        /// <param name="commandType">脚本类型</param>
        /// <param name="timeOut">超时时间</param>
        /// <returns></returns>
        DataSet Query(string sqlStr, DbParameter[] dbs, CommandType commandType, int timeOut);

        /// <summary>
        /// 执行脚本,并返回IEnumerable<T>结果集
        /// </summary>
        /// <param name="sqlStr">待执行的脚本</param>
        /// <returns></returns>
        IEnumerable<T> Query<T>(string sqlStr) where T : new();

        /// <summary>
        /// 执行脚本,并返回IEnumerable<T>结果集
        /// </summary>
        /// <param name="sqlStr">待执行的脚本</param>
        /// <param name="timeOut">超时时间</param>
        /// <returns></returns>
        IEnumerable<T> Query<T>(string sqlStr, int timeOut) where T : new();

        /// <summary>
        /// 执行脚本,并返回IEnumerable<T>结果集
        /// </summary>
        /// <param name="sqlStr">待执行的脚本</param>
        /// <param name="dbs">参数集合</param>
        /// <returns></returns>
        IEnumerable<T> Query<T>(string sqlStr, DbParameter[] dbs) where T : new();

        /// <summary>
        /// 执行脚本,并返回IEnumerable<T>结果集
        /// </summary>
        /// <param name="sqlStr">待执行的脚本</param>
        /// <param name="dbs">参数集合</param>
        /// <param name="timeOut">超时时间</param>
        /// <returns></returns>
        IEnumerable<T> Query<T>(string sqlStr, DbParameter[] dbs, int timeOut) where T : new();

        /// <summary>
        /// 执行脚本,并返回IEnumerable<T>结果集
        /// </summary>
        /// <param name="sqlStr">待执行的脚本</param>
        /// <param name="dbs">参数集合</param>
        /// <param name="commandType">脚本类型</param>
        /// <returns></returns>
        IEnumerable<T> Query<T>(string sqlStr, DbParameter[] dbs, CommandType commandType) where T : new();

        /// <summary>
        /// 执行脚本,并返回IEnumerable<T>结果集
        /// </summary>
        /// <param name="sqlStr">待执行的脚本</param>
        /// <param name="dbs">参数集合</param>
        /// <param name="commandType">脚本类型</param>
        /// <param name="timeOut">超时时间</param>
        /// <returns></returns>
        IEnumerable<T> Query<T>(string sqlStr, DbParameter[] dbs, CommandType commandType, int timeOut) where T : new();
    }
}
