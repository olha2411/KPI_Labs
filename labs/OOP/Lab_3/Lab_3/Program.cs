using System;
using Lab3_Library;
namespace Lab_3
{   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olha Pavlushchenko, IS-02");
            Console.Write("Enter the rows number: ");  
            int rows = int.Parse(Console.ReadLine());       //кількість рядків масиву
            Console.Write("Enter the colums number: ");
            int cols = int.Parse(Console.ReadLine());       //кількість стовпців масиву
            
            TwoDimensionalArray arr = new TwoDimensionalArray(rows, cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter the element {i + 1},{j + 1} : ");
                    arr[i, j] = int.Parse(Console.ReadLine());              //введення елементів масиву
                }
            }
            Console.WriteLine();
            Console.WriteLine("Your array: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{arr[i, j]}  ");
                }
                Console.WriteLine();
            }
            Console.Write("Enter the number of row: ");
            int k = int.Parse(Console.ReadLine()); 
            if (k > rows)
            {
                Console.WriteLine("Your number is out of possible");
                Console.Write("Enter another number: ");
                k = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The average value is: {arr[k-1]}");             //середнє арифметичне значень заданого рядка
            Console.WriteLine($"The multiplying result is: { arr.Product}");   //добуток значень усіх елементів

        }
        
    }
}

