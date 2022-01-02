using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Library
{
    public class TwoDimensionalArray
    {
        public int cols;        //кількість стовпців масиву
        public int rows;        //кількість рядків масиву
        public int[,] arr;      //масив
        private int result = 1;     //змінна добутку
        
        public TwoDimensionalArray(int rows, int cols)      //конструктор 
        {
            this.rows = rows;
            this.cols = cols;
            arr = new int[rows, cols];
            
        }
        public double this[int k]           //індексатор 
        {
            get
            {
                int SumRow = 0;
                for (int i = 0; i < cols; i++)
                {
                    SumRow += arr[k, i];
                }
                double average = SumRow / cols;
                return average;                     //середнє арифметичне значень заданого рядка
            }
        }
        public int this[int i, int j]       //індексатор
        {
            get
            {
                return arr[i, j];
            }
            set
            {
                arr[i, j] = value;
            }
        }
        public int Product              //властивість
        {
            get
            {

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        result *= arr[i, j];
                    }
                }
                return result;              //добуток значень усіх елементів
            }


        }
    }
}
