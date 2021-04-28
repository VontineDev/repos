using System;

namespace _10817
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            int c = int.Parse(arr[2]);

            if (a > b)
            {
                if (a > c)
                {
                    if (b > c)
                    {
                        Console.WriteLine(b);
                    }
                    else
                    {
                        Console.WriteLine(c);
                    }
                }
                else
                {
                    Console.WriteLine(a);
                }
            }
            else
            {
                if (a > c)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    if (b > c)
                    {
                        Console.WriteLine(c);
                    }
                    else
                    {
                        Console.WriteLine(b);
                    }                    
                }
            }
        }        
    }
}
