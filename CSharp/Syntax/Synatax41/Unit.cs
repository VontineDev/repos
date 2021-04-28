using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax41
{
    public class Unit
    {
        //data
        //name
        //hp
        //damage
        public string name;
        public int maxHp=200;
        public int hp;
        public int damage=15;

        public Unit(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이(가) 생성되었습니다.");
            hp = maxHp;
        }
        //function
        //Attack
        //Hit
        public void Attack(Unit target)
        {
            Console.WriteLine($"{this.name}이 {target.name}을 공격했습니다.");
            target.Hit(this);

        }
        public void Hit(Unit attacker)
        {
            this.hp = this.hp - attacker.damage;
            Console.WriteLine($"{this.name}이 {attacker.name}에게 공격 당했습니다. ({this.hp})/({this.maxHp})");
        }

    }
}
