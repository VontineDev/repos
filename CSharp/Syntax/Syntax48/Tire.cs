using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax48
{
    public class Tire
    {
        //data
        //name
        public string brand;
        public string productName="Solus TA31";
        public Tire(string brand)
        {
            this.brand = brand;
            Console.WriteLine($"타이어 ({this.brand})이(가) 생성되었습니다.");
            Console.WriteLine($"타이어의 이름은 {this.brand} 입니다.");
            Console.WriteLine($"{this.brand}의 규격은 {this.productName}입니다.");

        }
    }
}
