using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax28
{
    public class App
    {
        public App()
        {
            PizzaShop pizzashop1 = new PizzaShop("PiaazAlvolo");


            Pizza pizza1 = pizzashop1.MakePizza("전주불백피자");
            Pizza pizza2 = pizzashop1.MakePizza("부산피자");
            Pizza pizza3 = pizzashop1.MakePizza("단호박피자");

           
        }
    }
}
