using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class App2
    {
        public App2()
        {
            Func<float> func0 = () => 0.1f;
            Func<int, float> func1 = (a) => a * 0.1f;
            Func<int, int, float> func2 = (a, b) => (a + b) * 0.1f;

            Func<int, int, int, float> func3;
            func3 = new Func<int, int, int, float>(temp);


            Console.WriteLine("func0의 반환값: {0}", func0());
            Console.WriteLine("func1의 반환값: {0}", func1(10));
            Console.WriteLine("func2의 반환값: {0}", func2(10,10));
            Console.WriteLine("func3의 반환값: {0}", func3(10,10,10));

        }
        public float temp(int a, int b, int c)
        {
            return (a + b + c) * 0.1f;
        }
    }
}
