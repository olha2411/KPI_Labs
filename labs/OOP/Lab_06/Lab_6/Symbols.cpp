#include "Symbols.h"


int Symbols::RowLength() {
    length = strlen(row);
    return length;

 }
char* Symbols::ChangeSymbol()
{
    char y = '#';
    char x = '!';
    for (int i = 0; i < strlen(row); i++)
    {
        if (row[i] == y) {
            row[i] = x;
        }
    }
    return row;
}