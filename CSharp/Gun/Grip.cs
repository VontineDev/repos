using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun
{
    public class Grip
    {
        //data
        //name
        public string name;
        public Grip(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이 생성되었습니다.");
        }
    }    
}
