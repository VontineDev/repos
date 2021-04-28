using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            new App();
            string input = Console.ReadLine();
            string[] str = input.Split(' ');
            int replayNum = int.Parse(str[0]);

            string substr = str[1];

            for (int j = 0; j < substr.Length; j++)
            {
                for (int i = 0; i < replayNum; i++)
                {
                    Console.Write(substr[j]);
                }
            }
        }
    }
}
