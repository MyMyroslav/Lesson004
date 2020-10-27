using System;

namespace Lesson004_Task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = 2, y = 4, z = 3;
            x+=y >> x - 1;
            Console.WriteLine($"X = {x}");
            x = 2; y = 4; z = 3;
            z = --x & y * 3;
            Console.WriteLine($"Z = {z}");
            x = 2; y = 4; z = 3;
            y *= x + 4 | z + 2;
            Console.WriteLine($"Y = {y}");
            x = 2; y = 4; z = 3;
            z = x++ & y * 2;
            Console.WriteLine($"Z = {z}");
             x = 2; y = 4; z = 3;
            x = y << x++ ^ z;
            Console.WriteLine($"X = {x}");
            x = 2; y = 4; z = 3;
            z = x -- &y * 2 | z;
            Console.WriteLine($"Z = {z}");
            x = 2; y = 4; z = 3;
            x = y << ++x ^ z;
            Console.WriteLine($"X = {x}");

        }
    }
}
