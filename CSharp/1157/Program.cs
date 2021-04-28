using System;
namespace _1157
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cntAlpha = new int[26];
            string str = Console.ReadLine();
            string str2 = str.ToUpper();

            for (int i = 0; i < str2.Length; i++)
            {
                int j = ((int)str2[i] - 65);

                cntAlpha[j]++;
            }

            int max = cntAlpha[0];
            int mostUsed = 0;
            int Duple = 0;

            for (int i = 1; i < 26; i++)
            {
                if (max < cntAlpha[i])
                {
                    max = cntAlpha[i];
                    mostUsed = i;
                }
            }
            for (int i = 0; i < 26; i++)
            {
                if (max == cntAlpha[i])
                {
                    Duple++;
                }
            }

            if (Duple == 1)
            {
                Console.WriteLine((char)(mostUsed + 65));
            }
            else
            {
                Console.WriteLine("?");
            }
        }
    }
}
