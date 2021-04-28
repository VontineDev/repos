using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class App
    {
        //4x4크기의 게임판 생성
        int[,] gameBoard = new int[4, 4];
        int score = 0;
        int highestScore;
        int row;
        int column;
        public App()
        {
            GetInitialData();
            DisplayGameBoard();
            for (; ; )
            {
                ConsoleKeyInfo input = Console.ReadKey();
                Console.WriteLine();
                Move(input);
            }

        }

        public int[,] GetInitialData() // 게임판의 초기값을 구하는 메소드.
        {
            Random random = new Random();
            int row1 = random.Next(0, 4);
            int row2 = random.Next(0, 4);
            int column1 = random.Next(0, 4);
            int column2 = random.Next(0, 4);

            while (true)
            {
                if (row1 != row2 || column1 != column2)
                {
                    int value1 = gameBoard[row1, column1] = random.Next(2, 5);
                    int value2 = gameBoard[row2, column2] = random.Next(2, 5);
                    if ((value1 == 2 || value1 == 4) && (value2 == 2 || value2 == 4))
                    {
                        return gameBoard;
                    }
                }
            }
        }
        public void Move(ConsoleKeyInfo input)
        {
            switch (input.Key)
            {
                case ConsoleKey.UpArrow:
                    {
                        for (int i = 0; i < 4; i++) //이동시킬(값이 0이 아닌) 타일의 인덱스 구하기
                        {
                            for (int j = 0; j < 4; j++)
                           {
                                if (gameBoard[i, j] != 0)
                                {
                                    row = i;
                                    column = j;
                                    while (CheckTile(input)) //값이 0이아닌 타일이 다음칸으로 이동 가능한지 여부 찾기
                                    {
                                        if (gameBoard[row - 1, column] == 0)
                                        {
                                            gameBoard[row - 1, column] = gameBoard[row, column];
                                            gameBoard[row, column] = 0;
                                            row--;
                                            Console.WriteLine();
                                        }
                                        else
                                        {
                                            gameBoard[row - 1, column] += gameBoard[row, column];
                                            GetScore(gameBoard[row - 1, column]);
                                            gameBoard[row, column] = 0;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        Console.WriteLine(this.score);
                        CreateNewValuedIndex();
                        DisplayGameBoard();
                        break;
                    }

                case ConsoleKey.DownArrow:
                    {
                        for (int i = 3; i > -1; i--)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if (gameBoard[i, j] != 0)
                                {
                                    row = i;
                                    column = j;
                                    while (CheckTile(input))
                                    {
                                        if (gameBoard[row + 1, column] == 0)
                                        {
                                            gameBoard[row + 1, column] = gameBoard[row, column];
                                            gameBoard[row, column] = 0;
                                            row++;
                                        }
                                        else
                                        {
                                            gameBoard[row + 1, column] += gameBoard[row, column];
                                            GetScore(gameBoard[row + 1, column]);
                                            gameBoard[row, column] = 0;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        Console.WriteLine(this.score);
                        CreateNewValuedIndex();
                        DisplayGameBoard();
                        break;
                    }

                case ConsoleKey.LeftArrow:
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if (gameBoard[i, j] != 0)
                                {
                                    row = i;
                                    column = j;
                                }
                                while (CheckTile(input))
                                {
                                    {
                                        if (gameBoard[row, column - 1] == 0)
                                        {
                                            gameBoard[row, column - 1] = gameBoard[row, column];
                                            gameBoard[row, column] = 0;
                                            column++;
                                        }
                                        else
                                        {
                                            gameBoard[row, column - 1] += gameBoard[row, column];
                                            GetScore(gameBoard[row, column - 1]);
                                            gameBoard[row, column] = 0;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        Console.WriteLine(this.score);
                        CreateNewValuedIndex();
                        DisplayGameBoard();
                        break;
                    }
                case ConsoleKey.RightArrow:
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 3; j > -1; j--)
                            {
                                if (gameBoard[i, j] != 0)
                                {
                                    row = i;
                                    column = j;
                                }
                                while (CheckTile(input))
                                {
                                    if (gameBoard[row, column + 1] == 0)
                                    {
                                        gameBoard[row, column + 1] = gameBoard[row, column];
                                        gameBoard[row, column] = 0;
                                        column--;
                                    }
                                    else
                                    {
                                        gameBoard[row, column + 1] += gameBoard[row, column];
                                        gameBoard[row, column] = 0;
                                        break;
                                    }
                                }
                            }
                        }
                        Console.WriteLine(this.score);
                        CreateNewValuedIndex();
                        DisplayGameBoard();
                        break;
                    }
            }
        }

        public bool CheckTile(ConsoleKeyInfo input)
        {
            //만약 이동할 경로의 타일의 값이 0이거나 이동할 타일의 값과 같다면 return true, 아니면 return false
            switch (input.Key)
            {
                case ConsoleKey.UpArrow:
                    {
                        if (row - 1 >= 0)
                        {
                            if (gameBoard[row - 1, column] == 0 || gameBoard[row - 1, column] == gameBoard[row, column])
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                case ConsoleKey.DownArrow:
                    {
                        if (row + 1 <= 3)
                        {
                            if (gameBoard[row + 1, column] == 0 || gameBoard[row + 1, column] == gameBoard[row, column])
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                case ConsoleKey.LeftArrow:
                    {
                        if (column - 1 >= 0)
                        {
                            if (gameBoard[row, column - 1] == 0 || gameBoard[row, column - 1] == gameBoard[row, column])
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                case ConsoleKey.RightArrow:
                    {
                        if (column + 1 <= 3)
                        {
                            if (gameBoard[row, column + 1] == 0 || gameBoard[row, column + 1] == gameBoard[row, column])
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                default:
                    {
                        return false;
                    }
            }
        }

        public int[,] CreateNewValuedIndex()
        {
            Random random = new Random();
            int row = random.Next(0, 4);
            int column = random.Next(0, 4);
            for (; ; )
            {
                if (gameBoard[row, column] == 0)
                {
                    int value = random.Next(1, 100);
                    if (value < 50)
                    {
                        gameBoard[row, column] = 2;
                        return gameBoard;
                    }
                    else
                    {
                        gameBoard[row, column] = 4;
                        return gameBoard;
                    }
                }
            }
        }

        //public bool CheckValidIndexToMove()
        //{
        //    //더이상 Move할수있는 타일이 없는경우 "GameOver"가 출력되고 프로그램이 종료된다.
        //}

        public int GetScore(int score)
        {
            this.score += score;
            return this.score;
        }

        public void DisplayGameBoard()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(gameBoard[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}