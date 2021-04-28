using System;
namespace _1193
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int a=1;
            int b=1;
            int sum = 3;
            int cnt = 1;
            if(input ==1)
            {
                Console.WriteLine($"{a}/{b}");
            }
            else
            {
                while(cnt!=input)
                {                    
                    if(sum%2==1)
                    {                        
                        b = sum - a;                        
                        cnt++;
                        if(cnt==input)
                        { break; }
                        a++;
                        if (b==1)
                        {
                            sum++;
                            a = 1;
                            continue;
                        }
                    }
                    else
                    {                       
                        a = sum - b;                        
                        cnt++;
                        if (cnt == input)
                        { break; }
                        b++;
                        if (a==1)
                        {
                            sum++;
                            b = 1;
                            continue;
                        }
                    }
                }
                Console.WriteLine($"{a}/{b}");
            }
        }
    }
}
