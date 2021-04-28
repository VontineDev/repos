using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax48
{
    public class App
    {
        public App()
        {
            var car1 = new Car("KIA 모닝");

            car1.GetEngine("카파 1.0 ECO Prine");
            car1.GetTire("Kumho타이어");

        }
    }
}
