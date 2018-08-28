using System.Collections.Generic;

namespace Solution.LinkedList
{
    // ReSharper disable once IdentifierTypo
    public static class RemoveDups<T>
    {
        public static LinkedList<T> RemoveDuplicationsNoExtraSpace(LinkedList<T> list)
        {
            var node = list.Head;
            
            while (node != null)
            {
                var data = node.Data;
                var nodeToRun = node;
                while (true)
                {
                    if (nodeToRun.Next == null)
                    {
                        break;
                    }

                    if (nodeToRun.Next.Data.Equals(data))
                    {
                        nodeToRun.Next.RemoveFromList();
                    }
                    else
                    {
                        nodeToRun = nodeToRun.Next;
                    }
                }

                node = node.Next;
            }

            return list;
        }

        public static LinkedList<T> RemoveDuplications(LinkedList<T> list)
        {
            var dictionary = new Dictionary<T, bool>();

            var node = list.Head;
            dictionary.Add(node.Data, true);
            while (node.Next != null)
            {
                if (dictionary.ContainsKey(node.Next.Data))
                {
                    node.Next = node.Next.Next;
                }
                else
                {
                    dictionary.Add(node.Next.Data, true);
                    node = node.Next;
                }
            }

            return list;
        }
    }
}