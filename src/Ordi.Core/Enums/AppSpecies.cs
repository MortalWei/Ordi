using System.ComponentModel;

namespace Ordi.Enums
{
    /// <summary>
    /// 应用种类
    /// </summary>
    public enum AppSpecies
    {
        /// <summary>
        /// 窗体应用程序
        /// </summary>
        [Description("窗体应用程序")]
        Winform = 0,
        /// <summary>
        /// 网页应用程序
        /// </summary>
        [Description("网页应用程序")]
        Web = 1,
        /// <summary>
        /// 其它
        /// </summary>
        [Description("其它")]
        Other = 9
    }
}
