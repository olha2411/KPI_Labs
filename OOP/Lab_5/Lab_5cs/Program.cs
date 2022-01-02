using System;
using Lab5_Libray;

namespace Lab_5cs
{
  class Program
  {
            static void Main(string[] args)
            {
            Console.WriteLine("Olha pavlushchenko, IS-02");
            Console.WriteLine("Enter the coordinates:");
                int x1, y1, x2, y2, x3, y3, x4, y4;                     //координати                
            Console.Write("x1:");
                x1 = int.Parse(Console.ReadLine());
                Console.Write("y1:");
                y1 = int.Parse(Console.ReadLine());
                Console.Write("x2:");
                x2 = int.Parse(Console.ReadLine());
                Console.Write("y2:");
                y2 = int.Parse(Console.ReadLine());
                Console.Write("x3:");
                x3 = int.Parse(Console.ReadLine());
                Console.Write("y3:");
                y3 = int.Parse(Console.ReadLine());
                Console.Write("x4:");
                x4 = int.Parse(Console.ReadLine());
                Console.Write("y4:");
                y4 = int.Parse(Console.ReadLine());
                Rectangle rectangle = new Rectangle(x1, y1, x2, y2, x3, y3, x4, y4);        //створення обєкту

            Console.WriteLine($"Perimetr: {rectangle.GetPerimetr()}");                                     //виведення периметру
            Console.WriteLine($"Square: {rectangle.GetSquare()}");                                           //виведення площі
        }
    }
}
