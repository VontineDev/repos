using System;

namespace test
{
    public class App
    {
        public App()
        {
            int sum = 0;

            Action action0 = () => Console.WriteLine("name: 액션 0");
            Action<string> action1 = new Action<string>(temp);
            Action<string, string> action2 = (name, age) =>
            {
                Console.Write("name: {0}", name);
                Console.WriteLine("age: {0}", age);

            };
            Action<int, int, int> action3 = (a, b, c) => sum = a + b + c;


            action0();
            action1("액션1");
            action2("액션2", "25");
            
            action3(100, 20, 5);
            Console.WriteLine("sum: {0}", sum);


        }
        public void temp(string name)
        {
            Console.WriteLine("name: {0}", name);

        }
    }
}