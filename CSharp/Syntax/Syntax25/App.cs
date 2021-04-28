using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax25
{
    class App
    {
        //데이터
        public App()
        {
            CommandCenter commandCenter1 = new CommandCenter();
            Console.WriteLine(commandCenter1 + "가 생성되었습니다.");

            commandCenter1.MakeUnit();
           
        }

        //메서드
    }
}
