using System;
using Lab7_Lib;
namespace Lab7cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olha Pavlushchenko, IS-02,");
            Console.Write("Enter the number of elements in array: ");                            
            int num = int.Parse(Console.ReadLine());                                            //number of objects
            ArithmeticExpression[] array = new ArithmeticExpression[num];                       //array of obgects
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"{i + 1} array:");
                Console.Write("Enter a:");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter b:");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Enter c:");
                double c = double.Parse(Console.ReadLine());
                Console.Write("Enter d:");
                double d = double.Parse(Console.ReadLine());
                array[i] = new ArithmeticExpression(a, b, c, d);
                Console.WriteLine();
                
            }
            for (int i = 0; i < num; i++)
            {
                try
                {
                    array[i].ExpressionValue();
                    Console.WriteLine(array[i].GetResult());
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Error:" + e.Message);
                }
            }            
           
        }
    }
}
