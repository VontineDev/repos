using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax48
{
    public class Car
    {
        //data
        //name
        //engine
        //tire
        public string name;
        public Engine engine;
        public Tire tire;

        public Car(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이 생성되었습니다.");
        }
        public void GetEngine(string name)
        {
            var engine = new Engine(name);
            this.engine = engine;
        }
        public void GetTire(string name)
        {
            var tire = new Tire(name);
            this.tire = tire;
        }
    }
}
