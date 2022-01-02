using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowsLibrary
{
    public class Symbols : Rows
    {
        public Symbols(string row) : base(row)
        {
        }
        public override int RowLength()
        {
            length = row.Length;
            return length;
        }
        public override string ChangeSymbol()
        {
            row = row.Replace("#", "!!");
            return row;
        }
    }
}
