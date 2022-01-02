#pragma once
#include <iostream>
#include <string>

class MyStrings
{
private:
    int length;

public:
    std::string row;
    MyStrings();
    MyStrings(std::string row1);
    MyStrings(MyStrings& Copy);
    std::string GetRow();
    MyStrings operator +(MyStrings row1);
    int GetLength();
    MyStrings operator / (int num);
    ~MyStrings();
};