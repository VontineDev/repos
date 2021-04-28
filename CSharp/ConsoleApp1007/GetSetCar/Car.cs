using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax02
{
    public class Car
    {
        //data
        //name
        //Engine
        //Tire
        string name;
        Engine engine;
        Tire tire;

        public Car(string name)
        {
            this.name = name;
        }
        //function
        //SetTire
        //Gettire
        //SetEngine
        //GetEngine

        public string GetCarName()
        {
            return this.name;
        }

        public void SetTire(Tire tire)
        {
            this.tire = tire;
        }
        public Tire GetTire()
        {
            return tire;
        }

        public void SetEngine(Engine engine)
        {
            this.engine = engine;
        }
        public Engine GetEngine()
        {
            return engine;
        }
    }
}
