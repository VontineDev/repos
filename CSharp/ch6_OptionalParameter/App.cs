using System;
using System.Collections.Generic;
using System.Text;

namespace ch6_OptionalParameter
{
    class App
    {
        void PrintProfiles(string name, string phone = "")
        {
            Console.WriteLine($"Name: {name}, Phone: {phone}");
        }

        public App()
        {
            PrintProfiles("태연");
            PrintProfiles("윤아", "010-123-1234");
            PrintProfiles(name: "유리");
            PrintProfiles(name: "서현", phone: "010-789-7890");
        }
    }
}
