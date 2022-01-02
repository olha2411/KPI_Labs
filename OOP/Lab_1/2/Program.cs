using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olha Pavlushchenko, IS - 02");
            int A;
            Console.Write("Enter the number for decreasing: ");
            A = Convert.ToInt32(Console.ReadLine());
            decrease(ref A);            
            int x, y;
            Console.Write("Enter your first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your second number: ");
            y = Convert.ToInt32(Console.ReadLine());
            funt_sum(x, y);
        }
        static void decrease(ref int num)   //зменшення числа на 1
    {
            int bit = 0;
            int i = 0;
            do
            {
                num = num ^ (1 << i);
                bit = num & (1 << i);
                i++;

            } while (bit != 0);
            Console.WriteLine($"Number is: {num}");
        }

        static int funt_sum(int x, int y)       //додавання двох чисел
    {
            int c;
            while (y != 0)
            {
                c = x & y;
                x = x ^ y;
                y = c << 1;
            }
            Console.WriteLine($"Sum is: {x}");
            return x;
        }

    }

