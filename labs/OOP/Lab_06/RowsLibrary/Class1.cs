using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowsLibrary
{
    public abstract class Rows
    {
        public string row;
        public int length;

        public Rows(string row)
        {
            this.row = row;
        }

        public abstract int RowLength();       

        public abstract string ChangeSymbol();


    }
}
