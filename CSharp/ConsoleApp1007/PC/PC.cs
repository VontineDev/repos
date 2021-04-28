using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC
{
    public class PC
    {
        //data
        //name
        //MemoryCard
        //SoundCard
        //MainBoard
        string name;
        MemoryCard memoryCard;
        SoundCard soundCard;
        MainBoard mainBoard;
        public PC(string name)
        {
            this.name = name;
        }
        //function
        //GetPCName
        //SetMemorycard
        //GetMemorycard
        //SetSoundCard
        //GetSoundCard
        //SetMainBoard
        //GetMainboard
        public string GetPCName()
        {
            return this.name;
        }
        public void SetMemorycard(MemoryCard memoryCard)
        {
            this.memoryCard = memoryCard;
        }
        public MemoryCard GetMemoryCard()
        {
            return this.memoryCard;
        }
        public void SetSoundCard(SoundCard soundCard)
        {
            this.soundCard = soundCard;
        }
        public SoundCard GetSoundCard()
        {
            return this.soundCard;
        }
        public void SetMainBoard(MainBoard mainBoard)
        {
            this.mainBoard = mainBoard;
        }
        public MainBoard GetMainboard()
        {
            return this.mainBoard;
        }


    }
}
