using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax49
{
    public class PC
    {
        //data
        //name
        //GraphicCard
        //CPU
        public string name;
        public GraphicCard graphicCard;
        public CPU cpu;
        public PC(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이(가) 생성되었습니다.");

        }
        //function
        //GetGraphicCard
        //GetCPU
        public void GetGraphicCard(string name)
        {
            var graphicCard = new GraphicCard(name, this);
            this.graphicCard = graphicCard;            
        }
        public void GetCPU(string name)
        {
            var cpu = new CPU(name, this);
            this.cpu = cpu;
        }

    }
}
