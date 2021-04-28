using System;
using Syntax24;

namespace Syntax24
{
    class App
    {
        string droppedItem = "장검, 단검, 체력물약, 가죽옷";
        string pickitem = "";
        string inven = "";
        int count = 0;
        public App()
        {

            Console.WriteLine("2019-09-30");
            Console.WriteLine();



            while (true)
            {

                PickItem();
                Console.WriteLine();
                Console.Write("소지품: ");
                Inventory();

            }

        }

        public void Inventory()
        {
            inven = inven + pickitem;
            Console.WriteLine(inven);
            inven = inven + ", ";
        }
        public void PickItem()
        {
            Console.WriteLine(droppedItem);
            Console.Write("가방에 넣을 아이템을 선택해주세요. ");
            pickitem = Console.ReadLine();
            if (pickitem == "장검")
            {
                droppedItem = droppedItem.Replace("장검, ", "");
                if (droppedItem == "장검")
                    droppedItem = "";
            }
            else if (pickitem == "단검")
            {
                droppedItem = droppedItem.Replace("단검, ", "");
                if (droppedItem == "단검")
                    droppedItem = "";
            }
            else if (pickitem == "체력물약")
            {
                droppedItem = droppedItem.Replace("체력물약, ", "");
                if (droppedItem == "체력물약")
                    droppedItem = "";

            }
            else if (pickitem == "가죽옷")
            {

                droppedItem = droppedItem.Replace(", 가죽옷", "");
                if (droppedItem == "가죽옷")
                    droppedItem = "";
            }
        }

    }
}