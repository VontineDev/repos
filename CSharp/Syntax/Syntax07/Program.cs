using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax07
{
    class Program
    {
        static void Main(string[] args)
        {
            int goldNow = 5000;
            int priceLongSword = 800;
            int priceShortSword = 550;
            int priceBow = 760;
            int priceAxe = 810;
            int countLongSword = 0;
            int countShortSword = 0;
            int countBow = 0;
            int countAxe = 0;
            int sellQuantity = 0;
            int buyQuantity = 0;
            int stockLongSword = 5;
            int stockShortSword = 8;
            int stockBow = 3;
            int stockAxe = 4;

            for (; ; )
            {


                Console.WriteLine("*** 상점 ***");
                Console.WriteLine("[장검, 단검, 활, 도끼]");
                Console.WriteLine("---------------------------");
                Console.WriteLine("1. 상품구매");
                Console.WriteLine("2. 상품판매");
                Console.WriteLine("3. 프로그램 종료");
                Console.Write("행동을 선택해주세요.(숫자를 입력하세요) ");
                string getChar = Console.ReadLine();
                if (getChar == "1")
                {
                    for(; ;  )
                    {
                        Console.WriteLine($"금화 : {goldNow}");
                        Console.WriteLine("---------------------------");
                        Console.WriteLine($"1. 장검 : 800 [{stockLongSword}]");
                        Console.WriteLine($"2. 단검 : 550 [{stockShortSword}]");
                        Console.WriteLine($"3. 활 :   760 [{stockBow}]");
                        Console.WriteLine($"4. 도끼 : 810 [{stockAxe}]");
                        Console.Write("상점에서 구입 하고자 하는 아이템을 입력해주세요. ");
                        string input = Console.ReadLine();

                        if (input == "장검")
                        {
                            Console.Write("수량을 입력해주세요.");
                            buyQuantity = Int32.Parse(Console.ReadLine());

                            if (buyQuantity > stockLongSword)
                            {
                                Console.Clear();
                                Console.WriteLine("재고가 부족합니다.");
                                Console.WriteLine();
                                continue;

                            }
                            else
                            {
                                int buyingPrice = buyQuantity * priceLongSword;

                                if (goldNow < priceLongSword)
                                {
                                    Console.Clear();
                                    Console.WriteLine("금화가 부족합니다.");
                                    Console.WriteLine();
                                    break;
                                }
                                else if (goldNow < buyingPrice)
                                {
                                    Console.Clear();
                                    Console.WriteLine("금화가 부족합니다.");
                                    Console.WriteLine();
                                    continue;
                                }
                                else
                                {
                                    Console.Clear();
                                    goldNow = goldNow - buyingPrice;
                                    countLongSword = countLongSword + buyQuantity;
                                    stockLongSword = stockLongSword - buyQuantity;
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine($"{input}을 구매했습니다.({-buyingPrice})");
                                    Console.WriteLine($"금화 : {goldNow}");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine("상품 목록");
                                    Console.WriteLine($"장검 x {countLongSword}");
                                    Console.WriteLine($"단검 x {countShortSword}");
                                    Console.WriteLine($"활 x {countBow}");
                                    Console.WriteLine($"도끼 x {countAxe}");
                                    Console.WriteLine();
                                    break;
                                }
                            }
                        }
                        if (input == "단검")
                        {
                            Console.Write("수량을 입력해주세요.");
                            buyQuantity = Int32.Parse(Console.ReadLine());

                            if (buyQuantity > stockShortSword)
                            {
                                Console.Clear();
                                Console.WriteLine("재고가 부족합니다.");
                                Console.WriteLine();
                                continue;

                            }
                            else
                            {
                                int buyingPrice = buyQuantity * priceShortSword;

                                if (goldNow < priceShortSword)
                                {
                                    Console.Clear();
                                    Console.WriteLine("금화가 부족합니다.");
                                    Console.WriteLine();
                                    break;
                                }
                                else if (goldNow < buyingPrice)
                                {
                                    Console.Clear();
                                    Console.WriteLine("금화가 부족합니다.");
                                    Console.WriteLine();
                                    continue;
                                }
                                else
                                {
                                    Console.Clear();
                                    goldNow = goldNow - buyingPrice;
                                    countShortSword = countShortSword + buyQuantity;
                                    stockShortSword = stockShortSword - buyQuantity;
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine($"{input}을 구매했습니다.({-buyingPrice})");
                                    Console.WriteLine($"금화 : {goldNow}");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine("상품 목록");
                                    Console.WriteLine($"장검 x {countLongSword}");
                                    Console.WriteLine($"단검 x {countShortSword}");
                                    Console.WriteLine($"활 x {countBow}");
                                    Console.WriteLine($"도끼 x {countAxe}");
                                    Console.WriteLine();
                                    break;
                                }
                            }
                        }
                        if (input == "활")
                        {
                            Console.Write("수량을 입력해주세요.");
                            buyQuantity = Int32.Parse(Console.ReadLine());

                            if (buyQuantity > stockBow)
                            {
                                Console.Clear();
                                Console.WriteLine("재고가 부족합니다.");
                                Console.WriteLine();
                                continue;

                            }
                            else
                            {
                                int buyingPrice = buyQuantity * priceBow;

                                if (goldNow < priceBow)
                                {
                                    Console.Clear();
                                    Console.WriteLine("금화가 부족합니다.");
                                    Console.WriteLine();
                                    break;
                                }
                                else if (goldNow < buyingPrice)
                                {
                                    Console.Clear();
                                    Console.WriteLine("금화가 부족합니다.");
                                    Console.WriteLine();
                                    continue;
                                }
                                else
                                {
                                    Console.Clear();
                                    goldNow = goldNow - buyingPrice;
                                    countBow = countBow + buyQuantity;
                                    stockBow = stockBow - buyQuantity;
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine($"{input}을 구매했습니다.({-buyingPrice})");
                                    Console.WriteLine($"금화 : {goldNow}");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine("상품 목록");
                                    Console.WriteLine($"장검 x {countLongSword}");
                                    Console.WriteLine($"단검 x {countShortSword}");
                                    Console.WriteLine($"활 x {countBow}");
                                    Console.WriteLine($"도끼 x {countAxe}");
                                    Console.WriteLine();
                                    break;
                                }
                            }
                        }
                        if (input == "도끼")
                        {
                            Console.Write("수량을 입력해주세요.");
                            buyQuantity = Int32.Parse(Console.ReadLine());

                            if (buyQuantity > stockAxe)
                            {
                                Console.Clear();
                                Console.WriteLine("재고가 부족합니다.");
                                Console.WriteLine();
                                continue;

                            }
                            else
                            {
                                int buyingPrice = buyQuantity * priceAxe;

                                if (goldNow < priceAxe)
                                {
                                    Console.Clear();
                                    Console.WriteLine("금화가 부족합니다.");
                                    Console.WriteLine();
                                    break;
                                }
                                else if (goldNow < buyingPrice)
                                {
                                    Console.Clear();
                                    Console.WriteLine("금화가 부족합니다.");
                                    Console.WriteLine();
                                    continue;
                                }
                                else
                                {
                                    Console.Clear();
                                    goldNow = goldNow - buyingPrice;
                                    countAxe = countAxe + buyQuantity;
                                    stockAxe = stockAxe - buyQuantity;
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine($"{input}을 구매했습니다.({-buyingPrice})");
                                    Console.WriteLine($"금화 : {goldNow}");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine("상품 목록");
                                    Console.WriteLine($"장검 x {countLongSword}");
                                    Console.WriteLine($"단검 x {countShortSword}");
                                    Console.WriteLine($"활 x {countBow}");
                                    Console.WriteLine($"도끼 x {countAxe}");
                                    Console.WriteLine();
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"해당상품 (\"{input}\")는 없습니다.");
                            Console.WriteLine();
                        }
                    }

                }
                else if (getChar == "2")
                {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine($"금화 : {goldNow}");
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("상품 목록");
                    Console.WriteLine("---------------------------");
                    Console.WriteLine($"장검 x {countLongSword}");
                    Console.WriteLine($"단검 x {countShortSword}");
                    Console.WriteLine($"활 x {countBow}");
                    Console.WriteLine($"도끼 x {countAxe}");
                    Console.WriteLine("---------------------------");

                    for (; ; )
                    {
                        Console.Write("판매할 아이템을 입력해주세요. ");
                        string input = Console.ReadLine();

                        if (countLongSword == 0 && countShortSword == 0 && countBow == 0 && countAxe == 0)
                        {
                            Console.WriteLine("판매할 상품이 없습니다.");
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            if (input == "장검")
                            {

                                Console.Write("판매 수량을 입력해주세요.");
                                sellQuantity = Int32.Parse(Console.ReadLine());
                                if (sellQuantity > countLongSword)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"{input} 수량이 부족합니다.");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine($"금화 : {goldNow}");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine("상품 목록");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine($"장검 x {countLongSword}");
                                    Console.WriteLine($"단검 x {countShortSword}");
                                    Console.WriteLine($"활 x {countBow}");
                                    Console.WriteLine($"도끼 x {countAxe}");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine();
                                    continue;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine($"{input} x {sellQuantity}를 판매했습니다.");
                                    goldNow = goldNow + priceLongSword * sellQuantity;
                                    countLongSword = countLongSword - sellQuantity;
                                    stockLongSword = stockLongSword + sellQuantity;

                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine($"금화 : {goldNow}");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine("상품 목록");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine($"장검 x {countLongSword}");
                                    Console.WriteLine($"단검 x {countShortSword}");
                                    Console.WriteLine($"활 x {countBow}");
                                    Console.WriteLine($"도끼 x {countAxe}");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine();
                                    break;
                                    
                                }


                            }
                            else if (input == "단검")
                            {
                                Console.Write("판매 수량을 입력해주세요.");
                                sellQuantity = Int32.Parse(Console.ReadLine());
                                if (sellQuantity > countShortSword)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"{input} 수량이 부족합니다.");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine($"금화 : {goldNow}");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine("상품 목록");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine($"장검 x {countLongSword}");
                                    Console.WriteLine($"단검 x {countShortSword}");
                                    Console.WriteLine($"활 x {countBow}");
                                    Console.WriteLine($"도끼 x {countAxe}");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine();
                                    continue;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine($"{input} x {sellQuantity}를 판매했습니다.");
                                    goldNow = goldNow + priceShortSword * sellQuantity;
                                    countShortSword = countShortSword - sellQuantity;
                                    stockShortSword = stockShortSword + sellQuantity;
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine($"금화 : {goldNow}");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine("상품 목록");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine($"장검 x {countLongSword}");
                                    Console.WriteLine($"단검 x {countShortSword}");
                                    Console.WriteLine($"활 x {countBow}");
                                    Console.WriteLine($"도끼 x {countAxe}");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine();
                                    break;
                                }
                            }
                            else if (input == "활")
                            {
                                Console.Write("판매 수량을 입력해주세요.");
                                sellQuantity = Int32.Parse(Console.ReadLine());
                                if (sellQuantity > countBow)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"{input} 수량이 부족합니다.");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine($"금화 : {goldNow}");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine("상품 목록");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine($"장검 x {countLongSword}");
                                    Console.WriteLine($"단검 x {countShortSword}");
                                    Console.WriteLine($"활 x {countBow}");
                                    Console.WriteLine($"도끼 x {countAxe}");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine();
                                    continue;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine($"{input} x {sellQuantity}를 판매했습니다.");
                                    goldNow = goldNow + priceBow * sellQuantity;
                                    countBow = countBow - sellQuantity;
                                    stockBow = stockBow + sellQuantity;
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine($"금화 : {goldNow}");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine("상품 목록");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine($"장검 x {countLongSword}");
                                    Console.WriteLine($"단검 x {countShortSword}");
                                    Console.WriteLine($"활 x {countBow}");
                                    Console.WriteLine($"도끼 x {countAxe}");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine();
                                    break;
                                }
                            }
                            else if (input == "도끼")
                            {
                                Console.Write("판매 수량을 입력해주세요.");
                                sellQuantity = Int32.Parse(Console.ReadLine());
                                if (sellQuantity > countAxe)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"{input} 수량이 부족합니다.");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine($"금화 : {goldNow}");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine("상품 목록");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine($"장검 x {countLongSword}");
                                    Console.WriteLine($"단검 x {countShortSword}");
                                    Console.WriteLine($"활 x {countBow}");
                                    Console.WriteLine($"도끼 x {countAxe}");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine();
                                    continue;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine($"{input} x {sellQuantity}를 판매했습니다.");
                                    goldNow = goldNow + priceAxe * sellQuantity;
                                    countAxe = countAxe - sellQuantity;
                                    stockAxe = stockAxe + sellQuantity;
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine($"금화 : {goldNow}");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine("상품 목록");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine($"장검 x {countLongSword}");
                                    Console.WriteLine($"단검 x {countShortSword}");
                                    Console.WriteLine($"활 x {countBow}");
                                    Console.WriteLine($"도끼 x {countAxe}");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine();
                                    break;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine($"해당상품 (\"{input}\")는 를 찾을 수 없습니다.");
                                Console.WriteLine();

                            }

                        }

                    }

                }
                else if (getChar == "3")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("키 입력이 잘못되었습니다.");
                }
            }

        }
    }
}
