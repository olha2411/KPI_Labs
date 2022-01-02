using System;
using RowsLibrary;

namespace Lab_6cs
{    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olha Pavlushchenko, IS-02, Lab-6");
            string a = "t#ttr#rtr";                                     //row
            string b = "370256167398";                                  //row
            Rows row1 = new Symbols(a);
            Console.WriteLine($"Length: {row1.RowLength()}");           //lenght of row
            Console.WriteLine($"Replaced: {row1.ChangeSymbol()}");      //repalace symbols
            Rows row2 = new Numbers(b);
            Console.WriteLine($"Length: {row2.RowLength()}");           //lenght of row
            Console.WriteLine($"Replaced: {row2.ChangeSymbol()}");      //repalace symbols

        }
    }
}
