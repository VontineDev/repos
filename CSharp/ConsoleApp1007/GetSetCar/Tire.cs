using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax02
{
    public class Tire
    {
        //data
        //name
        string name;
        public Tire(string name)
        {
            this.name = name;
        }

        public string GetTireName()
        {
            return this.name;
        }
    }
}
