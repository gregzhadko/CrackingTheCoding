using System;
using System.Collections.Generic;

namespace Solution.LinkedList
{
    public sealed class Partition
    {
        public LinkedList<int> DoPartition(LinkedList<int> list, int value)
        {
            var leftResult = new LinkedList<int>();
            var rightResult = new LinkedList<int>();

            var node = list.Head;
            
            Node<int> lastNodeOfFirstList = null;
            while (node != null)
            {
                if (node.Data < value)
                {
                    lastNodeOfFirstList = new Node<int>(node.Data);
                    leftResult.AppendToTail(lastNodeOfFirstList);
                }
                else
                {
                    rightResult.AppendToTail(new Node<int>(node.Data));
                }

                node = node.Next;
            }

            if (lastNodeOfFirstList != null)
            {
                lastNodeOfFirstList.Next = rightResult.Head;
            }

            return leftResult;
        }
    }
}