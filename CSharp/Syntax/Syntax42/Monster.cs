using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax42
{
    public class Monster
    {
        //data
        //name
        //damage       
        public string name;
        public int damage = 5;
       

        public Monster(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이(가) 생성되었습니다.");
        }

        public void Attack(Crop crop)
        {
            Console.WriteLine($"{this.name}가 {crop.name}을 공격했습니다.");
            crop.Hit(this);
        }
       
    }
}
