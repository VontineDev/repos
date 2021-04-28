using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetValueMeal
{
    public class Drink
    {
        //data
        //name        
        string name;
        public Drink(string name)
        {
            this.name = name;
        }
        public string GetDrinkName()
        {
            return this.name;
        }
    }
}
