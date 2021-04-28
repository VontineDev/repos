using System;

namespace Syntax22
{
    class Program
    {

        enum Fruits { Peach, Strawberry, Apple };

        static void Main(string[] args)
        {
            Console.WriteLine("[1.복숭아, 2.딸기, 3사과]");
            Console.Write("좋아하는 과일의 번호를 입력하세요. ");

            int input = int.Parse(Console.ReadLine());

            Fruits selectedFruits = (Fruits)(input - 1);

            switch (selectedFruits)
            {
                case Fruits.Peach:
                    Console.WriteLine("복숭아");
                    break;
                case Fruits.Strawberry:
                    Console.WriteLine("딸기");
                    break;
                case Fruits.Apple:
                    Console.WriteLine("사과");
                    break;
                default:
                    Console.WriteLine("잘못입력하셨습니다.");
                    break;
            }
        }
    }
}
