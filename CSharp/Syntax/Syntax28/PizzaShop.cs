using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax28
{


   
    public class PizzaShop
    {

        public string name;

        //생성자 메서드 또는 생성자 라고부른다
        public PizzaShop(string name)
        {
            this.name = name;
        }

        public Pizza MakePizza(string name)
        {
            Pizza pizza = new Pizza(name);
            
            return pizza;
        }

    }
}
