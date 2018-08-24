using NUnit.Framework;
using Solution.ArraysAndStrings;

// ReSharper disable StringLiteralTypo

namespace SolutionTests.ArraysAndStringsTests
{
    [TestFixture]
    public sealed class StringCompressionTests
    {
        [Test]
        [TestCase("aaa", "a3")]
        [TestCase("bBBbbB", "b6")]
        public void OneLetterCompression(string input, string expected)
        {
            var actual = new StringCompression().Compress(input);
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        [TestCase("aaabbbccd", "a3b3c2d1")]
        [TestCase("abcddd", "a1b1c1d3")]
        public void ManyLettersCompression(string input, string expected)
        {
            var actual = new StringCompression().Compress(input);
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        [TestCase("a", "a")]
        [TestCase("abc", "abc")]
        public void NoCompression(string input, string expected)
        {
            var actual = new StringCompression().Compress(input);
            Assert.AreEqual(expected, actual);
        }
    }
}