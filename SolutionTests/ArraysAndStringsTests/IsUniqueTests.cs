using NUnit.Framework;
using Solution.ArraysAndStrings;

namespace SolutionTests.ArraysAndStringsTests
{
    [TestFixture]
    public sealed class IsUniqueTests
    {
        [Test]
        public void Test1()
        {
            var actual = IsUnique.SolutionWithDictionary("tes");
            Assert.AreEqual(true, actual);
        }
        
        [Test]
        public void Test2()
        {
            var actual = IsUnique.SolutionWithDictionary("test");
            Assert.AreEqual(false, actual);
        }
        
        [Test]
        public void Test3()
        {
            var actual = IsUnique.SolutionWithDictionary("tes1234567");
            Assert.AreEqual(true, actual);
        }
        
        [Test]
        public void Test12()
        {
            var actual = IsUnique.SolutionWithoutAdditionalDataStructure("tes");
            Assert.AreEqual(true, actual);
        }
        
        [Test]
        public void Test22()
        {
            var actual = IsUnique.SolutionWithoutAdditionalDataStructure("test");
            Assert.AreEqual(false, actual);
        }
        
        [Test]
        public void Test32()
        {
            var actual = IsUnique.SolutionWithoutAdditionalDataStructure("tes1234567");
            Assert.AreEqual(true, actual);
        }
    }
}