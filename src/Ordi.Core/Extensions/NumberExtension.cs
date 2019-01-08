namespace Ordi
{
    /// <summary>
    /// 数值类型(int,double,decimal等)扩展辅助类
    /// </summary>
    public static class NumberExtension
    {
        /// <summary>
        /// 求幂指数
        /// </summary>
        /// <param name="args">幂</param>
        /// <param name="baseNum">幂底数</param>
        /// <returns>
        /// 若args不大于0,返回-1
        /// 若args等于1,返回0
        /// </returns>
        public static int ToPower(this int args, int baseNum = 2)
        {
            if (args <= 0) return -1;
            else if (args == 1) return 0;
            var result = 1;
            var num = args / baseNum;
            if (num == 1)
            {
                return result;
            }
            return result += num.ToPower(baseNum);
        }
    }
}
