using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax26
{
    class CommandCenter
    {
        //데이터
        //체력
        int hp;
       
        public CommandCenter()
        {

        }
        //메서드
        //유닛을 만든다.

        public Unit MakeUnit(string name)
        {
            Unit unit = new Unit();
            unit.name = name;
            Console.WriteLine(unit.name + "이(가) 생성되었습니다.");
            return unit;
        }
    }
}
