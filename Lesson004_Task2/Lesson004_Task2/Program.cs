using System;

namespace Lesson004_Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter time in monthes:");
            string time = Console.ReadLine();
            int time2 = int.Parse(time);
            if (time2 <= 3)
            {
                Console.WriteLine("Trainee");
            }
            if (time2 > 3 && time2 <= 6)
            {
                Console.WriteLine("Low Junior");
            }
            if (time2 > 6 && time2 <= 12)
            {
                Console.WriteLine("Junior");
            }
            if (time2 >12 && time2 <= 18)
            {
                Console.WriteLine("Strong Junior");
            }
            if (time2 > 18 && time2 <= 24)
            {
                Console.WriteLine("Low Middle");
            }
            if (time2 > 24 && time2 <= 36)
            {
                Console.WriteLine("Middle");
            }
            if (time2 > 36 && time2 <= 48)
            {
                Console.WriteLine("Strong Middle");
            }
            if (time2 > 48 && time2 <= 60)
            {
                Console.WriteLine("Low Senior");
            }
            if (time2 > 60 && time2 <= 72)
            {
                Console.WriteLine("Senior");
            }
            if(time2 > 72 && time2 <= 96)
            {
                Console.WriteLine("Strong Senior");
            }
            if (time2 > 96)
            {
                Console.WriteLine("Proffesional");
            }
            
        }
    }
}
