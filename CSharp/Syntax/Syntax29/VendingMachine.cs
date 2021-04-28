using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax29
{
    
    public class VendingMachine
    {
        //데이터
        //이름
        public string name;
        public VendingMachine(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이(가) 생성되었습니다.");
        }

        public Drink TakeDrnik(string name)
        {
            Drink drink = new Drink(name);

            return drink;
        }
    }
}
