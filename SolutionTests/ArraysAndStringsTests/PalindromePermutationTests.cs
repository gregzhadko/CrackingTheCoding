using NUnit.Framework;
using Solution.ArraysAndStrings;

// ReSharper disable StringLiteralTypo

namespace SolutionTests.ArraysAndStringsTests
{
    [TestFixture]
    public sealed class PalindromePermutationTests
    {
        [Test]
        [TestCase("А роза упала на лапу Азора")]
        [TestCase("Tact Coa")]
        [TestCase("Tact Coaaa")]
        [TestCase("TactCoa")]
        [TestCase("a")]
        [TestCase("aa")]
        public void Test_PalindromePermutation_Success(string input)
        {
            var actual = PalindromePermutation.IsPalindromePermutation(input);
            Assert.IsTrue(actual);
        }
        
        [Test]
        [TestCase("А роза упала на лапу Азора1")]
        [TestCase("TactCCoa")]
        [TestCase("ac")]
        public void Test_NotPalindromePermutation_Success(string input)
        {
            var actual = PalindromePermutation.IsPalindromePermutation(input);
            Assert.IsFalse(actual);
        }
    }
}