using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax50
{
    public class ValueMeal
    {
        //data
        //name
        //burger
        //drink
        //sidedish
        public string name;
        public Burger burger;
        public Drink drink;
        public SideDish sideDish;

        public ValueMeal(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}세트 이(가) 생성되었습니다.");

        }
        //function
        //GetBurger
        //GetDrink
        //GetSideDish
        //ShowComponent
        public void GetBurger()
        {
            var burger = new Burger(this.name);
            this.burger = burger;
        }
        public void GetDrink(string name)
        {
            var drink = new Drink(name);
            this.drink = drink;
        }
        public void GetSideDish(string name)
        {
            var sideDish = new SideDish(name);
            this.sideDish = sideDish;
        }
        public void ShowComponent()
        {
            Console.WriteLine($"{this.name}의 구성품은");
            Console.WriteLine($"{burger.name}, {drink.name}, {sideDish.name} 입니다.");

        }

    }
}
