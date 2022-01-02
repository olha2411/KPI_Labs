#pragma once
#include "Rows.h"

class Numbers : public Rows
{
public:
    Numbers(char* row) : Rows(row) {}
    int RowLength() override;   
    char* ChangeSymbol() override;   
};
