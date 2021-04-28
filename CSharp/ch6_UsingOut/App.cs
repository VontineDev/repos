using System;
using System.Collections.Generic;
using System.Text;

namespace ch6_UsingOut
{
    class App
    {
        void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
        public App()
        {
            int a = 20;
            int b = 3;
            //int c;
            //int d;

            Divide(a, b, out int c, out int d);

            Console.WriteLine($"a:{a}, b:{b}, a/b:{c}, a%b:{d}");
        }
    }
}
