using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Libray
{
    public class Figures
    {
        protected int CoordX1, CoordY1, CoordX2, CoordY2, CoordX3, CoordY3, CoordX4, CoordY4;
        
        public Figures(int X1, int Y1, int X2, int Y2, int X3, int Y3, int X4, int Y4)          //конструктор з параметрами
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

        protected double SideLength(int CoordX1, int CoordY1, int CoordX2, int CoordY2)                 //знаходження довжини строни
        {
            double lenght;
            lenght = Math.Sqrt(Math.Pow(CoordX2 - CoordX1, 2) + Math.Pow(CoordY2 - CoordY1, 2));
            return lenght;
        }
    }
    
    public class Rectangle : Figures
    {

        public double perimetr;
        public double square;
        double side1;
        double side2;

        public Rectangle(int X1, int Y1, int X2, int Y2, int X3, int Y3, int X4, int Y4) : base(X1, Y1, X2, Y2, X3, Y3, X4, Y4)
        {
            side1 = SideLength(CoordX1, CoordY1, CoordX2, CoordY2);
            side2 = SideLength(CoordX2, CoordY2, CoordX3, CoordY3);
        }
        private void Perimetr(double side1, double side2)           //знаходження периметра
        {
            perimetr = 2 * (side1 + side2);
        }
        private void Square(double side1, double side2)                 //знаходження площі
        {
            square = side1 * side2;

        }
        public double GetPerimetr()
        {
            Perimetr(side1, side2);
            return perimetr;
        }
        public double GetSquare()
        {
            Square(side1, side2);
            return square;
        }

    }
}
