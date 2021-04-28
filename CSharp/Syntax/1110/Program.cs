using System;

namespace _10952
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());
            int tensOfinput = input / 10;
            int unitsOfinput = input - tensOfinput * 10;
            int uOld = unitsOfinput;
            int tOld = tensOfinput;
            int oldNum = tOld * 10 + uOld;
            int newNum = -1;
            int i = 0;

            while (input != newNum)
            {
                newNum = uOld * 10 + uOld + tOld;
                if (uOld + tOld >= 10)
                {
                    newNum = uOld * 10 + (uOld + tOld) - 10;
                }
                int tnewNum = newNum / 10;
                int unewNum = newNum - tnewNum * 10;

                tOld = tnewNum;
                uOld = unewNum;
                i++;
            }
            Console.WriteLine(i);
        }
    }
}

