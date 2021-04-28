using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1017_home
{
    public class App
    {
        public App()
        {
            while (true)
            {
                var rand = new Random();
                int randomNumber = rand.Next(2);
                Console.WriteLine(randomNumber);

            }
        }
    }
}
