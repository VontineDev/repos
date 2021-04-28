using System;

namespace _1018
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tmp = Console.ReadLine().Split();
            int row = int.Parse(tmp[0]);
            int col = int.Parse(tmp[1]);
            char[,] arr = new char[row, col];
            for (int i = 0; i < row; i++)
            {
                string tmp2 = Console.ReadLine();
                for (int j = 0; j < tmp2.Length; j++)
                {
                    arr[i, j] = tmp2[j];
                }
            }
            int cnt = 0;
            for (int i = 0; i <= row - 8; i++)
            {
                for (int j = 0; j <= col - 8; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        cnt = PaintChessBoard(arr, i, j);
                    }
                    else
                    {
                        int tmpCnt = PaintChessBoard(arr, i, j);
                        if (tmpCnt < cnt)
                        {
                            cnt = tmpCnt;
                        }
                    }
                }
            }

            Console.WriteLine(cnt);

        }

        static int PaintChessBoard(char[,] arr, int startRow, int startCol)
        {
            int tmp1 = 0;
            int tmp2 = 0;
            if (startRow + 8 > arr.GetLength(0) || startCol + 8 > arr.GetLength(1))
            {
                return -1;
            }
            for (int i = startRow; i < startRow + 8; i++)
            {
                for (int j = startCol; j < startCol + 8; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        if (arr[i, j] != 'W')
                        {
                            tmp1++;
                        }
                        else
                        {
                            tmp2++;
                        }
                    }
                    else
                    {
                        if (arr[i, j] != 'B')
                        {
                            tmp1++;
                        }
                        else
                        {
                            tmp2++;
                        }
                    }
                }

            }

            if (tmp1 < tmp2)
            {
                return tmp1;
            }
            else
            {
                return tmp2;
            }
        }
    }
}

