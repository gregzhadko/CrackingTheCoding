using NUnit.Framework;
using Solution.ArraysAndStrings;

namespace SolutionTests.ArraysAndStringsTests
{
    [TestFixture]
    public sealed class CheckPermutationTests
    {
        [Test]
        public void Test1()
        {
            var actual = CheckPermutation.IsPermutation("test", "estt");
            Assert.IsTrue(actual);
        }
        
        [Test]
        public void Test2()
        {
            var actual = CheckPermutation.IsPermutation("test", "tes");
            Assert.IsFalse(actual);
        }
        
        [Test]
        public void Test3()
        {
            var actual = CheckPermutation.IsPermutation("test", "tess");
            Assert.IsFalse(actual);
        }
        
        [Test]
        public void Test4()
        {
            var actual = CheckPermutation.IsPermutation("test", "tset");
            Assert.IsTrue(actual);
        }
        
        [Test]
        public void Test5()
        {
            var actual = CheckPermutation.IsPermutation("test111111", "111111tset");
            Assert.IsTrue(actual);
        }
        
        [Test]
        public void Test6()
        {
            var actual = CheckPermutation.IsPermutation("test111111", "111112tset");
            Assert.IsFalse(actual);
        }
    }
}