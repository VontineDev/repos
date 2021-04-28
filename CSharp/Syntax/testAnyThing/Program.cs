using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAnyThing
{
    class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            //string unicodeString = "This string contains the unicode character Pi (\u03a0)";


            //byte[] unicodeBytes = unicode.GetBytes(unicodeString);

            string[] droppedItemArr = { "장검", "단검", "물약", "가죽옷" };


            for (int i = 0; i < droppedItemArr.Length; i++)
            {
               
                if ("장검" == droppedItemArr[i])
                {
                    for (int j = i; j < droppedItemArr.Length-1; j++)
                    {
                        if(j==droppedItemArr.Length)
                        {
                            break;
                        }
                        droppedItemArr[j] = droppedItemArr[j + 1];
                    }
                    droppedItemArr[droppedItemArr.Length - 1] = "";                    
                }
            }
            //foreach (string ar in droppedItemArr)
            //    Console.WriteLine(ar);

        }
    }
}
