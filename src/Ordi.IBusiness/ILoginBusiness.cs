using Ordi.Entities;
using System.Data;
using System.ServiceModel;

namespace Ordi.IBusiness
{
    /// <summary>
    /// 登录服务契约
    /// </summary>
    [ServiceContract]
    public interface ILoginBusiness
    {
        /// <summary>
        /// 获取员工信息
        /// </summary>
        /// <param name="empno"></param>
        /// <returns></returns>
        [OperationContract]
        DataSet GetStaff(string empno);

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        [OperationContract]
        bool Login(StaffModel staff);

        /// <summary>
        /// 登出
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        [OperationContract]
        bool Logout(StaffModel staff);
    }
}
