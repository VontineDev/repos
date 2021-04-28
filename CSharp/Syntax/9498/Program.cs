using System;

namespace _9498
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if(input<=100 && input>=90)
            {
                Console.WriteLine("A");
            }
            else if (input <= 89 && input >= 80)
            {
                Console.WriteLine("B");
            }
            else if (input <= 79 && input >= 70)
            {
                Console.WriteLine("C");
            }
            else if (input <= 69 && input >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }


        }
    }
}
