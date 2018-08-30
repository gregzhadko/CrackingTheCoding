namespace Solution.LinkedList
{
    public sealed class Node<T>
    {
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }
        public T Data { get; }

        public Node(T d)
        {
            Data = d;
        }

        public void RemoveFromList()
        {
            if (Previous != null)
            {
                Previous.Next = Next;
            }

            if (Next != null)
            {
                Next.Previous = Previous;
            }
        }
    }
}