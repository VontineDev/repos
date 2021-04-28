using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax26
{
    class App
    {
        public App()
        {
            CommandCenter commandCenter1 = new CommandCenter();
            Console.WriteLine(commandCenter1 + "이(가) 생성되었습니다. ");

            
            Unit unit1 = commandCenter1.MakeUnit("SCV1");
           
            Unit unit2 = commandCenter1.MakeUnit("SCV2");

            unit1.Attack(unit2);

        }

    }
}
