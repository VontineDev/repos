using System;

namespace Syntax25
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
        public void MakeUnit()
        {
            Unit unit = new Unit();
            unit.name = "SCV";
            Console.WriteLine(unit.name + "이 생성되었습니다.");
        }

    }
}
