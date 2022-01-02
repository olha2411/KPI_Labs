using System;
using Lib8;
namespace Lab8cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olha Pavlushchenko, IS-02");
            LinkedList list = new LinkedList(7);            
            list.Add(4);
            list.Add(16);
            list.Add(6);
            list.Add(51);
            list.Add(97);
            Console.WriteLine("List:");
            foreach (short item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine($"The number of elments mltiply of 4: {list.CountMultiplesOfFour()}");
            list.ChangeToZero();
            Console.WriteLine();
            Console.WriteLine("List:");
            foreach (short item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
