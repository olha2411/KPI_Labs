using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLibrary
{
    public class MyString
    {
        private char[] str;
        private int length;
        public MyString()
        {
            str = new char[1];
            length = 0;
        }
        public MyString(char[] str)
        {
            length = 0;
            if (str != null)
            {
                while (str[length] != '\0')
                {
                    length++;                           //довжина масива слів
                }
                this.str = new char[length + 1];
                for (int i = 0; i < length; i++)
                {
                    this.str[i] = str[i];
                }
                this.str[length] = '\0';
            }
            else
            {
                this.str = new char[1];
                this.str[0] = '\0';
            }
        }

        public MyString(in MyString other)
        {
            length = other.length;
            str = new char[length + 1];
            for (int i = 0; i < length; i++)
            {
                str[i] = other.str[i];
            }
            str[length] = '\0';

        }

        public char this[int index]
        {
            get
            {
                return str[index];
            }
            set
            {
                str[index] = value;
            }
        }
        public void Isequal(in MyString other)   //оператор присвоєння
        {
            length = other.length;      //копіювання довжини масива
            str = new char[length + 1];
            for (int i = 0; i < length; i++)
            {
                str[i] = other.str[i];          //присвоєння елементу масива іншому 

            }
            str[length] = '\0';

        }
        public char FindFirsrsSymbol()
        {
            char first = str[0];            //знаходження першого символу рядка
            return first;
        }
        public void Print_row()
        {
            Console.WriteLine(str);
        }

        public int Find_length()        //довжина рядка
        {
            return length;
        }
    }

}
