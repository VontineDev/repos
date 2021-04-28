using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax49
{
    public class CPU
    {
        //data
        //name
        //manufacturer
        public string name;
        public string manufacturer="AMD";

        public CPU(string name,PC pcname)
        {
            this.name = name;
            Console.WriteLine($"{pcname.name}의 CPU가 생성되었습니다.");
            Console.WriteLine($"{pcname.name}의 CPU의 이름은 {this.name} 입니다.");
            Console.WriteLine($"{this.name}의 제조사는 {this.manufacturer}입니다.");


        }
    }
}
