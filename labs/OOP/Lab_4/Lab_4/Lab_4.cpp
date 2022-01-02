#include "Head.h"
using namespace std;

int main() {
    cout << "Olha Pavlushchenko, IS-02" << endl;
    cout << "Enter your row: ";
    string user_row;
    getline(cin, user_row);
    MyStrings R1;                     //об'єкт, створений конструктором за умовчанням
    MyStrings R2(user_row);             //об'єкт, створений конструктором з параметрами
    MyStrings R3(R2);                   //об'єкт, створений конструктором копіювання
    R2 = R2 / 2;                                        //видалення символів на парній позиції
    cout << "R2: " << R2.GetRow() << endl;
    R1 = R2 + R3;                                       //скаладання об'єктів
    cout << "R1: " << R1.GetRow() << endl;
}