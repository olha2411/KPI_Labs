using System;
using System.Collections.Generic;
using Lib9;

namespace Lab9cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olha Pavlushchenko, IS-02");
            Queue queue = new Queue();
            queue.Notify += DisplayMessage;
            queue.Enqueue('3');
            queue.Enqueue('b');
            queue.Enqueue('f');
            queue.Enqueue('5');
            queue.Enqueue('k');            
            queue.Print();
            Console.WriteLine();
            queue.Enqueue('u');
            Console.WriteLine("'u' is added" );
            queue.Print();
            Console.WriteLine();
            if (queue.ContainLetters() == true)
            {
                Console.WriteLine($"The row contains { queue.LetterNumber()} letters");
            }
            else
            {
                Console.WriteLine($"There are no letters in the row");
            }
            queue.Clear();
            
        }
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
