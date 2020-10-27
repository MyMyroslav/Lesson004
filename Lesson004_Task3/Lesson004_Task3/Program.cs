using System;

namespace Lesson003_Task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(" Рідке,а не вода, біле а не сніг.");
            string answer = "Milk";
            Console.WriteLine("Відповідь:");
            string intext = Console.ReadLine();

            if (intext == answer || intext == answer.ToLower() || intext == answer.ToUpper() || intext == "mIlK"
                || intext == "MiLk" || intext == "MIlk" || intext == "miLK" || intext == "mILK" || intext == "MILk")
            {
                Console.WriteLine("Правильно!");
            }
            else
            {
                Console.WriteLine("Неправильно!");
            }
        }
    }
}
