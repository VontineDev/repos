using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax01
{
    public class App
    {

        int cost1 = 2500;
        int cost2 = 2700;
        //생성자(Constructor)
        public App()
        {
            Console.WriteLine("2019-10-07");
            //Pizza p1 = new Pizza();
            //Pizza p2 = p1;
            //string pizzaName1 = "고르곤졸라";
            //string pizzaName2 = "하와이언";

            //pizzaName1 = pizzaName2;

            //pizzaName1 = "페퍼로니 피자";

            //Console.WriteLine(pizzaName1);
            //Console.WriteLine(pizzaName2);


            //p1.name = pizzaName1;
            //p2.name = pizzaName2;
            //Console.WriteLine(p1.name);
            //Console.WriteLine(p2.name);

            //Burger b1 = new Burger("불고기버거");
            //Burger b2 = new Burger("1955버거");
            //b1 = b2;
            //b1.name = "슈슈버거";

            //b1 = null;

            //Console.WriteLine(b1.name);
            //Console.WriteLine(b2.name);

            
            
            Console.WriteLine($"{cost1}, {cost2}");
            Swap(cost1, cost2);
            Console.WriteLine($"{cost1}, {cost2}");

        }
        public void Swap(int a, int b)
        {
            Console.WriteLine($"{a}, {b}");
            int temp = a;
            a = b;
            b = temp;
            cost1 = b;
            cost2 = a; 
            Console.WriteLine($"{a}, {b}");
        }

    }
}
