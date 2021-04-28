using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax23
{
    class Program
    {
        enum camp { Alliance, Horde, None };
        enum race { Human, Dwarf, Orc, Undead, None };
        enum classes { Warlock, Priest, Monk, Hunter, DeathKnight, Warrior, Mage, Rogue, None };
       
        //enum camp { 얼라이언스, 호드 };
        //enum raceAlliance { 인간, 드워프 };
        //enum raceHorde { 오크, 언데드 };
        //enum humanClasses { 흑마법사, 사제 };
        //enum dwarfClasses { 수도사, 사냥꾼 };
        //enum orcClasses { 죽음의기사, 전사 };
        //enum undeadClasses { 마법사, 도적 };

        static void Main(string[] args)
        {
            camp selectedCamp = camp.None;
            race selectedRace = race.None;
            classes selectedClass = classes.None;

            string strRace = null;
            string strClasses = null;
            Console.Write("[얼라이언스, 호드] 진영을 선택해 주세요. ");
            string strCamp = Console.ReadLine();
            switch(strCamp)
            {
                case "얼라이언스":
                    {
                        selectedCamp = camp.Alliance;
                        Console.Write("[인간, 드워프] 종족을 선택해주세요.");
                        strRace = Console.ReadLine();

                        switch(strRace)
                        {
                            case "인간":
                                {
                                    selectedRace = race.Human;

                                    Console.Write("[흑마법사, 사제] 종족을 선택해주세요.");
                                    strClasses = Console.ReadLine();
                                    switch(strClasses)
                                    {
                                        case "흑마법사":
                                            {
                                                selectedClass = classes.Warlock;
                                                break;
                                            }
                                        case "사제":
                                            {
                                                selectedClass = classes.Priest;
                                                break;
                                            }
                                    }
                                    break;
                                }

                            case "드워프":
                                {
                                    selectedRace = race.Dwarf;
                                    Console.Write("[수도사, 사냥꾼] 종족을 선택해주세요.");
                                    strRace = Console.ReadLine();
                                    switch (strClasses)
                                    {
                                        case "수도사":
                                            {
                                                selectedClass = classes.Monk;
                                                break;
                                            }
                                        case "사냥꾼":
                                            {
                                                selectedClass = classes.Hunter;
                                                break;
                                            }
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                case "호드":
                    {
                        selectedCamp = camp.Horde;
                        Console.Write("[오크, 언데드] 종족을 선택해주세요.");
                        strRace = Console.ReadLine();

                        switch (strRace)
                        {
                            case "오크":
                                {
                                    selectedRace = race.Orc;

                                    Console.Write("[죽음의기사, 전사] 종족을 선택해주세요.");
                                    strClasses = Console.ReadLine();
                                    switch (strClasses)
                                    {
                                        case "죽음의기사":
                                            {
                                                selectedClass = classes.DeathKnight;
                                                break;
                                            }
                                        case "전사":
                                            {
                                                selectedClass = classes.Warrior;
                                                break;
                                            }
                                    }
                                    break;
                                }

                            case "언데드":
                                {
                                    selectedRace = race.Undead;
                                    Console.Write("[마법사, 도적] 종족을 선택해주세요.");
                                    strRace = Console.ReadLine();
                                    switch (strClasses)
                                    {
                                        case "마법사":
                                            {
                                                selectedClass = classes.Mage;
                                                break;
                                            }
                                        case "도적":
                                            {
                                                selectedClass = classes.Rogue;
                                                break;
                                            }
                                    }
                                    break;
                                }
                        }
                        break;
                    }
            }
            Console.WriteLine($"{selectedCamp}, {selectedRace}, {selectedClass} 입니다.");
            }
        }
    }

    //static void Main(string[] args)
    //{
    //    Console.Write("[얼라이언스, 호드] 진영을 선택해 주세요. ");
    //    camp selectedCamp = (camp)Enum.Parse(typeof(camp), Console.ReadLine());
    //    switch (selectedCamp)
    //    {
    //        case camp.얼라이언스:
    //            {
    //                Console.Write("[인간, 드워프] 종족을 선택해 주세요. ");
    //                raceAlliance selectedRace = (raceAlliance)Enum.Parse(typeof(raceAlliance), Console.ReadLine());
    //                switch (selectedRace)
    //                {
    //                    case raceAlliance.인간:
    //                        {
    //                            Console.Write("[흑마법사, 사제] 직업을 선택해 주세요. ");
    //                            humanClasses selectedClass = (humanClasses)Enum.Parse(typeof(humanClasses), Console.ReadLine());
    //                            switch (selectedClass)
    //                            {
    //                                case humanClasses.흑마법사:
    //                                    {
    //                                        Console.WriteLine("얼라이언스, 인간, 흑마법사 입니다.");
    //                                        break;
    //                                    }
    //                                case humanClasses.사제:
    //                                    {
    //                                        Console.WriteLine("얼라이언스, 인간, 사제 입니다.");
    //                                        break;
    //                                    }
    //                            }
    //                            break;
    //                        }
    //                    case raceAlliance.드워프:
    //                        {
    //                            Console.Write("[수도사, 사냥꾼] 직업을 선택해 주세요. ");
    //                            dwarfClasses selectedClass = (dwarfClasses)Enum.Parse(typeof(dwarfClasses), Console.ReadLine());
    //                            switch (selectedClass)
    //                            {
    //                                case dwarfClasses.수도사:
    //                                    {
    //                                        Console.WriteLine("얼라이언스, 드워프, 수도사 입니다.");
    //                                        break;
    //                                    }
    //                                case dwarfClasses.사냥꾼:
    //                                    {
    //                                        Console.WriteLine("얼라이언스, 드워프, 사냥꾼 입니다.");
    //                                        break;
    //                                    }
    //                            }
    //                            break;
    //                        }
    //                }
    //                break;
    //            }

    //        case camp.호드:
    //            {
    //                {
    //                    Console.Write("[오크, 언데드] 종족을 선택해 주세요. ");
    //                    raceHorde selectedRace = (raceHorde)Enum.Parse(typeof(raceHorde), Console.ReadLine());
    //                    switch (selectedRace)
    //                    {
    //                        case raceHorde.오크:
    //                            {
    //                                Console.Write("[죽음의기사, 전사] 직업을 선택해 주세요. ");
    //                                orcClasses selectedClass = (orcClasses)Enum.Parse(typeof(orcClasses), Console.ReadLine());
    //                                switch (selectedClass)
    //                                {
    //                                    case orcClasses.죽음의기사:
    //                                        {
    //                                            Console.WriteLine("호드, 오크, 죽음의 기사 입니다.");
    //                                            break;
    //                                        }
    //                                    case orcClasses.전사:
    //                                        {
    //                                            Console.WriteLine("호드, 오크, 전사 입니다.");
    //                                            break;
    //                                        }
    //                                }
    //                                break;
    //                            }
    //                        case raceHorde.언데드:
    //                            {
    //                                Console.Write("[마법사, 도적] 직업을 선택해 주세요. ");
    //                                undeadClasses selectedClass = (undeadClasses)Enum.Parse(typeof(undeadClasses), Console.ReadLine());
    //                                switch (selectedClass)
    //                                {
    //                                    case undeadClasses.마법사:
    //                                        {
    //                                            Console.WriteLine("호드, 언데드, 마법사 입니다.");
    //                                            break;
    //                                        }
    //                                    case undeadClasses.도적:
    //                                        {
    //                                            Console.WriteLine("호드, 언데드, 도적 입니다.");
    //                                            break;
    //                                        }
    //                                }
    //                                break;
    //                            }
    //                    }
    //                    break;
    //                }
    //            }
    //    }
    //}


