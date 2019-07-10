using Ordi.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ordi.App.Test.Utils
{
    /// <summary>
    /// 患者住院信息
    /// </summary>
    [Serializable]
    [DataContract]
    public class PatientInfo
    {
        ///// <summary>
        ///// 患者就诊种类
        ///// </summary>
        //[DataField("PATIENT_CATEGORY")]
        //[Display(Name = "PatientCategory", Description = "患者就诊种类")]
        //[DataMember]
        //public EnumVisCategory PatientCategory { get; set; }
        /// <summary>
        /// 患者唯一标识
        /// </summary>
        [DataField("PATIENT_ID")]
        [Display(Name = "PatientId", Description = "患者唯一标识")]
        [DataMember]
        public string PatientId { get; set; }
        /// <summary>
        /// 门诊就诊标识
        /// </summary>
        [DataField("OP_ID")]
        [Display(Name = "OpCureId", Description = "门诊就诊标识")]
        [DataMember]
        public string OpCureId { get; set; }
        /// <summary>
        /// 住院就诊标识
        /// </summary>
        [DataField("IP_ID")]
        [Display(Name = "IpId", Description = "住院就诊标识")]
        [DataMember]
        public string IpId { get; set; }
        /// <summary>
        /// 母亲唯一标识
        /// </summary>
        [DataField("MOTHER_ID")]
        [Display(Name = "MotherId", Description = "母亲唯一标识")]
        [DataMember]
        public string MotherId { get; set; }
        /// <summary>
        /// 婴儿出生序号
        /// </summary>
        [DataField("BABY_SORT")]
        [Display(Name = "BabySort", Description = "婴儿出生序号")]
        [DataMember]
        public int? BabySort { get; set; }
        /// <summary>
        /// 病案标识
        /// </summary>
        [DataField("IP_FILES_ID")]
        [Display(Name = "IpFilesId", Description = "病案标识")]
        [DataMember]
        public string IpFilesId { get; set; }
        /// <summary>
        /// 住院次数
        /// </summary>
        [DataField("IP_COUNT")]
        [Display(Name = "IpCount", Description = "住院次数")]
        [DataMember]
        public int IpCount { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [DataField("NAME")]
        [Display(Name = "Name", Description = "姓名")]
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// 性别0.未知 1.男 2.女 5.男,女变性为男 6.女,男变性为女 9.未说明
        /// </summary>
        [DataField("SEX")]
        [Display(Name = "Sex", Description = "性别")]
        [DataMember]
        public EnumSex Sex { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        [DataField("BIRTHDAY")]
        [Display(Name = "Birthday", Description = "出生日期")]
        [DataMember]
        public DateTime Birthday { get; set; }
        /// <summary>
        /// 入院年龄
        /// </summary>
        [DataField("IP_AGE")]
        [Display(Name = "IpAge", Description = "入院年龄")]
        [DataMember]
        public string IpAge { get; set; }
        /// <summary>
        /// 记账代码
        /// </summary>
        [DataField("ACCOUNT_CODE")]
        [Display(Name = "AccountCode", Description = "记账代码")]
        [DataMember]
        public string AccountCode { get; set; }
        /// <summary>
        /// 记账名称
        /// </summary>
        [DataField("ACCOUNT_NAME")]
        [Display(Name = "AccountName", Description = "记账名称")]
        [DataMember]
        public string AccountName { get; set; }
        /// <summary>
        /// 医保代码
        /// </summary>
        [DataField("MEDICARE_TYPE")]
        [Display(Name = "MedicareType", Description = "医保代码")]
        [DataMember]
        public string MedicareType { get; set; }
        /// <summary>
        /// 医保名称
        /// </summary>
        [DataField("MEDICARE_NAME")]
        [Display(Name = "MedicareName", Description = "医保名称")]
        [DataMember]
        public string MedicareName { get; set; }
        /// <summary>
        /// 输入码1
        /// </summary>
        [DataField("INPUT_CODE1")]
        [Display(Name = "InputCode1", Description = "输入码1")]
        [DataMember]
        public string InputCode1 { get; set; }
        /// <summary>
        /// 输入码2
        /// </summary>
        [DataField("INPUT_CODE2")]
        [Display(Name = "InputCode2", Description = "输入码2")]
        [DataMember]
        public string InputCode2 { get; set; }
        ///// <summary>
        ///// 入院方式 1.急诊 2.门诊 3.其他医疗机构转入 9.其他
        ///// </summary>
        //[DataField("ENTRY_TYPE")]
        //[Display(Name = "EntryType", Description = "入院方式")]
        //[DataMember]
        //public EnumEntryWay EntryType { get; set; }
        /// <summary>
        /// 门诊医生
        /// </summary>
        [DataField("OP_DOCTOR_ID")]
        [Display(Name = "OPDoctorId", Description = "门诊医生")]
        [DataMember]
        public string OPDoctorId { get; set; }
        /// <summary>
        /// 门诊诊断编码
        /// </summary>
        [DataField("OP_DIAG_ID")]
        [Display(Name = "OPDiagId", Description = "门诊诊断编码")]
        [DataMember]
        public string OPDiagId { get; set; }
        /// <summary>
        /// 门诊诊断名称
        /// </summary>
        [DataField("OP_DIAG_NAME")]
        [Display(Name = "OPDiagName", Description = "门诊诊断名称")]
        [DataMember]
        public string OPDiagName { get; set; }
        /// <summary>
        /// 入院日期
        /// </summary>
        [DataField("ENTRY_DATE")]
        [Display(Name = "EntryDate", Description = "入院日期")]
        [DataMember]
        public DateTime? EntryDate { get; set; }
        /// <summary>
        /// 入院科室
        /// </summary>
        [DataField("ENTRY_DEPT_ID")]
        [Display(Name = "EntryDeptId", Description = "入院科室")]
        [DataMember]
        public string EntryDeptId { get; set; }
        /// <summary>
        /// 入院科室名称
        /// </summary>
        [DataField("ENTRY_DEPT_NAME")]
        [Display(Name = "EntryDeptName", Description = "入院科室名称")]
        [DataMember]
        public string EntryDeptName { get; set; }
        /// <summary>
        /// 入院病区
        /// </summary>
        [DataField("ENTRY_WARD_ID")]
        [Display(Name = "EntryWardId", Description = "入院病区")]
        [DataMember]
        public string EntryWardId { get; set; }
        /// <summary>
        /// 入院病区名称
        /// </summary>
        [DataField("ENTRY_WARD_NAME")]
        [Display(Name = "EntryWardName", Description = "入院病区名称")]
        [DataMember]
        public string EntryWardName { get; set; }
        /// <summary>
        /// 入院房间标识
        /// </summary>
        [DataField("ENTRY_ROOM_ID")]
        [Display(Name = "EntryRoomId", Description = "入院房间标识")]
        [DataMember]
        public string EntryRoomId { get; set; }
        /// <summary>
        /// 入院房间号
        /// </summary>
        [DataField("ENTRY_ROOM_NUMBER")]
        [Display(Name = "EntryRoomNumber", Description = "入院房间号")]
        [DataMember]
        public string EntryRoomNumber { get; set; }
        /// <summary>
        /// 入院床位标识
        /// </summary>
        [DataField("ENTRY_BED_ID")]
        [Display(Name = "EntryBedId", Description = "入院床位标识")]
        [DataMember]
        public string EntryBedId { get; set; }
        /// <summary>
        /// 入院床位号
        /// </summary>
        [DataField("ENTRY_BED_NUMBER")]
        [Display(Name = "EntryBedNumber", Description = "入院床位号")]
        [DataMember]
        public string EntryBedNumber { get; set; }
        /// <summary>
        /// 入院诊断编码该入院诊断为入院单或入院申请单中的诊断，不作为临床诊断管理
        /// </summary>
        [DataField("ENTRY_DIAG_ID")]
        [Display(Name = "EntryDiagId", Description = "入院诊断编码该入院诊断为入院单或入院申请单中的诊断，不作为临床诊断管理")]
        [DataMember]
        public string EntryDiagId { get; set; }
        /// <summary>
        /// 入院诊断名称
        /// </summary>
        [DataField("ENTRY_DIAG_NAME")]
        [Display(Name = "EntryDiagName", Description = "入院诊断名称")]
        [DataMember]
        public string EntryDiagName { get; set; }
        ///// <summary>
        ///// 入院病情标识 0.未指定 1.危急、病危 2.严重、病种 3.一般、普通 4.不适用 9.其他
        ///// </summary>
        //[DataField("ENTRY_ILLNESS")]
        //[Display(Name = "EntryIllness", Description = "入院病情标识0.未指定 1.危急、病危 2.严重、病种 3.一般、普通 4.不适用 9.其他")]
        //[DataMember]
        //public EnumIllnessStatus EntryIllness { get; set; }
        ///// <summary>
        ///// 封账标识0.否 1.是
        ///// </summary>
        //[DataField("SEALING_STATUS")]
        //[Display(Name = "DealingStatus", Description = "封账标识0.否 1.是")]
        //[DataMember]
        //public EnumKey DealingStatus { get; set; }
        /// <summary>
        /// 房间标识
        /// </summary>
        [DataField("ROOM_ID")]
        [Display(Name = "RoomId", Description = "房间标识")]
        [DataMember]
        public string RoomId { get; set; }
        /// <summary>
        /// 房间号
        /// </summary>
        [DataField("ROOM_NUMBER")]
        [Display(Name = "RoomNumber", Description = "房间号")]
        [DataMember]
        public string RoomNumber { get; set; }
        /// <summary>
        /// 床位标识
        /// </summary>
        [DataField("BED_ID")]
        [Display(Name = "BedId", Description = "床位标识")]
        [DataMember]
        public string BedId { get; set; }
        /// <summary>
        /// 床位号
        /// </summary>
        [DataField("BED_NUMBER")]
        [Display(Name = "BedNumber", Description = "床位号")]
        [DataMember]
        public string BedNumber { get; set; }
        /// <summary>
        /// 床位序号
        /// </summary>
        [DataField("BED_SORT")]
        [Display(Name = "BedSort", Description = "床位序号")]
        [DataMember]
        public int BedSort { get; set; }
        /// <summary>
        /// 所属科室
        /// </summary>
        [DataField("DEPT_ID")]
        [Display(Name = "DeptId", Description = "所属科室")]
        [DataMember]
        public string DeptId { get; set; }
        /// <summary>
        /// 所属科室名称
        /// </summary>
        [DataField("DEPT_NAME")]
        [Display(Name = "DeptName", Description = "所属科室名称")]
        [DataMember]
        public string DeptName { get; set; }
        /// <summary>
        /// 所属病区
        /// </summary>
        [DataField("WARD_ID")]
        [Display(Name = "WardId", Description = "所属病区")]
        [DataMember]
        public string WardId { get; set; }
        /// <summary>
        /// 所属病区名称
        /// </summary>
        [DataField("WARD_NAME")]
        [Display(Name = "WardName", Description = "所属病区名称")]
        [DataMember]
        public string WardName { get; set; }
        /// <summary>
        /// 床位医师
        /// </summary>
        [DataField("BED_DOC_ID")]
        [Display(Name = "BedDocId", Description = "床位医师")]
        [DataMember]
        public string BedDocId { get; set; }
        /// <summary>
        /// 床位医师姓名
        /// </summary>
        [DataField("BED_DOC_NAME")]
        [Display(Name = "BedDocName", Description = "床位医师姓名")]
        [DataMember]
        public string BedDocName { get; set; }
        /// <summary>
        /// 主治医师
        /// </summary>
        [DataField("ATTENDING_DOC_ID")]
        [Display(Name = "AttendingDocId", Description = "主治医师")]
        [DataMember]
        public string AttendingDocId { get; set; }
        /// <summary>
        /// 主治医师姓名
        /// </summary>
        [DataField("ATTENDING_DOC_NAME")]
        [Display(Name = "AttendingDocName", Description = "主治医师姓名")]
        [DataMember]
        public string AttendingDocName { get; set; }
        /// <summary>
        /// 床位护士
        /// </summary>
        [DataField("BED_NURSE_ID")]
        [Display(Name = "BedNurseId", Description = "床位护士")]
        [DataMember]
        public string BedNurseId { get; set; }
        /// <summary>
        /// 床位护士姓名
        /// </summary>
        [DataField("BED_NURSE_NAME")]
        [Display(Name = "BedNurseName", Description = "床位护士姓名")]
        [DataMember]
        public string BedNurseName { get; set; }
        /// <summary>
        /// 责任护士
        /// </summary>
        [DataField("PRIMARY_NURSE_ID")]
        [Display(Name = "PrimaryNurseId", Description = "责任护士")]
        [DataMember]
        public string PrimaryNurseId { get; set; }
        /// <summary>
        /// 责任护士姓名
        /// </summary>
        [DataField("PRIMARY_NURSE_NAME")]
        [Display(Name = "PrimaryNurseName", Description = "责任护士姓名")]
        [DataMember]
        public string PrimaryNurseName { get; set; }

        /// <summary>
        /// 医疗组标识
        /// </summary>
        [DataField("MEDGP_ID")]
        [Display(Name = "MEDGPId", Description = "医疗组标识")]
        [DataMember]
        public string MEDGPId { get; set; }

        /// <summary>
        /// 患者当前第一诊断主要诊断编码
        /// </summary>
        [DataField("DIAG_ID")]
        [Display(Name = "DiagId", Description = "患者当前第一诊断主要诊断编码")]
        [DataMember]
        public string DiagId { get; set; }

        /// <summary>
        /// 患者当前第一诊断主要诊断名称
        /// </summary>
        [DataField("DIAG_NAME")]
        [Display(Name = "DiagName", Description = "患者当前第一诊断主要诊断名称")]
        [DataMember]
        public string DiagName { get; set; }

        /// <summary>
        /// 饮食类型
        /// </summary>
        [DataField("DIET_TYPE")]
        [Display(Name = "DietType", Description = "饮食类型")]
        [DataMember]
        public string DietType { get; set; }

        /// <summary>
        /// 饮食类型名称
        /// </summary>
        [DataField("DIET_TYPE_NAME")]
        [Display(Name = "DietTypeName", Description = "饮食类型名称")]
        [DataMember]
        public string DietTypeName { get; set; }

        /// <summary>
        /// 出院日期
        /// </summary>
        [DataField("EXIT_DATE")]
        [Display(Name = "ExitDate", Description = "出院日期")]
        [DataMember]
        public DateTime? ExitDate { get; set; }

        /// <summary>
        /// 出院诊断编码
        /// </summary>
        [DataField("EXIT_DIAG_ID")]
        [Display(Name = "ExitDiagId", Description = "出院诊断编码")]
        [DataMember]
        public string ExitDiagId { get; set; }
        
        /// <summary>
        /// 出院诊断名称
        /// </summary>
        [DataField("EXIT_DIAG_NAME")]
        [Display(Name = "ExitDiagName", Description = "出院诊断名称")]
        [DataMember]
        public string ExitDiagName { get; set; }

        /// <summary>
        /// 转归情况
        /// </summary>
        [DataField("EXID_SITUATION")]
        [Display(Name = "ExitSituation", Description = "转归情况")]
        [DataMember]
        public string ExitSituation { get; set; }
    }

    /// <summary>
    /// 性别代码
    /// 参考《GB/T 2261.1》
    /// </summary>
    public enum EnumSex
    {
        /// <summary>
        /// 未知的性别
        /// </summary>
        [Description("未知")]
        Unknown = 0,
        /// <summary>
        /// 男
        /// </summary>
        [Description("男")]
        Man = 1,
        /// <summary>
        /// 女
        /// </summary>
        [Description("女")]
        Woman = 2,
        /// <summary>
        /// 男,由女性变性成男
        /// </summary>
        [Description("男")]
        AlterMan = 5,
        /// <summary>
        /// 女,由男性变性成女
        /// </summary>
        [Description("女")]
        AlterWoman = 6,
        /// <summary>
        /// 未说明的性别
        /// </summary>
        [Description("未说明")]
        Unexplained = 9
    }
}
