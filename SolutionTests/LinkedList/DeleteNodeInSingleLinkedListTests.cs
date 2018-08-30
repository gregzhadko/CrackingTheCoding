using NUnit.Framework;
using Solution.LinkedList;

namespace SolutionTests.LinkedList
{
    [TestFixture]
    public sealed class DeleteNodeInSingleLinkedListTests
    {
        [Test]
        public void FromBookTest()
        {
            var list = new LinkedList<string>();
            list.AppendToTail("a");
            list.AppendToTail("b");
            list.AppendToTail("c");
            list.AppendToTail("d");
            list.AppendToTail("e");
            list.AppendToTail("f");

            new DeleteMiddleNode<string>().DeleteNodeInSingleLinkedList(list, "c");

            CollectionAssert.AreEqual(new[] {"a", "b", "d", "e", "f"}, list.ToArray());
        }
    }
}