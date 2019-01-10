using System.ComponentModel;

namespace Ordi.Enums
{
    /// <summary>
    /// 通用状态枚举
    /// </summary>
    public enum KeyState
    {
        /// <summary>
        /// 无效
        /// </summary>
        [Description("无效")]
        Invalid = 0,
        /// <summary>
        /// 有效
        /// </summary>
        [Description("有效")]
        Valid = 1,
        /// <summary>
        /// 新增
        /// 建议仅用于逻辑验证
        /// </summary>
        [Description("新增")]
        Newly = 8,
        /// <summary>
        /// 删除的
        /// 建议仅用于逻辑验证
        /// </summary>
        [Description("删除")]
        Deleted = 9
    }
}
