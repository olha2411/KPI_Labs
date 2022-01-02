using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib9
{
    public class Queue
    {
        private int Count;
        private LinkedList<char> queue;
        public delegate void QueueClear(string messege);
        public event QueueClear Notify;
        public Queue()
        {
            queue = new LinkedList<char>();
        }
        public void Clear()
        {
            if (queue.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");

            }
            queue.Clear();
            Notify?.Invoke("Queue is cleared");
        }

        public void Enqueue(char value)
        {
            queue.AddLast(value);
        }

        public void Dequeue()
        {
            if (queue.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }
            char first = queue.First.Value;
            queue.RemoveFirst();
        }

        public char Peek()
        {
            if (queue.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }
            return queue.First.Value;
        }

        public bool ContainLetters()
        {
            bool exist = false;
            foreach (char item in queue)
            {
                if (Char.IsLetter(item) == true)
                {
                    Count += 1;
                }
            }

            if (Count != 0)
            {
                exist = true;
            }
            return exist;
        }
        public void Print()
        {
            foreach (char item in queue)
            {
                Console.Write(item);
            }
        }

        public int LetterNumber()
        {
            return Count;
        }
    }
}
