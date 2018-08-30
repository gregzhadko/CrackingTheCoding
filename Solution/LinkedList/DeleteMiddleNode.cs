namespace Solution.LinkedList
{
    public sealed class DeleteMiddleNode<T>
    {
        public void DeleteNodeInSingleLinkedList(LinkedList<T> list, T data)
        {
            var node1 = list.Head;
            if (node1 == null)
            {
                return;
            }

            if (node1.Data.Equals(data))
            {
                list.Head = null;
                return;
            }

            var node2 = list.Head.Next;

            while (node2 != null)
            {
                if (node2.Data.Equals(data))
                {
                    node1.Next = node2.Next;
                    node2.Next.Previous = node1; //We don't need in a single linked case.
                    return;
                }

                node1 = node1.Next;
                node2 = node2.Next;
            }
        }
    }
}