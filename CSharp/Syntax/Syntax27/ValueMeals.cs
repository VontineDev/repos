using System;
using System.Collections.Generic;


namespace Syntax27
{
    public class ValueMeals
    {
        //데이터
        //이름
        public string name;
        public Burger burger;
        public Drink drink;
        public FrenchFries frenchfries;

        public ValueMeals()
        {
            burger = new Burger();
            drink = new Drink();
            frenchfries = new FrenchFries();
        }
    }
}
