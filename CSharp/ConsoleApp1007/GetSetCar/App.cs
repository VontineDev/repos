using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax02
{
    public class App
    {
        public App()
        {
            var car1 = new Car("니로");
            var engine1 = new Engine("카파 1.6 GDI 엔진");
            var tire1 = new Tire("미쉐린 ENERGY SAVER AS");

            car1.SetEngine(engine1);
            var engineNiro = car1.GetEngine();


            car1.SetTire(tire1);
            var tireNiro = car1.GetTire();

            Console.WriteLine($"{car1.GetCarName()}에 {engineNiro.GetEngineName()}과 {tireNiro.GetTireName()}를 조립했습니다.");

        }
    }
}
