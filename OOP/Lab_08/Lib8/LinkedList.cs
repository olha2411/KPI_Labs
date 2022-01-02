using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib8
{
    public class LinkedList : IEnumerable<short>
    {
        public Node head;
        public Node tail;
        public int count;

        public LinkedList(short data)
        {
            head = tail = new Node(data);
            count = 1;
        }
        public void Add(short data)
        {
            if (tail != null)
            {
                Node node = new Node(data);
                tail.Next = node;
                tail = node;
                count++;
                return;
            }
            head = tail = new Node(data);
            count = 1;

        }
        public void ChangeToZero()
        {
            int counter = 0;
            Node current = head;
            while (current != null)
            {
                if (counter % 2 != 0)
                    current.Data = 0;

                counter++;
                current = current.Next;
            }
        }
        public int CountMultiplesOfFour()
        {
            int counter = 0;
            foreach (short item in this)
            {
                if (item % 4 == 0)
                    counter++;
            }

            return counter;
        }

        public IEnumerator<short> GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
