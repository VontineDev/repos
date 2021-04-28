using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC
{
    public class App
    {
        public App()
        {
            var pC1 = new PC("PBGA_01");
            var mainBoard1 = new MainBoard("MSI A320M-A PRO");
            var memoryCard1 = new MemoryCard("Samsung 8GB PC4-21300");
            var soundCard1 = new SoundCard("Internal SoundCard");

            Console.WriteLine($"조립 컴퓨터 {pC1.GetPCName()}을 생성했습니다.");

            pC1.SetMainBoard(mainBoard1);
            Console.WriteLine($"{mainBoard1.GetMainBoardName()}");
            pC1.SetMemorycard(memoryCard1);
            Console.WriteLine($"{memoryCard1.GetMemoryCardName()}");
            pC1.SetSoundCard(soundCard1);
            Console.WriteLine($"{soundCard1.GetSoundCardName()}");

        }
    }
}
