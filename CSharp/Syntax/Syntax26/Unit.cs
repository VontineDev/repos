using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax26
{
    class Unit
    {
        //데이터
        //이름
        //체력
        //공격력
        public string name;
        int maxHp = 100;
        int hp;
        int damage = 5;
        public Unit()
        {
            hp = maxHp;
        }
        //메서드
        //이동한다
        //공격한다
        public void Attack(Unit target)
        {
            target.Hit(this.damage, this.name);
        }
        public void Hit(int damage, string attackerName)
        {
            this.hp = this.hp - damage;
            Console.WriteLine($"{this.name}가 {attackerName}에게 공격받았습니다.  ({this.hp})/({this.maxHp})");
        }
       
    }
}
