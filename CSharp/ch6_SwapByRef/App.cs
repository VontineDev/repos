using System;
using System.Collections.Generic;
using System.Text;

namespace ch6_SwapByRef
{
    class App
    {
        public App()
        {
            int x = 3;
            int y = 4;

            Console.WriteLine($"x:{x}, y:{y}");

            Swap(ref x, ref y);

            Console.WriteLine($"x:{x}, y:{y}");

        }
        void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
    }
}
