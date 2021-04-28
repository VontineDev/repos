using System;

namespace _5622
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int dialTime = 0;           

           for(int i = 0; i < str.Length; i++)
            {
                switch(str[i])
                {
                    case 'A':
                    case 'B':
                    case 'C':
                        {
                            dialTime = dialTime + 3;
                        }
                        break;
                    case 'D':
                    case 'E':
                    case 'F':
                        {
                            dialTime = dialTime + 4;
                        }
                        break;
                    case 'G':
                    case 'H':
                    case 'I':
                        {
                            dialTime = dialTime + 5;
                        }
                        break;
                    case 'J':
                    case 'K':
                    case 'L':
                        {
                            dialTime = dialTime + 6;
                        }
                        break;
                    case 'M':
                    case 'N':
                    case 'O':
                        {
                            dialTime = dialTime + 7;
                        }
                        break;
                    case 'P':
                    case 'Q':
                    case 'R':
                    case 'S':
                        {
                            dialTime = dialTime + 8;
                        }
                        break;
                    case 'T':
                    case 'U':
                    case 'V':
                        {
                            dialTime = dialTime + 9;
                        }
                        break;
                    case 'W':
                    case 'X':
                    case 'Y':
                    case 'Z':
                        {
                            dialTime = dialTime + 10;
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(dialTime);
        }
    }
}
