//using System;

//namespace _15552
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int testcase = int.Parse(Console.ReadLine());
//            for (int i = 0; i < testcase; i++)
//            {
//                string str = Console.ReadLine();
//                string[] arr = str.Split(' ');
//                int a = int.Parse(arr[0]);
//                int b = int.Parse(arr[1]);

//                Console.WriteLine(a + b);
//            }
//        }
//    }
//}
using System;

public class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();
        string[] ss = s.Split();
        int a = int.Parse(ss[0]);
        int b = int.Parse(ss[1]);
        Console.WriteLine(a + b);
    }
}