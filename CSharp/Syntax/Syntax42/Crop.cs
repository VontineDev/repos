using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax42
{
    public class Crop
    {
        //data
        //name
        //hp
        public string name;
        public int maxHp = 30;
        public int hp;
        public Crop(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이(가) 생성되었습니다.");
            this.hp = this.maxHp;
        }

        public void Hit(Monster attacker)
        {
            this.hp = this.hp - attacker.damage;
            Console.WriteLine($"{this.name}이 {attacker.name}에의해 공격당했습니다.({this.hp})/({this.maxHp})");
        }

    }
}
