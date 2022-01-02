#include "ArithmeticExpression.h"

ArithmeticExpression::ArithmeticExpression() {    }
ArithmeticExpression::ArithmeticExpression(double a, double b, double c, double d)                //constructor
{
    this->a = a;
    this->b = b;
    this->c = c;
    this->d = d;
}

void ArithmeticExpression::ExpressionValue()                                                     //geting value and checking the result
{
    if (sqrt(41 - d) - b * a - c == 0)
    {
        throw std::underflow_error("The value of denomitor equal zero");
    }
    else
    {
        if (d > 41)
        {
            throw std::overflow_error("The value of square root can't be negative ");
        }
        else
        {
            value = (a * b / 4 - 1) / (sqrt(41 - d) - b * a - c);
        }
    }
}
double ArithmeticExpression::GetResult()
{
    return value;
}