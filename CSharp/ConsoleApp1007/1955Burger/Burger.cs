using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1955Burger
{
    public class Burger
    {
        //data
        //name
        //patty
        //Lettuce
        //Cheese
        string name;
        Patty patty;
        Lettuce lettuce;
        Sauce cheese;        
        public Burger(string name)
        {
            this.name = name;
        }
        //function
        //GetBurgerName
        //SetPatty
        //GetPatty
        //SetLettuce
        //GetLettuce
        //SetCheese
        //GetCheese
        public string GetBurgerName()
        {
            return this.name;
        }
        public void SetPatty(Patty patty)
        {
            this.patty = patty;
        }
        public Patty GetPatty()
        {
            return this.patty;
        }
        public void SetLettuce(Lettuce lettuce)
        {
            this.lettuce = lettuce;
        }
        public Lettuce GetLettuce()
        {
            return this.lettuce;
        }
        public void SetCheese(Sauce cheese)
        {
            this.cheese = cheese;
        }
        public Sauce GetCheese()
        {
            return this.cheese;
        }

    }
}
