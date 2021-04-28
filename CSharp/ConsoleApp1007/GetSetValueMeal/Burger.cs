using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetValueMeal
{
    public class Burger
    {
        //data
        //name        
        string name;
        
        public Burger(string name)
        {
            this.name = name;
        }
        //function
        public string GetBurgerName()
        {
            return this.name;
        }

    }
}
