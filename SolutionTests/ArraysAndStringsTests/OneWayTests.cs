using NUnit.Framework;
using Solution.ArraysAndStrings;

namespace SolutionTests.ArraysAndStringsTests
{
    [TestFixture]
    public sealed class OneWayTests
    {
        [Test]
        [TestCase("pale", "ple")]
        [TestCase("pales", "pale")]
        public void RemoveEditApplied_Success(string original, string resulted)
        {
            var oneWay = new OneWay();
            Assert.IsTrue(oneWay.IsOneEdit(original, resulted));
        }
        
        [Test]
        [TestCase("ple", "pale")]
        [TestCase("pale", "pales")]
        public void AddEditApplied_Success(string original, string resulted)
        {
            var oneWay = new OneWay();
            Assert.IsTrue(oneWay.IsOneEdit(original, resulted));
        }
        
        [Test]
        [TestCase("pale", "bale")]
        public void ReplaceEditApplied_Success(string original, string resulted)
        {
            var oneWay = new OneWay();
            Assert.IsTrue(oneWay.IsOneEdit(original, resulted));
        }
        
        [Test]
        [TestCase("pale", "bake")]
        [TestCase("pale", "apaler")]
        [TestCase("pale", "palis")]
        public void SeveralEditApplies_Failure(string original, string resulted)
        {
            var oneWay = new OneWay();
            Assert.IsFalse(oneWay.IsOneEdit(original, resulted));
        }
        
        [Test]
        [TestCase("pale", "pale")]
        public void NoChanges_Failure(string original, string resulted)
        {
            var oneWay = new OneWay();
            Assert.IsFalse(oneWay.IsOneEdit(original, resulted));
        }
    }
}