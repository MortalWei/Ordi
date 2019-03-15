using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace Ordi
{
    /// <summary>
    /// DB访问实例
    /// </summary>
    public interface IDBInstance
    {
        #region ExecuteScalar:返回首行首列值
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns></returns>
        object ExecuteScalar(string sqlStr);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <param name="dbs"></param>
        /// <returns></returns>
        object ExecuteScalar(string sqlStr, DbParameter[] dbs);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <param name="dbs"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        object ExecuteScalar(string sqlStr, DbParameter[] dbs, CommandType type);
        #endregion

        #region Exists:验证数据是否存在
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        bool Exists(string sqlStr, StringBuilder builder = null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <param name="dbs"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        bool Exists(string sqlStr, DbParameter[] dbs, StringBuilder builder = null);
        #endregion

        #region Query:数据查询
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns></returns>
        DataSet Query(string sqlStr);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <param name="dbs"></param>
        /// <param name="type"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        DataSet Query(string sqlStr, DbParameter[] dbs, int timeOut = 0);
        #endregion

        #region Execute:增删改操作
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns></returns>
        int Execute(string sqlStr);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <param name="dbs"></param>
        /// <returns></returns>
        int Execute(string sqlStr, DbParameter[] dbs);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqllist"></param>
        /// <returns></returns>
        int Execute(List<string> sqllist);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tuples"></param>
        /// <returns></returns>
        int Execute(List<Tuple<string, DbParameter[]>> tuples);
        #endregion

        #region Procedure:存储过程执行
        DataSet ExceuteProc(string sqlStr);
        DataSet ExceuteProc(string sqlStr, DbParameter[] dbs);
        #endregion
    }
}
