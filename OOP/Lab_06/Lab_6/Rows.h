#pragma once
#include <iostream>

class Rows
{
public:
    char* row;
    int length;

    Rows(char* row); 
    virtual int RowLength() = 0;
    virtual char* ChangeSymbol() = 0;
};