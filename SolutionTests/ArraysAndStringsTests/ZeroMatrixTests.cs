using System;
using NUnit.Framework;
using Solution.ArraysAndStrings;

namespace SolutionTests.ArraysAndStringsTests
{
    [TestFixture()]
    public class ZeroMatrixTests
    {
        [Test]
        public void ZeroMatrix1X1Test()
        {
            var randomNumber = new Random().Next(0, 10);
            var matrix = new Matrix(new[,] {{randomNumber}});
            matrix.Zero();
            Assert.AreEqual(new[,] {{randomNumber}}, matrix.Elements);
        }

        [Test]
        public void ZeroMatrix2X2Test()
        {
            var matrix = new Matrix(new[,]{{1, 0}, {2, 2}});
            matrix.Zero();
            Assert.AreEqual(new[,]{{0, 0}, {2, 0}}, matrix.Elements);
        }
        
        [Test]
        public void ZeroMatrix3X3Test()
        {
            var matrix = new Matrix(new[,]{{1, 0, 1}, {2, 2, 1}, {1, 1, 3}});
            matrix.Zero();
            Assert.AreEqual(new[,]{{0, 0, 0}, {2, 0, 1}, {1, 0, 3}}, matrix.Elements);
        }
        
        [Test]
        public void ZeroMatrix3X3Test2()
        {
            var matrix = new Matrix(new[,]{{1, 1, 1}, {1, 0, 1}, {1, 1, 1}});
            matrix.Zero();
            Assert.AreEqual(new[,]{{1, 0, 1}, {0, 0, 0}, {1, 0, 1}}, matrix.Elements);
        }
        
        [Test]
        public void ZeroMatrix4X4Test()
        {
            var matrix = new Matrix(new[,]{{1, 1, 1, 1}, {1, 1, 0, 1}, {0, 1, 1, 1}, {1, 1, 1, 1}});
            matrix.Zero();
            Assert.AreEqual(new[,]{{0, 1, 0, 1}, {0, 0, 0, 0}, {0, 0, 0, 0}, {0, 1, 0, 1}}, matrix.Elements);
        }
        
        [Test]
        public void ZeroMatrix4X2Test()
        {
            var matrix = new Matrix(new[,]{{1, 1, 1, 1}, {1, 1, 0, 1}});
            matrix.Zero();
            Assert.AreEqual(new[,]{{1, 1, 0, 1}, {0, 0, 0, 0}}, matrix.Elements);
        }
        
        [Test]
        public void ZeroMatrix4X3Test()
        {
            var matrix = new Matrix(new[,]{{1, 1, 1, 1}, {1, 1, 0, 1}, {0, 1, 1, 1}});
            matrix.Zero();
            Assert.AreEqual(new[,]{{0, 1, 0, 1}, {0, 0, 0, 0}, {0, 0, 0, 0}}, matrix.Elements);
        }
    }
}