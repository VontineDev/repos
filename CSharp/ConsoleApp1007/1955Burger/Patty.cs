using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1955Burger
{
    public class Patty
    {
        //data
        //name
        string name;
        public Patty(string name)
        {
            this.name = name;
        }
        public string GetPattyName()
        {
            return this.name;
        }
    }
}
