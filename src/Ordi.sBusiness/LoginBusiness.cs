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
            return Instance.Query("SELECT * FROM ");
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
