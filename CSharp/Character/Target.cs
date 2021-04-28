using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character
{
    public class Target
    {
        //data
        //name
        public string name;
        public Target(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이 생성되었습니다.");
        }
        //function
        //Hit
        public void Hit(Character character)
        {
            Console.WriteLine($"{this.name}가 {character.name}에게 활을 맞았습니다.");

        }
    }
}
