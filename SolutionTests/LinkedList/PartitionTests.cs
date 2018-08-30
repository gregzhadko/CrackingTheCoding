using System.Linq;
using NUnit.Framework;
using Solution.LinkedList;

namespace SolutionTests.LinkedList
{
    [TestFixture]
    public sealed class PartitionTests
    {
        [Test]
        public void RemoveDuplicationsTest()
        {
            var list = new LinkedList<int>();
            list.AppendToTail(3);
            list.AppendToTail(5);
            list.AppendToTail(8);
            list.AppendToTail(5);
            list.AppendToTail(10);
            list.AppendToTail(2);
            list.AppendToTail(1);

            var partitionedList = new Partition().DoPartition(list, 5).ToArray();

            var firstPart = partitionedList.Take(3).ToArray();

            CollectionAssert.AreEquivalent(new[] {3, 1, 2}, firstPart);

            var secondPart = partitionedList.Skip(3).ToArray();

            CollectionAssert.AreEquivalent(new[] {10, 5, 5, 8}, secondPart);
        }
    }
}