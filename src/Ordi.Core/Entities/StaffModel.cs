using Ordi.Attributes;
using Ordi.Enums;
using System;
using System.Runtime.Serialization;

namespace Ordi.Entities
{
    /// <summary>
    /// 操作员信息
    /// </summary>
    [DataContract]
    [Serializable]
    public sealed class StaffModel
    {
        /// <summary>
        /// 唯一标识
        /// </summary>
        [DataField("EMPID", DisplayName = "唯一标识", Description = "员工唯一标识")]
        [DataMember]
        public string Id { get; set; }

        /// <summary>
        /// 员工工号
        /// </summary>
        [DataField("EMPNO", DisplayName = "工号", Description = "工号")]
        [DataMember]
        public string Number { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        [DataField("ENAME", DisplayName = "姓名", Description = "姓名")]
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [DataField("SEX", DisplayName = "性别", Description = "性别")]
        [DataMember]
        public SexCode Sex { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [DataField("PHONE", DisplayName = "电话", Description = "电话")]
        [DataMember]
        public string Phone { get; set; }

        /// <summary>
        /// 电子邮件
        /// </summary>
        [DataField("EMAIL", DisplayName = "电子邮件", Description = "电子邮件")]
        [DataMember]
        public string Email { get; set; }

        /// <summary>
        /// 入职时间
        /// </summary>
        [DataField("HIREDATA", DisplayName = "入职时间", Description = "入职时间")]
        [DataMember]
        public DateTime HireDate { get; set; }

        /// <summary>
        /// 部门编号
        /// </summary>
        [DataField("DEPTID", DisplayName = "部门编号", Description = "部门编号")]
        [DataMember]
        public string DeptId { get; set; }

        /// <summary>
        /// 口令
        /// </summary>
        [DataField("PWD", DisplayName = "口令", Description = "口令")]
        [DataMember]
        public string PWD { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [DataField("STATE", DisplayName = "状态", Description = "状态 0.无效 1.有效")]
        [DataMember]
        public KeyState State { get; set; }
    }
}
