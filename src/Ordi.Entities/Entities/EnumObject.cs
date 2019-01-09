namespace Ordi.Entities
{
    /// <summary>
    /// 枚举转换对象
    /// </summary>
    public class EnumObject
    {
        /// <summary>
        /// Enum-Value
        /// 枚举值
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Enum-Name
        /// 枚举名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Enum-Description
        /// 说明
        /// </summary>
        public string Desc { get; set; }
    }
}
