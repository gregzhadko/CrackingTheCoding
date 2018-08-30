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
            AppendToTail(new Node<T>(d));
        }

        public void AppendToTail(Node<T> node)
        {
            if (Head == null)
            {
                Head = node;
                return;
            }

            var n = Head;
            while (n.Next != null)
            {
                n = n.Next;
            }

            n.Next = node;
            node.Previous = n;
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