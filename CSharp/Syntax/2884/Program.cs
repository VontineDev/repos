using System;

namespace _2884
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            int hour = int.Parse(arr[0]);
            int minute = int.Parse(arr[1]);
            int time = (hour * 60) + minute;

            int alarmTime = time - 45;
            int alarmHour = alarmTime / 60;
            int alarmMinute = alarmTime % 60;
            if (alarmTime<0)
            {
                alarmHour = 23;
                alarmMinute = 60 + alarmTime;
            }
            Console.WriteLine($"{alarmHour} {alarmMinute}");
        }
    }
}
