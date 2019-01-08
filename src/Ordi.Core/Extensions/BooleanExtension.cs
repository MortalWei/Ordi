namespace Ordi
{
    /// <summary>
    /// Boolean扩展辅助类
    /// </summary>
    public static class BooleanExtension
    {
        /// <summary>
        /// Boolean转Int32
        /// </summary>
        /// <param name="args"></param>
        /// <returns>
        /// False返回0
        /// True返回1
        /// </returns>
        public static int ToInt(this bool args)
        {
            return args ? 1 : 0;
        }

        /// <summary>
        /// Boolean转Int32
        /// </summary>
        /// <param name="args"></param>
        /// <returns>
        /// False返回"0"
        /// True返回"1"
        /// </returns>
        public static string ToIntStr(this bool args)
        {
            return args ? "1" : "0";
        }
    }
}
