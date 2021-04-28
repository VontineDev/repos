using System;

namespace Syntax17
{
    class Program
    {
        static void Main(string[] args)
        {
            string itemName = "도끼";

            switch (itemName)
            {
                case "장검":
                    {
                        Console.WriteLine("장검을 선택했습니다.");
                        break;
                    }                    
                case "단검":
                    {
                        Console.WriteLine("단검을 선택했습니다.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("{0}을 선택할 수 없습니다.", itemName);
                        break;
                    }
                    
            }

            if(itemName=="장검")
            {
                Console.WriteLine("장검을 선택했습니다.");
            }
            else if (itemName=="단검")
            {
                Console.WriteLine("단검을 선택했습니다.");
            }
            else
            {
                Console.WriteLine("{0}을 선택할 수 없습니다.", itemName);
            }
        }
    }
}
