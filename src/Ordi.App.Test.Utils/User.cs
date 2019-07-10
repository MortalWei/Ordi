using Ordi.Attributes;
using System;

namespace Ordi.App.Test.Utils
{
    public class User
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public Guid Uid { get; set; }

        public bool Sex { get; set; }

        public string SexText
        {
            get
            {
                return Sex ? "男" : "女";

            }
            set
            {
                Sex = (value == "男");
            }
        }

        public Sex SexCode { get; set; }

        public int? AllInt { get; set; }

        public Role RoleCode { get; set; }
    }

    public enum Sex
    {
        男 = 1,
        女 = 2,
        未知 = 9
    }

    [Flags]
    public enum Role
    {
        管理员 = 1,
        医师 = 2,
        护士 = 4,
        行政 = 8
    }

    public class MortalLog
    {
        [DataField("ID")]
        public string Id { get; set; }
        [DataField("CONTENT")]
        public string Content { get; set; }
        //[DataField("CREATION_DATE")]
        public DateTime? CreationDate { get; set; }
        public string Remark { get; set; }
    }
}
