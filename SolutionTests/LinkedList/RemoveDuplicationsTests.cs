using NUnit.Framework;
using Solution.LinkedList;

namespace SolutionTests.LinkedList
{
    [TestFixture]
    public sealed class RemoveDuplicationsTests
    {
        [Test]
        public void RemoveDuplicationsTest()
        {
            var list = new LinkedList<int>(1);
            list.AppendToTail(2);
            list.AppendToTail(1);
            list.AppendToTail(3);
            list.AppendToTail(4);
            list.AppendToTail(1);
            list.AppendToTail(4);
            list.AppendToTail(4);

            list = RemoveDups<int>.RemoveDuplications(list);

            CollectionAssert.AreEquivalent(new[] {1, 2, 3, 4}, list.ToArray());
        }

        [Test]
        public void RemoveDuplicationsWithNoExtraSpaceTest()
        {
            var list = new LinkedList<int>(1);
            list.AppendToTail(2);
            list.AppendToTail(1);
            list.AppendToTail(3);
            list.AppendToTail(4);
            list.AppendToTail(1);
            list.AppendToTail(4);
            list.AppendToTail(4);

            list = RemoveDups<int>.RemoveDuplicationsNoExtraSpace(list);

            CollectionAssert.AreEquivalent(new[] {1, 2, 3, 4}, list.ToArray());
        }
    }
}