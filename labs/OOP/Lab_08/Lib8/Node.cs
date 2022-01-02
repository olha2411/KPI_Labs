using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lib8
{
    public class Node
    {
        public short Data { get; set; }
        public Node Next { get; set; }

        public Node() { }

        public Node(short data, Node next = null)
        {
            Data = data;
            Next = next;
        }


    }
}
