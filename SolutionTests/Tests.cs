using System;
using IsUnique;
using NUnit.Framework;

namespace SolutionTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var actual = Solution.SolutionWithDictionary("tes");
            Assert.AreEqual(true, actual);
        }
        
        [Test]
        public void Test2()
        {
            var actual = Solution.SolutionWithDictionary("test");
            Assert.AreEqual(false, actual);
        }
        
        [Test]
        public void Test3()
        {
            var actual = Solution.SolutionWithDictionary("tes1234567");
            Assert.AreEqual(true, actual);
        }
        
        [Test]
        public void Test12()
        {
            var actual = Solution.SolutionWithoutSdditionalDataStructure("tes");
            Assert.AreEqual(true, actual);
        }
        
        [Test]
        public void Test22()
        {
            var actual = Solution.SolutionWithoutSdditionalDataStructure("test");
            Assert.AreEqual(false, actual);
        }
        
        [Test]
        public void Test32()
        {
            var actual = Solution.SolutionWithoutSdditionalDataStructure("tes1234567");
            Assert.AreEqual(true, actual);
        }
    }
}