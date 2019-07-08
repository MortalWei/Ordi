using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ordi.App.Test.Utils
{
    class myEnumP
    {
        User User = new User();

        void aaa(string name)
        {
            User.Name = name;
        }

        void bbb(int sex)
        {
            User.SexCode = (Sex)sex;
        }

        void ccc(int age)
        {
            User.Age = age;
        }

        void ddd(int dd)
        {
            User.AllInt = dd;
        }
    }
}
