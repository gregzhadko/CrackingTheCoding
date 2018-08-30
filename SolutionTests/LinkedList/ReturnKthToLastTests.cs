using NUnit.Framework;
using Solution.LinkedList;

namespace SolutionTests.LinkedList
{
    [TestFixture]
    public class ReturnKthToLastTests
    {
        [Test]
        public void Test1()
        {
            var list = new LinkedList<int>(1);
            list.AppendToTail(2);
            list.AppendToTail(1);
            list.AppendToTail(3);
            list.AppendToTail(4);
            list.AppendToTail(1);
            list.AppendToTail(4);
            list.AppendToTail(4);

            var actual = new ReturnKthToLast<int>(list, 5).KthToLastNode();
            Assert.AreEqual(3, actual.Data);
            
            actual = new ReturnKthToLast<int>(list, 7).KthToLastNode();
            Assert.AreEqual(2, actual.Data);
        }
    }
}