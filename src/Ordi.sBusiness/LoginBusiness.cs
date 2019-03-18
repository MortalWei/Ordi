using Ordi.Entities;
using Ordi.IBusiness;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordi.sBusiness
{
    public class LoginBusiness : ILoginBusiness
    {
        static IDBInstance Instance;

        public LoginBusiness()
        {
            Instance = new OracleInstance();
        }

        /// <summary>
        /// 获取员工信息
        /// </summary>
        /// <param name="empno"></param>
        /// <returns></returns>
        public DataSet GetStaff(string empno)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(string));
            table.Columns.Add("Name", typeof(string));

            for (int i = 1; i < 10; i++)
            {
                table.Rows.Add();
                table.Rows[i - 1]["Id"] = i.ToString();
                table.Rows[i - 1]["Name"] = "Name" + i.ToString();
            }

            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(table);


            var ss = Instance.Query("SELECT 1 FROM DUAL");
            return dataSet;
            //return Instance.Query("SELECT * FROM ");
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public bool Login(StaffModel staff)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 登出
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public bool Logout(StaffModel staff)
        {
            throw new NotImplementedException();
        }
    }
}
