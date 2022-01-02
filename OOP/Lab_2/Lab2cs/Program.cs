using System;
using LabLibrary;
namespace Lab2cs
{
    class Program
    {
        static char[] Change(string str1, char[] Arr)
        {
            for (int i = 0; i < str1.Length; i++)
            {
                Arr[i] = str1[i];
            }
            Arr[str1.Length] = '\0';
            return Arr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Olha Pavlushchenko, IS-02 ");
            Text text = new Text();            
            int number = 0;
            while (number <= 0)
            {
                Console.Write("Enter the number of rows: ");  //введення рядка
                number = int.Parse(Console.ReadLine());
            }
            string str1;
            Console.WriteLine("Enter text: ");
            for (int i = 0; i < number; i++)
            {
                str1 = Console.ReadLine();              //перетворення в масив чарів
                char[] B = new char[str1.Length + 1];
                B = Change(str1, B);
                MyString str3 = new MyString(B);
                text.Add_Row(in str3);              //додати рядок до тексту

            }
            Console.WriteLine();
            Console.WriteLine("Your text: ");           
            text.Print_Text();                      //виведення тексту
            Console.WriteLine();
            Console.WriteLine("Enter the row to add: ");            
            string str2;
            str2 = Console.ReadLine();
            char[] Arr = new char[str2.Length + 1];
            Arr = Change(str2, Arr);
            MyString str = new MyString(Arr); ;
            text.Add_Row(str);                      //додавання рядка
            Console.WriteLine();
            text.Print_Text();
            Console.WriteLine('\n');
            int num;
            Console.WriteLine("Enter the number of row to delete:");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            text.Delete_row(num);               //видалення рядка
            text.Print_Text();
            Console.WriteLine('\n');
            Console.WriteLine("The row of first symbols: ");
            text.RowFirtstSymbol();             // виведення рядка перших символів тексту
            Console.WriteLine();
            Console.Write("The shortest row is:");
            text.Find_min_row();                //знаходження найменшого рядка
            Console.WriteLine('\n');            
            Console.Write("Enter the symbol to check it's quantity:");
            char s;
            s = char.Parse(Console.ReadLine());
            double f = text.Symbol_frequency(s) / text.Text_length();       //частота символа
            Console.WriteLine($" {f * 100}%");          
            text.Clear();
            Console.WriteLine('\n');
            text.Print_Text();

        }
    }
}
