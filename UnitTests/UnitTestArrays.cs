using System;
using HW_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestHW_1
{
    //2.1 Тесты массивов на mas[null], mas[0], mas[10], mas[10,20], mas [many_even], mas [many_odd]
    //Найти минимальный элемент массива
    [TestClass]
    public class UnitTestArrays
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMinEl_null()
        {
            int[] array = null;
            int res = Arrays.MinEl(array);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMinEl_zero()
        {
            int[] array = { };
            int res = Arrays.MinEl(array);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestMinEl_one()
        {
            int[] array = { 10 };
            int res = Arrays.MinEl(array);
            Assert.AreEqual(10, res);
        }

        [TestMethod]
        public void TestMinEl_two()
        {
            int[] array = { 10, 20 };
            int res = Arrays.MinEl(array);
            Assert.AreEqual(10, res);
        }

        [TestMethod]
        public void TestMinEl_many()
        {
            int[] array = { 20, 20, 77, 99, 5, 89, 1 };
            int res = Arrays.MinEl(array);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMaxEl_null()
        {
            int[] array = null;
            int res = Arrays.MaxEl(array);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMaxEl_zero()
        {
            int[] array = { };
            int res = Arrays.MaxEl(array);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestMaxEl_one()
        {
            int[] array = { 10 };
            int res = Arrays.MaxEl(array);
            Assert.AreEqual(10, res);
        }

        [TestMethod]
        public void TestMaxEl_two()
        {
            int[] array = { 10, 20 };
            int res = Arrays.MaxEl(array);
            Assert.AreEqual(20, res);
        }

        [TestMethod]
        public void TestMaxEl_many()
        {
            int[] array = { 20, 20, 77, 99, 5, 89, 1 };
            int res = Arrays.MaxEl(array);
            Assert.AreEqual(99, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMinIndex_null()
        {
            int[] array = null;
            int res = Arrays.MinIndex(array);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMinIndex_zero()
        {
            int[] array = { };
            int res = Arrays.MinIndex(array);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestMinIndex_one()
        {
            int[] array = { 0 };
            int res = Arrays.MinIndex(array);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestMinIndex_two()
        {
            int[] array = { 10, 20 };
            int res = Arrays.MinIndex(array);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestMinIndex_many()
        {
            int[] array = { 20, 20, 77, 99, 5, 89, 1 };
            int res = Arrays.MinIndex(array);
            Assert.AreEqual(6, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMaxIndex_null()
        {
            int[] array = null;
            int res = Arrays.MaxIndex(array);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMaxIndex_zero()
        {
            int[] array = { };
            int res = Arrays.MaxIndex(array);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestMaxIndex_one()
        {
            int[] array = { 0 };
            int res = Arrays.MaxIndex(array);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestMaxIndex_two()
        {
            int[] array = { 10, 20 };
            int res = Arrays.MaxIndex(array);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestMaxIndex_many()
        {
            int[] array = { 20, 20, 77, 99, 5, 89, 1 };
            int res = Arrays.MaxIndex(array);
            Assert.AreEqual(3, res);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCountOdd_null()
        {
            int[] array = null;
            int res = Arrays.CountOdd(array);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCountOdd_zero()
        {
            int[] array = { };
            int res = Arrays.CountOdd(array);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCountOdd_one()
        {
            int[] array = { 0 };
            int res = Arrays.CountOdd(array);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestCountOdd_twoEven()
        {
            int[] array = { 10, 20 };
            int res = Arrays.CountOdd(array);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestCountOdd_twoOdd()
        {
            int[] array = { 11, 21 };
            int res = Arrays.CountOdd(array);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestCountOdd_many()
        {
            int[] array = { 20, 20, 77, 99, 5, 89, 1 };
            int res = Arrays.CountOdd(array);
            Assert.AreEqual(5, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestOddIndexSum_null()
        {
            int[] array = null;
            int res = Arrays.OddIndexSum(array);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestOddIndexSum_zero()
        {
            int[] array = { };
            int res = Arrays.OddIndexSum(array);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestOddIndexSum_one()
        {
            int[] array = { 0 };
            int res = Arrays.OddIndexSum(array);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestOddIndexSum_two()
        {
            int[] array = { 10, 20 };
            int res = Arrays.OddIndexSum(array);
            Assert.AreEqual(20, res);
        }

        [TestMethod]
        public void TestOddIndexSum_many()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            int res = Arrays.OddIndexSum(array);
            Assert.AreEqual(12, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestReverse_null()
        {
            int[] array = null;
            int res = Arrays.OddIndexSum(array);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestReverse_zero()
        {
            int[] array = { };
            Arrays.Reverse(array);
            Assert.AreEqual(1, array);
        }

        [TestMethod]
        public void TestReverse_one()
        {
            int[] array = { 0 };
            Arrays.Reverse(array);
            int[] exp = { 0 };
            CollectionAssert.AreEqual(exp, array);
        }

        [TestMethod]
        public void TestReverse_two()
        {
            int[] array = { 10, 20 };
            int[] res = Arrays.Reverse(array);
            int[] exp = { 20, 10 };
            CollectionAssert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestReverse_many()
        {
            int[] array = { 1, 2, 3, 4 };
            int[] res = Arrays.Reverse(array);
            int[] exp = { 4, 3, 2, 1 }; 
            CollectionAssert.AreEqual(exp, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestHalfSwapped_null()
        {
            int[] array = null;
            int[] res = Arrays.HalfSwapped(array);
            int[] exp = null;
            CollectionAssert.AreEqual(exp, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestHalfSwapped_zero()
        {
            int[] array = { };
            int[] res = Arrays.HalfSwapped(array);
            int[] exp = { };
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestHalfSwapped_one()
        {
            int[] array = { 0 };
            int[] res = Arrays.HalfSwapped(array);
            int[] exp = { 0 };
            CollectionAssert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestHalfSwapped_two()
        {
            int[] array = { 10, 20 };
            int[] res = Arrays.HalfSwapped(array);
            int[] exp = { 20, 10 };
            CollectionAssert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestHalfSwapped_manyEven()
        {
            int[] array = { 1, 2, 3, 4 };
            int[] res = Arrays.HalfSwapped(array);
            int[] exp = { 3, 4, 1, 2 };
            CollectionAssert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestHalfSwapped_manyOdd()
        {
            int[] array = { 1, 2, 3, 4, 5};
            int[] res = Arrays.HalfSwapped(array);
            int[] exp = { 4, 5, 1, 2, 3 };
            CollectionAssert.AreEqual(exp, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBubbleSorted_null()
        {
            int[] array = null;
            Arrays.BubbleSorted(array);
            int[] exp = null;
            CollectionAssert.AreEqual(exp, array);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBubbleSorted_zero()
        {
            int[] array = { };
            Arrays.BubbleSorted(array);
            int[] exp = { };
            Assert.AreEqual(exp, array);
        }

        [TestMethod]
        public void TestBubbleSorted_one()
        {
            int[] array = { 0 };
            Arrays.BubbleSorted(array);
            int[] exp = { 0 };
            CollectionAssert.AreEqual(exp, array);
        }

        [TestMethod]
        public void TestBubbleSorted_two()
        {
            int[] array = { 8, 4 };
            Arrays.BubbleSorted(array);
            int[] exp = { 4, 8 };
            CollectionAssert.AreEqual(exp, array);
        }

        [TestMethod]
        public void TestBubbleSorted_many()
        {
            int[] array = { 4, 8, 3, 7 };
            Arrays.BubbleSorted(array);
            int[] exp = { 3, 4, 7, 8 };
            CollectionAssert.AreEqual(exp, array);
        }

        [DataTestMethod]
        [DataRow(new int[] { 4 }, new int[] { 4 })]
        [DataRow(new int[] { 4, 8 }, new int[] { 4, 8 })]
        [DataRow(new int[] { 4, 8, 3, 7 }, new int[] { 3, 4, 7, 8 })]
        public void TestSelectSorted(int [] array, int[] exp)
        {
            Arrays.SelectSorted(array);
            CollectionAssert.AreEqual(exp, array);
        }

        [DataTestMethod]
        [DataRow(null, new int[] { })]
        [DataRow(new int[] { }, new int[] { })]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSelectSortedException(int[] array, int[] exp)
        {
            Arrays.SelectSorted(array);
        }

        [DataTestMethod]
        [DataRow(new int[] { 4 }, new int[] { 4 })]
        [DataRow(new int[] { 4, 8 }, new int[] { 4, 8 })]
        [DataRow(new int[] { 4, 8, 3, 7 }, new int[] { 3, 4, 7, 8 })]
        public void TestInsertSorted(int[] array, int[] exp)
        {
            Arrays.InsertSorted(array);
            CollectionAssert.AreEqual(exp, array);
        }

        [DataTestMethod]
        [DataRow(null, new int[] { })]
        [DataRow(new int[] { }, new int[] { })]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInsertSortedException(int[] array, int[] exp)
        {
            Arrays.InsertSorted(array);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestQuickSorted_null()
        {
            int[] array = null;
            Arrays.QuickSorted(array);
            int[] exp = null;
            CollectionAssert.AreEqual(exp, array);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestQuickSorted_zero()
        {
            int[] array = { };
            Arrays.QuickSorted(array);
            int[] exp = { };
            Assert.AreEqual(exp, array);
        }

        [TestMethod]
        public void TestQuickSorted_one()
        {
            int[] array = { 0 };
            Arrays.QuickSorted(array);
            int[] exp = { 0 };
            CollectionAssert.AreEqual(exp, array);
        }

        [TestMethod]
        public void TestQuickSorted_two()
        {
            int[] array = { 8, 4 };
            Arrays.QuickSorted(array);
            int[] exp = { 4, 8 };
            CollectionAssert.AreEqual(exp, array);
        }

        [TestMethod]
        public void TestQuickSorted_many()
        {
            int[] array = { 4, 8, 3, 7 };
            Arrays.QuickSorted(array);
            int[] exp = { 3, 4, 7, 8 };
            CollectionAssert.AreEqual(exp, array);
        }


    }
}
