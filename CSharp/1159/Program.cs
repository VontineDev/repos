using System;
using System.Collections.Generic;

namespace _1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> playerList = new List<string>();
            int[] cnt = new int[26];
            for (int i = 0; i < n; i++)
            {
                playerList.Add(Console.ReadLine());
            }

            foreach (string player in playerList)
            {
                switch (player.Substring(0, 1))
                {
                    case "a":
                        {
                            cnt[0]++;
                            break;
                        }
                    case "b":
                        {
                            cnt[1]++;
                            break;
                        }
                    case "c":
                        {
                            cnt[2]++;
                            break;
                        }
                    case "d":
                        {
                            cnt[3]++;
                            break;
                        }
                    case "e":
                        {
                            cnt[4]++;
                            break;
                        }
                    case "f":
                        {
                            cnt[5]++;
                            break;
                        }
                    case "g":
                        {
                            cnt[6]++;
                            break;
                        }
                    case "h":
                        {
                            cnt[7]++;
                            break;
                        }
                    case "i":
                        {
                            cnt[8]++;
                            break;
                        }
                    case "j":
                        {
                            cnt[9]++;
                            break;
                        }
                    case "k":
                        {
                            cnt[10]++;
                            break;
                        }
                    case "l":
                        {
                            cnt[11]++;
                            break;
                        }
                    case "m":
                        {
                            cnt[12]++;
                            break;
                        }
                    case "n":
                        {
                            cnt[13]++;
                            break;
                        }
                    case "o":
                        {
                            cnt[14]++;
                            break;
                        }
                    case "p":
                        {
                            cnt[15]++;
                            break;
                        }
                    case "q":
                        {
                            cnt[16]++;
                            break;
                        }
                    case "r":
                        {
                            cnt[17]++;
                            break;
                        }
                    case "s":
                        {
                            cnt[18]++;
                            break;
                        }
                    case "t":
                        {
                            cnt[19]++;
                            break;
                        }
                    case "u":
                        {
                            cnt[20]++;
                            break;
                        }
                    case "v":
                        {
                            cnt[21]++;
                            break;
                        }
                    case "w":
                        {
                            cnt[22]++;
                            break;
                        }
                    case "x":
                        {
                            cnt[23]++;
                            break;
                        }
                    case "y":
                        {
                            cnt[24]++;
                            break;
                        }
                    case "z":
                        {
                            cnt[25]++;
                            break;
                        }
                }
            }
            bool IsSelectable = false;
            for (int i = 0; i < 26; i++)
            {
                if (cnt[i] >= 5)
                {
                    IsSelectable = true;
                    Console.Write((char)(i + 97));
                }
            }
            if(IsSelectable==false)
            {
                Console.WriteLine("PREDAJA");
            }
        }
    }
}
