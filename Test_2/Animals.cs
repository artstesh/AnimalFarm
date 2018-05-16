using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    abstract class Animals
    {
        public string name;
        public string massa;

        public string View()
        {
            return (name + " " + "весит" + massa + "кг");
        }
    }
}
