﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax33
{
    public class Icecream
    {
        //data
        //name
        public string name;

        public Icecream(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이(가) 만들어졌습니다.");
        }

    }
}
