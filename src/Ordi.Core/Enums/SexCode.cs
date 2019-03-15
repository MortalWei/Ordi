using Ordi.Attributes;

namespace Ordi.Enums
{
    /// <summary>
    /// 性别代码 参考《GB/T 2261.1》
    /// </summary>
    public enum SexCode
    {
        /// <summary>
        /// 未知的性别
        /// </summary>
        [DataEnum(ShowName = "未知", Description = "未知的性别")]
        Unknown = 0,
        /// <summary>
        /// 男
        /// </summary>
        [DataEnum(ShowName = "男", Description = "男性")]
        Man = 1,
        /// <summary>
        /// 女
        /// </summary>
        [DataEnum(ShowName = "女", Description = "女性")]
        Woman = 2,
        ///
        /// 男,由女性变性成男
        /// </summary>
        [DataEnum(ShowName = "男", Description = "男,由女性变性成男")]
        AlterMan = 5,
        ///
        /// 女,由男性变性成女
        /// </summary>
        [DataEnum(ShowName = "女", Description = "女,由男性变性成女")]
        AlterWoman = 6,
        /// <summary>
        /// 未说明的性别
        /// </summary>
        [DataEnum(ShowName = "未说明", Description = "未说明的性别")]
        Unexplained = 9
    }
}
