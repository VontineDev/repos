using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax31
{
    public class CarFactory
    {
        //데이터
        //이름
        public string name;
        public CarFactory()
        {

        }
        public Car MakeCar(string name)
        {
            var car = new Car();
            car.name = name;
            return car;
        }
    }
}
