
#include "Rows.h"
#include "Symbols.h"
#include "Numbers.h"
using namespace std;

int main()
{
    cout << "Olha Pavlushchenko, IS-02, Lab_6" << endl;
    char a[] = "t#ttr#rt";                                           //row
    char b[] = "317056677138";    
    Rows* row1 = new Symbols(a);
    cout << "Length: " << (*row1).RowLength() << endl;              //lenght of row
    cout << "Replaced: " << (*row1).ChangeSymbol() << endl;         //repalace symbols
    Rows* row2 = new Numbers(b);
    cout << "Length: " << (*row2).RowLength() << endl;
    cout << "Replaced: " << (*row2).ChangeSymbol() << endl;
    
}