using System;

namespace _1152
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().Trim();

            var words = str.Split();
            int count = 0;
            foreach(var a in words)
            {
                if(string.IsNullOrEmpty(a))
                {
                    count++;
                }
            }

            Console.WriteLine(words.Length - count);

        }
    }
}
