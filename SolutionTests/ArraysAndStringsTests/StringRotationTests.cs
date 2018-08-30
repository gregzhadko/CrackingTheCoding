using NUnit.Framework;
using Solution.ArraysAndStrings;

// ReSharper disable StringLiteralTypo

namespace SolutionTests.ArraysAndStringsTests
{
    [TestFixture]
    public sealed class StringRotationTests
    {
        [Test]
        public void IsRotationTest_True()
        {
            Assert.IsTrue(new StringRotation().IsRotation("waterbottle", "erbottlewat"));
            Assert.IsTrue(new StringRotation().IsRotation("erbottlewat", "waterbottle"));
        }
        
        [Test]
        public void IsRotationTest_False()
        {
            Assert.IsFalse(new StringRotation().IsRotation("waterbottle", "erbottleawt"));
        }
    }
}