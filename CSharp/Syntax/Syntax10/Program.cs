using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax10
{

    class Program
    {

        static void Main(string[] args)

        {
            string[] stuListTemp = new string[6];
            string[,] stuList2D = new string[10, 6];
            int index = 0;
            for (; ; )
            {
                Console.WriteLine("1. 조회");
                Console.WriteLine("2. 추가");
                Console.WriteLine("3. 수정");
                Console.WriteLine("4. 삭제");
                Console.WriteLine("5. 종료");
                string selectMenu = Console.ReadLine();
                if (selectMenu == "1")
                {
                    Console.WriteLine($"Total Student: {index}");
                    Console.WriteLine();
                    Console.WriteLine("+----+----------------+------+------+------+------+");
                    Console.WriteLine("|번호|     학생명     | 국어 | 수학 | 영어 | 평균 |");
                    Console.WriteLine("+----+----------------+------+------+------+------+");
                    for (int i = 0; i < index ; i++)
                    {
                        Console.WriteLine($"|{stuList2D[i, 0]}|{stuList2D[i, 1],6}|{stuList2D[i, 2]}|");
                    }
                    Console.WriteLine($"Index의 값: {index}");

                }
                else if (selectMenu == "2")
                {
                    for (; ; )
                    {
                        stuListTemp[0] = "000" + (index + 1);
                        Console.Write("학생명: ");
                        stuListTemp[1] = Console.ReadLine();
                        if (stuListTemp[1]==null)
                        {
                            Console.WriteLine("비어있는 데이터는 저장할 수 없습니다.");
                            continue;
                        }
                        Console.Write("국어: ");
                        stuListTemp[2] = Console.ReadLine();
                       // if(int.Parse(stuListTemp[2]) < 0 || int.Parse(stuListTemp[2])>100 || int.Parse(stuListTemp[2]) == ArgumentException)

                        
                        Console.Write("저장하시겠습니까? (예:1 / 아니오:0) :)");
                        int addStatus = Int32.Parse(Console.ReadLine());

                        if (addStatus == 1)
                        {
                            stuList2D[index, 0] = stuListTemp[0];
                            stuList2D[index, 1] = stuListTemp[1];
                            stuList2D[index, 2] = stuListTemp[2];
                            index++;
                            break;
                        }
                        else
                            continue;
                    }
                }
                else if (selectMenu == "3")
                {
                    //조회가 나오고                    
                    Console.Write($"수정할 데이터 번호를 입력하세요(1~{index}) [0 : Exit]:");
                    int modifyNum = Int32.Parse(Console.ReadLine());
                    Console.Write($"[기존 학생명: {stuList2D[modifyNum-1, 1]} >>");
                    stuList2D[modifyNum - 1, 1] = Console.ReadLine();
                    Console.Write($"[기존 국어점수: {stuList2D[modifyNum - 1, 2]} >>");
                    stuList2D[modifyNum - 1, 2] = Console.ReadLine();

                    continue;

                }
                else if (selectMenu == "4")
                {
                    //조회가 나오고
                    if (index == 0)
                    {
                        Console.WriteLine("저장된 데이터가 없습니다.");
                    }
                    else
                    {
                        Console.Write($"삭제할 데이터 번호를 입력하세요(1~{index}) [0 : Exit]:");
                        int deleteNum = Int32.Parse(Console.ReadLine());

                        for (int i = deleteNum; i < index; i++)
                        {
                            stuList2D[i - 1, 1] = stuList2D[i, 1]; //삭제할 번호의 자리에 다음번호의 내용을 넣는다.
                            stuList2D[i - 1, 2] = stuList2D[i, 2];
                        }
                        stuList2D[index - 1, 0] = null; //제일 마지막 데이터를 null로 바꾼다.
                        stuList2D[index - 1, 1] = null;
                        stuList2D[index - 1, 2] = null;
                        index--; //index의 값을 하나 내린다.
                    }
                }
                //else
                //{
                //    break;
                //}  
            }
        }
    }
}