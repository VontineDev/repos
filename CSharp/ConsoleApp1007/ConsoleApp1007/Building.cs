using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1007
{
    public class Building
    {
        //data
        //name
        public string name;
        public Building(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이 생성되었습니다.");
        }
        //function
        //MakeUnit
        public Unit MakeUnit(string name, int maxHp, int damage, int attackRange)
        {
            var unit = new Unit(name, maxHp, damage, attackRange);
            return unit;
        }
    }
}
