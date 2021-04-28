using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax50
{
    public class App
    {
        public App()
        {
            var valueMeal1 = new ValueMeal("더블 치즈버거");

            valueMeal1.GetBurger();
            valueMeal1.GetDrink("콜라");
            valueMeal1.GetSideDish("감자칩");
            valueMeal1.ShowComponent();

        }
    }
}
