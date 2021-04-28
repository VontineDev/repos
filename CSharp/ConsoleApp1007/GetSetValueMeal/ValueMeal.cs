using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetValueMeal
{
    public class ValueMeal
    {
        //data
        //name
        //burger
        //drink
        //sideDish
        string name;
        Burger burger;
        Drink drink;
        SideDish sideDish;
        public ValueMeal(string name)
        {
            this.name = name;




        }
        //function
        //GetValueMealName
        //SetBurger
        //GetBurger
        //SetDrink
        //GetDrink
        //SetSideDish
        //GetSideDish
        public string GetValueMealName()
        {
            return this.name;
        }
        public void SetBurger(Burger burger)
        {
            this.burger = burger;
        }
        public Burger GetBurger()
        {
            return this.burger;
        }
        public void SetDrink(Drink drink)
        {
            this.drink = drink;
        }
        public Drink GetDrink()
        {
            return this.drink;
        }
        public void SetSideDish(SideDish sideDish)
        {
            this.sideDish = sideDish;
        }
        public SideDish GetSideDish()
        {
            return this.sideDish;
        }
    }
}
