#include "Head.h"

    Figures:: Figures(double X1, double Y1, double X2, double Y2, double X3, double Y3, double X4, double Y4)       //конструктор з параметрами
    {
        CoordX1 = X1;
        CoordY1 = Y1;
        CoordX2 = X2;
        CoordY2 = Y2;
        CoordX3 = X3;
        CoordY3 = Y3;
        CoordX4 = X4;
        CoordY4 = Y4;
     }


    double Figures:: SideLength(double CoordX1, double CoordY1, double CoordX2, double CoordY2)     //знаходження довжини строни
    {

        lenght = sqrt(pow(CoordX2 - CoordX1, 2) + pow(CoordY2 - CoordY1, 2));
        return lenght;
    }

    Figures:: ~Figures() {                  //деструктор

        CoordX1 = 0;
        CoordY1 = 0;
        CoordX2 = 0;
        CoordY2 = 0;
        CoordX3 = 0;
        CoordY3 = 0;
        CoordX4 = 0;
        CoordY4 = 0;
        lenght = 0;
    }


    Rectangle::Rectangle(double X1, double Y1, double X2, double Y2, double X3, double Y3, double X4, double Y4) : Figures(X1, Y1, X2, Y2, X3, Y3, X4, Y4)         //конструктор
    {
        side1 = SideLength(CoordX1, CoordY1, CoordX2, CoordY2);
        side2 = SideLength(CoordX2, CoordY2, CoordX3, CoordY3);
    }

    void Rectangle:: Perimetr(double side1, double side2)               //знаходження периметра
    {
        perimetr = 2 * (side1 + side2);
    }
    void Rectangle::Square(double side1, double side2)                  //знаходження площі
    {
        square = side1 * side2;

    }

    double Rectangle::GetPerimetr()                                     
    {
        Perimetr(side1, side2);
        return perimetr;
    }
    double Rectangle::GetSquare()
    {
        Square(side1, side2);
        return square;
    }

    Rectangle::~Rectangle() {                               //деструктор
        perimetr = 0;   
        square = 0;
        side1 = 0;
        side2 = 0;
    }

