using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetValueMeal
{
    public class SideDish
    {
        //data
        //name        
        string name;
        public SideDish(string name)
        {
            this.name = name;
        }
        public string GetSideDishName()
        {
            return this.name;
        }
    }
}
