using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Class1003
{
    public class CoffeeShop
    {
        //data
        //name
        //coffee
        //sleeve
        //straw
        public string name;
        public Coffee coffee;
        public Sleeve sleeve;
        public Straw straw;

        public CoffeeShop(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이 생성되었습니다.");

        }

        //function
        //MakeCoffee
        //MakeSleeve
        //MakeStraw
        //SurveCoffee
        public void MakeCoffee(string name)
        {
            var coffee = new Coffee(name);
             this.coffee= coffee;
        }
        public void MakeSleeve(string name)
        {
            var sleeve = new Sleeve(name);
            this.sleeve = sleeve;
        }
        public void MakeStraw(string name)
        {
            var straw = new Straw(name);
            this.straw = straw;
        }

        public void SurveCoffee()
        {
            Console.WriteLine($"{this.coffee.name}에 {this.sleeve.name}을 껴서 {this.straw.name}을 꼽고 손님에게 드렸습니다.");

        }

    }
}
