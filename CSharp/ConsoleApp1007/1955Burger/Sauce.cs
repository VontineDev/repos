using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1955Burger
{
    public class Sauce
    {
        //data
        //name
        string name;
        public Sauce(string name)
        {
            this.name = name;
        }
        public string GetSauceName()
        {
            return this.name;
        }
    }
}
