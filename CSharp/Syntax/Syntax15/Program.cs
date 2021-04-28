using System;

namespace Syntax15
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Int32.Parse(Console.ReadLine());
            int quotient = 0;
            bool isRemain = false;

            for (int i = input / 5; i > -1; i--)
            {
                for (int j = input / 3; j > -1; j--)
                {
                    isRemain = (input == (5 * i + 3 * j));                   
                    if (isRemain)
                    {
                        quotient = i + j;                        
                        break;
                    }
                }
                if (isRemain)
                {
                    break;
                }
            }
            if (isRemain)
            {
                Console.WriteLine(quotient);
            }
            else
            {
                Console.WriteLine(-1);
            }

        }
    }
}
