using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax27
{
    public class BurgerShop
    {
        //데이터
        //이름
        public string name;
        public BurgerShop()
        {

        }
        //기능
        //버거를만든다
        public Burger MakeBurger(string name)
        {
            Burger burger = new Burger();
            burger.name = name;            
            return burger;
        }
        public FrenchFries MakeFrenchFries()
        {
            FrenchFries frenchfries = new FrenchFries();
            frenchfries.name = name;
            return frenchfries;
        }
        public Drink MakeDrink(string name)
        {
            Drink drink = new Drink();
            drink.name = name;
            return drink;
        }
        public ValueMeals MakeValueMeal()
        {

            ValueMeals valuemeal = new ValueMeals();
            return valuemeal;
        }
    }
}
