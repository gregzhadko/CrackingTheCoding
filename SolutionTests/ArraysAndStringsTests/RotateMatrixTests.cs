using NUnit.Framework;
 using Solution.ArraysAndStrings;
 
 namespace SolutionTests.ArraysAndStringsTests
 {
     [TestFixture]
     public sealed class RotateMatrixTests
     {
         [Test]
         public void OnePixelMatrixRotationTest()
         {
             var matrix = new Matrix(new[,] {{1}});
             matrix.Rotate();
             Assert.AreEqual(new[,] {{1}}, matrix.Elements);
         }

         [Test]
         public void TwoXTwoMatrixRotationTest()
         {
             var elements = new[,] {{1, 2}, {3, 4}};
             var matrix = new Matrix(elements); 
             matrix.Rotate();
             Assert.AreEqual(new[,] {{3, 1}, {4, 2}}, matrix.Elements);
         }
         
         [Test]
         public void ThreeXThreeMatrixRotationTest()
         {
             var elements = new[,] {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
             var matrix = new Matrix(elements); 
             matrix.Rotate();
             Assert.AreEqual(new[,] {{7, 4, 1}, {8, 5, 2}, {9, 6, 3}}, matrix.Elements);
         }
         
         [Test]
         public void FourXFourMatrixRotationTest()
         {
             var elements = new[,] {{1, 2, 3, 4}, {5, 6, 7, 8}, {9, 0, 1, 2}, {3, 4, 5, 6}};
             var matrix = new Matrix(elements); 
             matrix.Rotate();
             Assert.AreEqual(new[,] {{3, 9, 5, 1}, {4, 0, 6, 2}, {5, 1, 7, 3}, {6, 2, 8, 4}}, matrix.Elements);
         }
     }
 }