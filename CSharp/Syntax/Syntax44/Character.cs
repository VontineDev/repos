using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax44
{
    public class Character
    {
        //data
        //name
        public string name;
        public Cloth cloth;
        public Character(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이(가) 생성되었습니다.");
        }
        //function
        //PutOnCloth
        public void PutOnCloth(Cloth cloth)
        {
            this.cloth = cloth;

            Console.WriteLine($"{this.name}가 {cloth.name}을 입었습니다.");

        }

    }
}
