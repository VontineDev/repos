using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax31
{
    public class App
    {
        public App()
        {
            var carfactory1 = new CarFactory();
            carfactory1.name = "현대";
            Console.WriteLine($"{carfactory1.name}이(가) 만들어졌습니다.");

            var car1 = carfactory1.MakeCar("투싼");
            var car2 = carfactory1.MakeCar("엑센트");
            var car3 = carfactory1.MakeCar("코나");

            Console.WriteLine($"{car1.name}이(가) 만들어졌습니다.");
            Console.WriteLine($"{car2.name}이(가) 만들어졌습니다.");
            Console.WriteLine($"{car3.name}이(가) 만들어졌습니다.");


        }
    }
}
