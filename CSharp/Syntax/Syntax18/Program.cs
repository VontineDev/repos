using System;

namespace Syntax18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("다음 중 통일신라 시대의 도읍은 어디인지 알맞은 정답을 찾아 입력하세요.");
            Console.WriteLine("1.평양");
            Console.WriteLine("2.서라벌");
            Console.WriteLine("3.개성");
            Console.WriteLine("4.한양");
            Console.WriteLine("5.전주");
            Console.WriteLine("정답 몇번 입니까? ");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("틀렸습니다. 통일신라의 도읍은 평양이 아닙니다.");
                    break;

                case 2:
                    Console.WriteLine("정답입니다. 통일신라의 도읍은 서라벌 입니다.");
                    break;

                case 3:
                    Console.WriteLine("틀렸습니다. 통일신라의 도읍은 개성이 아닙니다.");
                    break;

                case 4:
                    Console.WriteLine("틀렸습니다. 통일신라의 도읍은 한양이 아닙니다.");
                    break;

                case 5:
                    Console.WriteLine("틀렸습니다. 통일신라의 도읍은 전주이 아닙니다.");
                    break;

                default:
                    Console.WriteLine("잘못 입력 하셨습니다.");
                    break;
            }
        }
        
    }
}
