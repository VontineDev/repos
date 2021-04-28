using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax14
{
    class Program
    {        
        static void Main(string[] args)
        {
            int smallNum;
            //Console.Write("입력 : ");
            int input1 = Int32.Parse(Console.ReadLine());
            int input2 = Int32.Parse(Console.ReadLine());
            //int input1 = 12;
            //int input2 = 18;

            if (input1 < input2)
            {
                smallNum = input1;
            }
            else
            {
                smallNum = input2;
            }
           for (int i = smallNum; i>=1; i--)
            {
                if(input1 % i ==0 && input2 % i ==0)
                {                    
                    Console.WriteLine(i);
                    break;
                }
            }
          
        }
    }
}
