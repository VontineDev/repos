using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax40
{
    public class Unit
    {
        //data
        //name
        //hp
        //damage
        public string name;
        public int maxHp = 40;
        public int hp;
        public int damage = 6;

        public Unit(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이(가) 생성되었습니다.");
            this.hp = this.maxHp;
        }
        public void Attack(Unit target)
        {

            Console.WriteLine($"{this.name}이 {target.name}을 공격 했습니다.");
            target.Hit(this);

        }
        public void Hit(Unit attacker)
        {
            this.hp = this.hp - attacker.damage;
            Console.WriteLine($"{this.name}가 {attacker.name}에게 공격당했습니다.({this.hp})/({this.maxHp})");
        }
    }
}
