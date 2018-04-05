using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        private const int V = 1;
        private  const double DOUBLE_EPS = 1E-6;

        [TestMethod]
        public void TestSum()
        {
            FirstSteps firstSteps = new FirstSteps();
            int k = firstSteps.Sum(1, 2);
            Assert.AreEqual(k, 3);
        }
        [TestMethod]
        public void TestMul()
        {
            FirstSteps fs = new FirstSteps();
            int k = fs.Mul(1, 3);
            Assert.AreEqual(3, k);

        }
        [TestMethod]
        public void TestDiv()
        {
            FirstSteps fs = new FirstSteps();
            int k = fs.Div(15, 3);
            Assert.AreEqual(5, k);
        }
        [TestMethod]
        public void TestMod()
        {
            FirstSteps fs = new FirstSteps();
            int k = fs.Mod(6, 2);
            Assert.AreEqual(0, k);
        }
        [TestMethod]
        public void TestMatrixSum() {
            FirstSteps fs = new FirstSteps();
            int[,] mas = {
            { 1, 2},
            { 2, 4},
            };
            int k = fs.SumMatrix(mas);
            Assert.AreEqual(9,k);
        }
        

        [TestMethod]
    public void testSum()
        {
            FirstSteps firstSteps = new FirstSteps();
            Assert.AreEqual(4, firstSteps.Sum(2, 2));
            Assert.AreEqual(20000, firstSteps.Sum(10000, 10000));
        }

        [TestMethod]
    public void testMul()
        {
            FirstSteps firstSteps = new FirstSteps();
            Assert.AreEqual(4, firstSteps.Mul(2, 2));
            Assert.AreEqual(100000000, firstSteps.Mul(10000, 10000));
        }

        [TestMethod]
    public void testDiv()
        {
            FirstSteps firstSteps = new FirstSteps();
            Assert.AreEqual(1, firstSteps.Div(2, 2));
            Assert.AreEqual(0, firstSteps.Div(1, 2));
            Assert.AreEqual(1, firstSteps.Div(10200, 10000));
        }

        [TestMethod]
    public void testMod()
        {
            FirstSteps firstSteps = new FirstSteps();
            Assert.AreEqual(1, firstSteps.Mod(3, 2));
            Assert.AreEqual(0, firstSteps.Mod(4, 2));
            Assert.AreEqual(10, firstSteps.Mod(70, 20));
        }

        [TestMethod]
    public void testEquals()
        {
            FirstSteps firstSteps = new FirstSteps();
            Assert.IsTrue(firstSteps.IsEqual(2, 2));
            Assert.IsFalse(firstSteps.IsEqual(3, 2));
        }

        [TestMethod]
    public void testGreater()
        {
            FirstSteps firstSteps = new FirstSteps();
            Assert.IsTrue(firstSteps.IsGreater(3, 2));
            Assert.IsFalse(firstSteps.IsGreater(2, 2));
            Assert.IsFalse(firstSteps.IsGreater(1, 2));
        }

        [TestMethod]
    public void testIsInsideRect()
        {
            FirstSteps firstSteps = new FirstSteps();
            Assert.IsTrue(firstSteps.IsInsideRect(0, 0, 100, 100, 50, 50));
            Assert.IsTrue(firstSteps.IsInsideRect(0, 0, 100, 100, 50, 100));
            Assert.IsTrue(firstSteps.IsInsideRect(0, 0, 100, 100, 100, 100));
            Assert.IsTrue(firstSteps.IsInsideRect(0, 0, 100, 100, 0, 0));
            Assert.IsFalse(firstSteps.IsInsideRect(0, 0, 100, 100, 200, 200));
            Assert.IsFalse(firstSteps.IsInsideRect(0, 0, 100, 100, 0, 101));
            Assert.IsFalse(firstSteps.IsInsideRect(0, 0, 100, 100, 101, 0));
            Assert.IsFalse(firstSteps.IsInsideRect(0, 0, 100, 100, -1, 0));
            Assert.IsFalse(firstSteps.IsInsideRect(0, 0, 100, 100, 0, -1));
        }

        [TestMethod]
    public void testSumArray()
        {
            FirstSteps firstSteps = new FirstSteps();
            int[] array1 = { 1, 2, 3 };
            Assert.AreEqual(6, firstSteps.Sum(array1));
            int[] array2 = { -1, -2, 3 };
            Assert.AreEqual(0, firstSteps.Sum(array2));
            int[] array3 = { };
            Assert.AreEqual(0, firstSteps.Sum(array3));
        }

        [TestMethod]
    public void testMulArray()
        {
            FirstSteps firstSteps = new FirstSteps();
            int[] array1 = { 1, 2, 3 };
            Assert.AreEqual(6, firstSteps.Mul(array1));
            int[] array2 = { -1, -2, 3 };
            Assert.AreEqual(6, firstSteps.Mul(array2));
            int[] array3 = { 1, 2, 0 };
            Assert.AreEqual(0, firstSteps.Mul(array3));
            int[] array4 = { };
            Assert.AreEqual(0, firstSteps.Mul(array4));
        }

        [TestMethod]
    public void testMinArray()
        {
            FirstSteps firstSteps = new FirstSteps();
            int[] array1 = { 5, 1, 2, 3, -2 };
            Assert.AreEqual(-2, firstSteps.Min(array1));
            int[] array2 = { };
            Assert.AreEqual(int.MaxValue, firstSteps.Min(array2));
        }

        [TestMethod]
    public void testMaxArray()
        {
            FirstSteps firstSteps = new FirstSteps();
            int[] array1 = { 5, 1, 22, 3, -2 };
            Assert.AreEqual(22, firstSteps.Max(array1));
            int[] array2 = { };
            Assert.AreEqual(int.MinValue, firstSteps.Max(array2));
        }

        [TestMethod]
    public void testAverageArray()
        {
            FirstSteps firstSteps = new FirstSteps();
            int[] array1 = { 1, 2, 3, 4, 5 };
            Assert.AreEqual(3, firstSteps.Average(array1));
            int[] array2 = { };
            Assert.AreEqual(0, firstSteps.Average(array2));
        }

        [TestMethod]
    public void testSortedDescendantArray()
        {
            FirstSteps firstSteps = new FirstSteps();
            int[] array1 = { 3, 2, 1 };
            Assert.IsTrue(firstSteps.IsSortedDescendant(array1));
            int[] array2 = { 3, 2, 2 };
            Assert.IsFalse(firstSteps.IsSortedDescendant(array2));
            int[] array3 = { 3, 2, 1, 4 };
            Assert.IsFalse(firstSteps.IsSortedDescendant(array3));
            int[] array4 = { 1 };
            Assert.IsTrue(firstSteps.IsSortedDescendant(array4));
            int[] array5 = { };
            Assert.IsTrue(firstSteps.IsSortedDescendant(array5));
        }

        [TestMethod]
    public void testCubeArray()
        {
            FirstSteps firstSteps = new FirstSteps();
            int[] array1 = { 1, 2, 3, 0 };
            firstSteps.Cube(array1);
            int[] arrayResult1 = { 1, 8, 27, 0 };
            Assert.ReferenceEquals(arrayResult1, array1);
            int[] array2 = { 100, 200, 3, 10 };
            firstSteps.Cube(array2);
            int[] arrayResult2 = { 1000000, 8000000, 27, 1000 };
            Assert.ReferenceEquals(arrayResult2, array2);
        }

        [TestMethod]
    public void testFindValueArray()
        {
            FirstSteps firstSteps = new FirstSteps();
            int[] array = { 1, 2, 3, 0 };
            Assert.IsTrue(firstSteps.Find(array, 2));
            Assert.IsTrue(firstSteps.Find(array, 0));
            Assert.IsFalse(firstSteps.Find(array, 10));
        }

        [TestMethod]
    public void testReverseArray()
        {
            FirstSteps firstSteps = new FirstSteps();
            int[] array1 = { 1, 2, 3, 0 };
            int[] arrayResult1 = { 0, 3, 2, 1 };
            firstSteps.reverse(array1);
            Assert.ReferenceEquals(arrayResult1, array1);
            int[] array2 = { 1, 2, 6, 3, 0 };
            int[] arrayResult2 = { 0, 3, 6, 2, 1 };
            firstSteps.reverse(array2);
            Assert.ReferenceEquals(arrayResult2, array2);
            int[] array3 = { 1 };
            int[] arrayResult3 = { 1 };
            firstSteps.reverse(array3);
            Assert.ReferenceEquals(arrayResult3, array3);
            int[] array4 = { };
            int[] arrayResult4 = { };
            firstSteps.reverse(array4);
            Assert.ReferenceEquals(arrayResult4, array4);
        }

        [TestMethod]
    public void testIsPalindromeArray()
        {
            FirstSteps firstSteps = new FirstSteps();
            int[] array1 = { 1, 2, 2, 1 };
            Assert.IsTrue(firstSteps.isPalindrome(array1));
            int[] array2 = { 1, 2, 6, 2, 1 };
            Assert.IsTrue(firstSteps.isPalindrome(array2));
            int[] array3 = { 1, 2, 6, 3, 1 };
            Assert.IsFalse(firstSteps.isPalindrome(array3));
            int[] array4 = { 1 };
            Assert.IsTrue(firstSteps.isPalindrome(array4));
            int[] array5 = { };
            Assert.IsTrue(firstSteps.isPalindrome(array5));
        }

        [TestMethod]
    public void testSumMatrix()
        {
            FirstSteps firstSteps = new FirstSteps();
            int[,] matrix = { { 1, 2, 3 }, { 3, 4, 5 }, { 6, 7, 8 } };
            Assert.AreEqual(39, firstSteps.SumMatrix(matrix));
        }

        [TestMethod]
    public void testMaxMatrix()
        {
            FirstSteps firstSteps = new FirstSteps();
            int[,] matrix1 = { { 1, 2, 3 }, { 3, 4, 5 }, { 6, 7, 8 } };
            Assert.AreEqual(8, firstSteps.MaxElemMatrix(matrix1));
            int[,] matrix2 = { { 100, 200, 300 }, { 3, 4, 5 }, { 6, 7, 8 } };
            Assert.AreEqual(300, firstSteps.MaxElemMatrix(matrix2));
            int[,] matrix3 = { { } };
            Assert.AreEqual(int.MinValue, firstSteps.MaxElemMatrix(matrix3));
        }

        [TestMethod]
    public void testDiagonalMaxMatrix()
        {
            FirstSteps firstSteps = new FirstSteps();
            int[,] matrix1 = { { 1, 2, 3 }, { 3, 4, 5 }, { 6, 7, 8 } };
            Assert.AreEqual(8, firstSteps.diagonalMax(matrix1));
            int[,] matrix2 = { { 100, 2, 3 }, { 3, 4, 5 }, { 6, 7, 800 } };
            Assert.AreEqual(800, firstSteps.diagonalMax(matrix2));
            int[,] matrix3 = { { } };
            Assert.AreEqual(int.MinValue, firstSteps.MaxElemMatrix(matrix3));
        }

        [TestMethod]
    public void testSortedDescendantMatrixRows()
        {
            FirstSteps firstSteps = new FirstSteps();
            int[,] matrix1 = { { 3, 2, 1 }, { 5, 4, 3 }, { 8, 7, 6 } };
            Assert.IsTrue(firstSteps.isSortedDescendant(matrix1));
            int[,] matrix2 = { { 3, 2, 2 }, { 5, 4, 3 }, { 8, 7, 6 } };
            Assert.IsFalse(firstSteps.isSortedDescendant(matrix2));
            int[,] matrix3 = { { 3, 2, 1 } };
            Assert.IsTrue(firstSteps.isSortedDescendant(matrix3));
            int[,] matrix4 = { { } };
            Assert.IsTrue(firstSteps.isSortedDescendant(matrix4));
            
        }
    }

}

