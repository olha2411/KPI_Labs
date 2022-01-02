using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Library
{
    public class MyStrings
    {
        public string row;
        int length;

        public MyStrings()
        {                                                           //конструктор за замовчуванням

        }
        public MyStrings(string row1)                                       //конструктор з параметрами
        {
            this.row = row1;

        }
        public MyStrings(MyStrings Copy)                                       //конструктор копіювання 
        {
            this.row = Copy.row;
        }
        public string GetRow()                                              //отримання значення рядка
        {
            return this.row;
        }
        public static MyStrings operator +(MyStrings row1, MyStrings row2)  //перевантаження оператора додавання
        {
            MyStrings result = new MyStrings();
            result.row = row1.row + row2.row;
            return result;
        }
        public int GetLength()                                              //отримання довжини рядка
        {
            length = row.Length;
            return length;
        }
        public static MyStrings operator /(MyStrings row1, int num)         //перевантаження оператора ділення 
        {

            MyStrings result = new MyStrings();
            for (int i = 0; i < row1.GetLength(); i++)
            {
                if (i % 2 != 0)
                {
                    result.row += row1.row[i];
                }
            }
            return result;
        }
    }
}
