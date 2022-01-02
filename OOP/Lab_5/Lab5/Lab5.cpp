
#include "Head.h"
using namespace std;

int main()
{
    cout << "Olha pavlushchenko, IS-02" << endl;
    cout << "Enter the coordinates:"<< endl;    
    double x1, y1, x2, y2, x3, y3, x4, y4;                  //координати
    cout << "Side1" << endl;
    cout << "X: "; 
    cin >> x1;
    cout << "Y: ";
    cin >> y1;
    cout << "Side2" << endl;
    cout << "X: ";
    cin >> x2;
    cout << "Y: ";
    cin >> y2;
    cout << "Side3" << endl;
    cout << "X: ";
    cin >> x3;
    cout << "Y: ";
    cin >> y3;
    cout << "Side4" << endl;
    cout << "X: ";
    cin >> x4;
    cout << "Y: ";
    cin >> y4;
   
    Rectangle rectangle(x1, y1, x2, y2, x3, y3, x4, y4);        //створення обєкту 

    cout <<"Perimetr: "<< rectangle.GetPerimetr();              //виведення периметру
    cout << endl;
    cout << "Square: "<< rectangle.GetSquare();                 //виведення площі
   
}


