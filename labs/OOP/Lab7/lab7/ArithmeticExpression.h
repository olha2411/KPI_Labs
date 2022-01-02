#pragma once
#include <iostream>
#include <exception>
#include <cmath>
class ArithmeticExpression
{
private:
    double a, b, c, d;
    double value;
public:
    ArithmeticExpression();
    ArithmeticExpression(double a, double b, double c, double d);              //constructor
    void ExpressionValue();
    double GetResult();
};

