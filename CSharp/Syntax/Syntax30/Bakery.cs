using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax30
{
    public class Bakery
    {
        //데이터
        //이름
        public string name;

        public Bakery()
        {

        }

        public Bread MakeBread(string name)
        {
            Bread bread = new Bread();
            bread.name = name;
            return bread;
        }
    }
}
