using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Text;

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

        public DataSet ExceuteProc(string sqlStr)
        {
            throw new NotImplementedException();
        }

        public DataSet ExceuteProc(string sqlStr, DbParameter[] dbs)
        {
            throw new NotImplementedException();
        }

        public int Execute(string sqlStr)
        {
            return Execute(sqlStr, null);
        }

        public int Execute(string sqlStr, DbParameter[] dbs)
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
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sqlStr;
                        if (dbs != null)
                        {
                            cmd.Parameters.AddRange(dbs);
                            cmd.BindByName = true;
                        }
                        try
                        {
                            result = cmd.ExecuteNonQuery();
                            tran.Commit();
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
            }
            return result;
        }

        public int Execute(List<string> sqllist)
        {
            throw new NotImplementedException();
        }

        public int Execute(List<Tuple<string, DbParameter[]>> tuples)
        {
            throw new NotImplementedException();
        }

        public object ExecuteScalar(string sqlStr)
        {
            throw new NotImplementedException();
        }

        public object ExecuteScalar(string sqlStr, DbParameter[] dbs)
        {
            throw new NotImplementedException();
        }

        public object ExecuteScalar(string sqlStr, DbParameter[] dbs, CommandType type)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string sqlStr, StringBuilder builder = null)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string sqlStr, DbParameter[] dbs, StringBuilder builder = null)
        {
            throw new NotImplementedException();
        }

        public DataSet Query(string sqlStr)
        {
            return Query(sqlStr, null);
        }

        public DataSet Query(string sqlStr, DbParameter[] dbs, int timeOut = 0)
        {
            DataSet result = new DataSet();
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
                    }
                    if (timeOut > 0)
                    {
                        cmd.CommandTimeout = timeOut;
                    }
                    try
                    {
                        OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                        adapter.Fill(result);
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
            }

            return result;
        }
    }
}
