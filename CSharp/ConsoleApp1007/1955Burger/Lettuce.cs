using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1955Burger
{
    public class Lettuce
    {
        //data
        //name
        string name;
        public Lettuce(string name)
        {
            this.name = name;
        }
        public string GetLettuceName()
        {
            return this.name;
        }
    }
}
