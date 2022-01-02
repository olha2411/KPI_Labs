using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLibrary
{
    public class Text
    {        
            private MyString[] text;
            private int num;
            public Text()                   //конструктор
        {
                text = null;
                num = 0;
            }

            public Text(MyString[] text, int num)           //конструктор
        {
                if (text != null)
                {
                    this.num = num;
                    this.text = new MyString[num];
                    for (int i = 0; i < num; i++)
                    {
                        this.text[i] = text[i];

                    }
                }
                else
                {
                    this.text = null;
                    this.num = 0;
                }
            }

            public Text(Text other)         //копіювання
        {
                num = other.num;
                if (num > 0)
                {
                    text = new MyString[num];
                    for (int i = 0; i < num; i++)
                        text[i] = other.text[i];
                }
                else
                {
                    text = null;
                }
            }

            public MyString this[int index]
            {
                get
                {
                    return text[index];
                }
                set
                {
                    text[index] = value;
                }
            }

            public void Add_Row(in MyString s)
            {
                if (num > 0)
                {
                    num++;                                      //збільшення розміру масива рядків
                MyString[] text1 = new MyString[num];       //створення масиву на 1 елемент більший за розмір 
                for (int i = 0; i < (num - 1); i++)
                    {
                        text1[i] = text[i];             //копіюєм елементи з початкового масиву в новостворений
                }
                    text1[num - 1] = s;     //останньому елементу присвоюєм новий рядок

                text = new MyString[num];           //створюєм новий масив рядків
                for (int i = 0; i < num; i++)
                    {
                        text[i] = text1[i];         //копіюєм з тимчасового масиву елементи
                }
                }
                else
                {
                    num++;
                    text = new MyString[num];
                    text[0] = s;
                }

            }
            public void Delete_row(int num_to_delete)           //видалення рядка
        {

                for (int i = num_to_delete - 1; i < num - 1; i++)       //копіювання елементів крім рядка, що потрібно видалити
            {
                    text[i] = text[i + 1];
                }
                MyString[] text1 = new MyString[num - 1];       //створення масиву розміром на 1 менше
            for (int i = 0; i < num - 1; i++)
                {
                    text1[i] = text[i];         //копіювання елементів з попереднього масиву в тимчасовий      
        }
                num--;          //зменшення розміру масива рядків
            text = new MyString[num];
                for (int i = 0; i < num; i++)
                {
                    text[i] = text1[i];
                }

            }
            public char[] FirtstSymbols()                   //створення рядка з перших символів всіх рядків тексту
        {
                char[] first = new char[num];
                for (int i = 0; i < num; i++)
                {
                    first[i] = text[i].FindFirsrsSymbol();
                }
                return first;
            }
            public void RowFirtstSymbol()
            {
                char[] first = FirtstSymbols();
                for (int i = 0; i < num; i++)
                {
                    Console.Write(first[i]);
                }
            }

            public MyString Find_min_row()              //знаходження найменшого рядка
        {
                MyString temp = text[0];
                for (int i = 0; i < num - 1; i++)
                {
                    if (temp.Find_length() > text[i + 1].Find_length())
                    {
                        temp = text[i + 1];
                    }
                }
                temp.Print_row();
                return temp;
            }

            public double Text_length()                     //визначення довжини тексту
        {
                double length = 0;
                for (int i = 0; i < num; i++)
                {
                    length += text[i].Find_length();

                }
                return length;
            }

            public double Symbol_frequency(char s)                  //визначення кількості певних символів в тексті
        {
                double count = 0;
                for (int i = 0; i < num; i++)
                {
                    for (int j = 0; j < text[i].Find_length(); j++)
                    {
                        if (text[i][j] == s)
                        {
                            count++;
                        }
                    }
                }
                return count;
            }

            public void Print_Text()
            {
                if (text != null)
                {
                    for (int i = 0; i < num; i++)
                    {
                        text[i].Print_row();
                        //Console.Write('\n');
                    }
                }
                else
                {
                    Console.WriteLine("You deleted your text");
                }
            }
            public void Clear()             //очищення тексту
        {
                text = null;
            }
    }
}


