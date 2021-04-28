using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax02
{
    public class Engine
    {
        //data
        //name
        string name;

        public Engine(string name)
        {
            this.name = name;
        }

        public string GetEngineName()
        {
            return this.name;
        }
    }
}
