using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Class1003
{
    public class App
    {
        public App()
        {
            CoffeeShop coffeeShop1 = new CoffeeShop("스타벅스");

            coffeeShop1.MakeCoffee("아메리카노");
            coffeeShop1.MakeSleeve("LONDON 로고 슬리브");
            coffeeShop1.MakeStraw("친환경 종이 빨대");
            coffeeShop1.SurveCoffee();
        }
    }
}
