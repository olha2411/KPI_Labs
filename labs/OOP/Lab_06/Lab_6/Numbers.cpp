#include "Numbers.h"


int Numbers::RowLength()
    {
        length = strlen(row);
        return length;
    }
char* Numbers::ChangeSymbol() 
    {
        char y = '3';
        char x = '1';
        for (int i = 0; i < strlen(row); i++)
        {
            if (row[i] == y) {
                row[i] = x;
            }
        }
        return row;
    }
