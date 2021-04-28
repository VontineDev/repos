using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetValueMeal
{
    public class App
    {
        public App()
        {
            var valueMeal1 = new ValueMeal("몬스터X 세트");
            var burger1 = new Burger("몬스터X 버거");
            var drink1 = new Drink("콜라(L)");
            var sideDish1 = new SideDish("프렌치프라이(L)");

            Console.WriteLine($"{valueMeal1.GetValueMealName()}을 만들었습니다.");

            valueMeal1.SetBurger(burger1);
            var burgerMonsterX = valueMeal1.GetBurger();
            Console.WriteLine($"{burgerMonsterX.GetBurgerName()}");
            valueMeal1.SetDrink(drink1);
            var drinkMonsterX = valueMeal1.GetDrink();
            Console.WriteLine($"{drinkMonsterX.GetDrinkName()}");
            valueMeal1.SetSideDish(sideDish1);
            var sideDishMonsterX = valueMeal1.GetSideDish();
            Console.WriteLine($"{sideDishMonsterX.GetSideDishName()}");
        }
    }
}
