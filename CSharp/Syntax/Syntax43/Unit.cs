using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax43
{
    public class Unit
    {
        //data
        //name
        public string name;
        public int output = 10;
        public Unit(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이(가) 생성되었습니다.");
        }
        //function
        //VeinMine
        public void VeinMine(Resource resource)
        {
            resource.gold = resource.gold - this.output;
            Console.WriteLine($"{this.name}이 {resource.name}을 채취하였습니다. +{this.output}");
          
        }
    }
}
