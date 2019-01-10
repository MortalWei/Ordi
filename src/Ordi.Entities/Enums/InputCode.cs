using System.ComponentModel;

namespace Ordi.Enums
{
    /// <summary>
    /// 输入码种类
    /// </summary>
    public enum InputCode
    {
        /// <summary>
        /// 混合
        /// </summary>
        [Description("混合模式")]
        All = 0,
        /// <summary>
        /// 拼音
        /// </summary>
        [Description("拼音码模式")]
        Spell = 1,
        /// <summary>
        /// 五笔
        /// </summary>
        [Description("五笔模式")]
        FiveStroke = 2,
        /// <summary>
        /// 其它
        /// </summary>
        [Description("其它")]
        Other = 9
    }
}
