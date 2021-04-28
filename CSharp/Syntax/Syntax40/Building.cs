using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax40
{
    

    public class Building
    {
        //data
        //name
        public string name;
        public Building()
        {

        }
        public Unit MakeUnit(string name)
        {
            var unit = new Unit(name);
            return unit;
        }
    }

   
}
