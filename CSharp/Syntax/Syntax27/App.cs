using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax27
{
    public class App
    {
        public BurgerShop burgershop1;
        public App()
        {
            BurgerShop burgershop1 = new BurgerShop();
            burgershop1.name = "McDonalds";
            Console.WriteLine(burgershop1.name + "가 만들어졌습니다.");

            ValueMeals valuemeal1 = burgershop1.MakeValueMeal();

            valuemeal1.burger.name = "1955버거";
            valuemeal1.drink.name = "콜라";
            valuemeal1.frenchfries.name = "감자튀김";

            Console.WriteLine($"{valuemeal1.burger.name}가 만들어졌습니다.");
            Console.WriteLine($"{valuemeal1.drink.name}가 만들어졌습니다.");
            Console.WriteLine($"{valuemeal1.frenchfries.name}가 만들어졌습니다.");





        }

    }
}
