using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1007
{
    public class Unit
    {
        //data
        //name
        //damage
        //hp
        //attackRange
        public string name;
        public int hp;
        public int maxHp;
        public int damage;
        public int attackRange;        
        public Unit(string name, int maxHp, int damage, int attackRange)
        {
            this.name = name;
            this.maxHp = maxHp;
            this.hp = maxHp;
            this.damage = damage;
            this.attackRange = attackRange;
            Console.WriteLine($"{this.name}이 생성되었습니다.");
            Console.WriteLine($"{this.name}의 공격력은{this.damage}입니다.");
            Console.WriteLine($"{this.name}의 공격사거리는 {this.attackRange}입니다.");
            Console.WriteLine($"{this.name}의 체력은 {this.hp}입니다.");
        }
        //function
        //Attack
        //Hit
        public void Attack(Unit target, int distance)
        {
            Console.WriteLine($"{this.name}이 {target.name}을 공격했습니다.");
            if(distance>this.attackRange)
            {
                Console.WriteLine("사거리가 되지 않아 공격에 실패 했습니다");
                return;
            }
            target.Hit(this);
        }
        public void Hit(Unit attacker)
        {
            this.hp = this.hp - attacker.damage;
            Console.WriteLine($"{attacker.name}이 {this.name}을 공격했습니다.");
            Console.WriteLine($"{this.name}의 체력이 감소했습니다.");
            Console.WriteLine($"{this.name}의 체력은 {this.hp}{this.maxHp}입니다.");

        }
    }
}
