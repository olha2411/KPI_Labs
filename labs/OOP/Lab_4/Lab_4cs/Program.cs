using System;
using Lab4_Library;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olha Pavlushchenko, IS-02 ");
            Console.Write("Enter your row: ");
            string user_row;
            user_row = Console.ReadLine();
            MyStrings R1 = new MyStrings();                     //об'єкт, створений конструктором за умовчанням
            MyStrings R2 = new MyStrings(user_row);             //об'єкт, створений конструктором з параметрами
            MyStrings R3 = new MyStrings(R2);                   //об'єкт, створений конструктором копіювання
            R2 = R2 / 2;                                        //видалення символів на парній позиції
            Console.WriteLine($"R2: {R2.GetRow()}");
            R1 = R2 + R3;                                       //скаладання об'єктів
            Console.WriteLine($"R1: {R1.GetRow()}");

        }
    }
}
