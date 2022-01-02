#pragma once
#include "Rows.h"

class Symbols : public Rows
{
public:
    Symbols(char* row) : Rows(row) {}
    int RowLength() override;    
    char* ChangeSymbol() override;    
};