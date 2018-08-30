using System;

namespace Solution.LinkedList
{
    public class ReturnKthToLast<T>
    {
        private readonly int _k;
        private readonly LinkedList<T> _list;

        public ReturnKthToLast(LinkedList<T> list, int k)
        {
            _list = list;
            _k = k;
        }

        public Node<T> KthToLastNode()
        {
            var node1 = _list.Head;
            var node2 = _list.Head;

            for (int i = 0; i < _k; i++)
            {
                node1 = node1.Next;
            }

            while (node1 != null)
            {
                node1 = node1.Next;
                node2 = node2.Next;
            }

            return node2;
        }

        
    }
}