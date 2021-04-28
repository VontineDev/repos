using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1955Burger
{
    public class App
    {
        public App()
        {
            var burger1 = new Burger("1955버거");
            var patty1 = new Patty("순 쇠고기 패티");
            var lettuce1 = new Lettuce("신선한 양상추");
            var sauce1 = new Sauce("머스타드 소스");

            Console.WriteLine($"{burger1.GetBurgerName()}");
            Console.WriteLine($"{patty1.GetPattyName()}");
            Console.WriteLine($"{lettuce1.GetLettuceName()}");
            Console.WriteLine($"{sauce1.GetSauceName()}");


        }
    }
}
