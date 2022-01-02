#pragma once
#include <iostream>
#include <iomanip>
#include <cmath>

class Figures
{
protected:
    double CoordX1, CoordY1, CoordX2, CoordY2, CoordX3, CoordY3, CoordX4, CoordY4;
    double lenght;

public:
    Figures(double X1, double Y1, double X2, double Y2, double X3, double Y3, double X4, double Y4); 
protected:
    double SideLength(double CoordX1, double CoordY1, double CoordX2, double CoordY2);

public:
    ~Figures();
};

class Rectangle : public Figures
{
public:
    double perimetr;
    double square;
    double side1;
    double side2;

    Rectangle(double X1, double Y1, double X2, double Y2, double X3, double Y3, double X4, double Y4);

private:
    void Perimetr(double side1, double side2);
    void Square(double side1, double side2);

public:
    double GetPerimetr();
    double GetSquare();

    ~Rectangle();
};
   