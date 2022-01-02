#include "Head.h"

    MyStrings:: MyStrings()
    {                                                           //конструктор за замовчуванням
        row = "";
    }
    MyStrings:: MyStrings(std::string row1)                                       //конструктор з параметрами
    {
        this->row = row1;

    }
    MyStrings::MyStrings(MyStrings& Copy)                                       //конструктор копіювання 
    {
        this->row = Copy.row;
    }
    std::string MyStrings:: GetRow()                                              //отримання значення рядка
    {
        return this->row;
    }
    MyStrings MyStrings:: operator +(MyStrings row1)                //перевантаження оператора додавання
    {
        MyStrings result;
        result.row = this->row + row1.row;
        return result;
    }
    int MyStrings::GetLength()                                              //отримання довжини рядка
    {
        length = row.length();
        return length;
    }
    MyStrings MyStrings:: operator / (int num)         //перевантаження оператора ділення 
    {
        MyStrings result;
        for (int i = 0; i < row.length(); i++)
        {
            if (i % 2 != 0)
            {
                result.row += this->row[i];
            }
        }
        return result;
    }
    MyStrings::~MyStrings()
    {                                                           
        row = "";
    }
