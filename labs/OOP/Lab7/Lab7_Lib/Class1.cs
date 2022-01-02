using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Lib
{
    public class ArithmeticExpression
    {
        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }
        private double d { get; set; }
        
        private double value;
        public ArithmeticExpression(double a, double b, double c, double d)                //constructor
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public void ExpressionValue()                                                //geting value and checking the result
        {


            if (Math.Sqrt(41 - d) - b * a - c == 0)
            {

                throw new DivideByZeroException("The value of denomitor equal zero");
            }
            else
            {
                if (d > 41)
                {
                    throw new DivideByZeroException("The value of square root can't be negative ");
                }
                else
                {
                    value = (a * b / 4 - 1) / (Math.Sqrt(41 - d) - b * a - c);
                }
            }
        }            

        
        public double GetResult()
        {
            return value;
        }
    }
}
