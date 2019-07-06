using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Text;
using Dapper;

namespace Ordi
{
    public class OracleInstance : IDBInstance
    {
        private readonly string DbName;
        private readonly string ConnStr;

        public OracleInstance(string dbName = "Ordi")
        {
            DbName = dbName;
            var Conns = ConfigurationManager.ConnectionStrings[DbName];
            ConnStr = Conns.ConnectionString;
        }

        #region Execute
        public int Execute(string sqlStr)
        {
            return Execute(sqlStr, null, CommandType.Text, 0);
        }

        public int Execute(string sqlStr, int timeOut)
        {
            return Execute(sqlStr, null, CommandType.Text, 0);
        }

        public int Execute(string sqlStr, DbParameter[] dbs)
        {
            return Execute(sqlStr, dbs, CommandType.Text, 0);
        }

        public int Execute(string sqlStr, DbParameter[] dbs, int timeOut)
        {
            return Execute(sqlStr, dbs, CommandType.Text, 0);
        }

        public int Execute(string sqlStr, DbParameter[] dbs, CommandType commandType)
        {
            return Execute(sqlStr, dbs, commandType, 0);
        }

        public int Execute(string sqlStr, DbParameter[] dbs, CommandType commandType, int timeOut)
        {
            var result = -1;
            try
            {
                using (var conn = new OracleConnection(ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        var cmd = conn.CreateCommand();
                        cmd.CommandType = commandType;
                        cmd.CommandText = sqlStr;
                        cmd.CommandTimeout = timeOut;
                        if (dbs != null)
                        {
                            cmd.Parameters.AddRange(dbs);
                            cmd.BindByName = true;
                            cmd.Prepare();
                        }
                        try
                        {
                            result = cmd.ExecuteNonQuery();
                            tran.Commit();
                            return result;
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            throw ex;
                        }
                        finally
                        {
                            conn.Close();
                            cmd.Dispose();
                            tran.Dispose();
                            conn.Dispose();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logs.Error(ex.Message, ex);
                return result;
            }
        }
        #endregion Execute

        #region ExecuteScalar
        public object ExecuteScalar(string sqlStr)
        {
            return ExecuteScalar(sqlStr, null, CommandType.Text, 0);
        }

        public object ExecuteScalar(string sqlStr, int timeOut)
        {
            return ExecuteScalar(sqlStr, null, CommandType.Text, timeOut);
        }

        public object ExecuteScalar(string sqlStr, DbParameter[] dbs)
        {
            return ExecuteScalar(sqlStr, dbs, CommandType.Text, 0);
        }

        public object ExecuteScalar(string sqlStr, DbParameter[] dbs, int timeOut)
        {
            return ExecuteScalar(sqlStr, dbs, CommandType.Text, timeOut);
        }

        public object ExecuteScalar(string sqlStr, DbParameter[] dbs, CommandType commandType)
        {
            return ExecuteScalar(sqlStr, dbs, commandType, 0);
        }

        public object ExecuteScalar(string sqlStr, DbParameter[] dbs, CommandType commandType, int timeOut)
        {
            try
            {
                using (var conn = new OracleConnection(ConnStr))
                {
                    conn.Open();
                    var cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sqlStr;
                    if (dbs != null)
                    {
                        cmd.Parameters.AddRange(dbs);
                        cmd.BindByName = true;
                        cmd.Prepare();
                    }
                    try
                    {
                        return cmd.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        conn.Close();
                        cmd.Dispose();
                        conn.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                Logs.Error(ex.Message, ex);
                return null;
            }
        }
        #endregion ExecuteScalar

        #region Query

        public DataSet Query(string sqlStr)
        {
            return Query(sqlStr, null, CommandType.Text, 0);
        }

        public DataSet Query(string sqlStr, int timeOut)
        {
            return Query(sqlStr, null, CommandType.Text, timeOut);
        }

        public DataSet Query(string sqlStr, DbParameter[] dbs)
        {
            return Query(sqlStr, dbs, CommandType.Text, 0);
        }

        public DataSet Query(string sqlStr, DbParameter[] dbs, int timeOut)
        {
            return Query(sqlStr, dbs, CommandType.Text, timeOut);
        }

        public DataSet Query(string sqlStr, DbParameter[] dbs, CommandType commandType)
        {
            return Query(sqlStr, dbs, commandType, 0);
        }

        public DataSet Query(string sqlStr, DbParameter[] dbs, CommandType commandType, int timeOut)
        {
            try
            {
                using (var conn = new OracleConnection(ConnStr))
                {
                    conn.Open();
                    var cmd = conn.CreateCommand();
                    cmd.CommandType = commandType;
                    cmd.CommandText = sqlStr;
                    cmd.CommandTimeout = timeOut;
                    if (dbs != null)
                    {
                        cmd.Parameters.AddRange(dbs);
                        cmd.BindByName = true;
                        cmd.Prepare();
                    }

                    cmd.ExecuteReader(CommandBehavior.SequentialAccess | CommandBehavior.SingleResult)
                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);

                    DataSet result = new DataSet();
                    adapter.Fill(result);
                    return result;
                }
            }
            catch (Exception ex)
            {
                Logs.Error(ex.Message, ex);
                return null;
            }
        }

        public IEnumerable<T> Query<T>(string sqlStr)
        {
            return Query<T>(sqlStr, null, CommandType.Text, 0);
        }

        public IEnumerable<T> Query<T>(string sqlStr, int timeOut)
        {
            return Query<T>(sqlStr, null, CommandType.Text, timeOut);
        }

        public IEnumerable<T> Query<T>(string sqlStr, DbParameter[] dbs)
        {
            return Query<T>(sqlStr, dbs, CommandType.Text, 0);
        }

        public IEnumerable<T> Query<T>(string sqlStr, DbParameter[] dbs, int timeOut)
        {
            return Query<T>(sqlStr, dbs, CommandType.Text, timeOut);
        }

        public IEnumerable<T> Query<T>(string sqlStr, DbParameter[] dbs, CommandType commandType)
        {
            return Query<T>(sqlStr, dbs, commandType, 0);
        }

        public IEnumerable<T> Query<T>(string sqlStr, DbParameter[] dbs, CommandType commandType, int timeOut)
        {
            throw new NotImplementedException();
        }
        #endregion Query
    }
}
