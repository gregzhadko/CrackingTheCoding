using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Solution.LinkedList
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; set; }

        public LinkedList()
        {
        }

        public LinkedList(Node<T> head)
        {
            Head = head;
        }

        public LinkedList(T data) : this(new Node<T>(data))
        {
        }

        public void AppendToTail(T d)
        {
            var end = new Node<T>(d);
            if (Head == null)
            {
                Head = end;
                return;
            }

            var n = Head;
            while (n.Next != null)
            {
                n = n.Next;
            }

            n.Next = end;
            end.Previous = n;
        }

        public T[] ToArray()
        {
            var array = new List<T>();
            var n = Head;
            while (n != null)
            {
                array.Add(n.Data);
                n = n.Next;
            }

            return array.ToArray();
        }
    }
}