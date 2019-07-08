using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ordi.App.Test.Utils
{
    public class User
    {
        public int Id { get; set; }

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
    }

    public enum Sex
    {
        男 = 1,
        女 = 2,
        未知 = 9
    }
}
