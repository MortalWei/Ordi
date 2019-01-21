using System.ComponentModel;

namespace Ordi.Enums
{
    /// <summary>
    /// 菜单状态
    /// </summary>
    public enum MenuState
    {
        /// <summary>
        /// 有效,当前可用菜单
        /// </summary>
        [Description("有效")]
        Valid = 0,
        /// <summary>
        /// 无效,已注册但是停止使用的菜单
        /// </summary>
        [Description("无效")]
        Invalid = 1,
        /// <summary>
        /// 已注册,但是在当前运行环境中未找到支持该菜单运行的动态库
        /// </summary>
        [Description("未定义")]
        Undefined = 9
    }
}
