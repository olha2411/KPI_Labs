using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowsLibrary
{
    public class Numbers : Rows
    {
        public Numbers(string row) : base(row)
        {
        }
        public override int RowLength()
        {
            length = row.Length;
            return length;
        }
        public override string ChangeSymbol()
        {
            row = row.Replace("3", "11");
            return row;
        }
    }
}
