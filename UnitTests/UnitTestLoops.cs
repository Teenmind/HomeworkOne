using System;
using HW_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestHW_1
{
    [TestClass]
    public class UnitTestLoops
    {
        [TestMethod]
        public void TestSumAndNumOfEvenFrom1to99_Sum()
        {
            int res = Loops.SumAndNumOfEvenFrom1to99_Sum();
            Assert.AreEqual(2450, res);
        }

        [TestMethod]
        public void TestSumAndNumOfEvenFrom1to99_Num()
        {
            int res = Loops.SumAndNumOfEvenFrom1to99_Num();
            Assert.AreEqual(49, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestFactorial_m1()
        {
            int res = Loops.Factorial(-1);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestFactorial_0()
        {
            int res = Loops.Factorial(0);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestFactorial_3()
        {
            int res = Loops.Factorial(3);
            Assert.AreEqual(6, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSimple_m1()
        {
            bool res = Loops.Simple(-1);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void TestSimple_true13()
        {
            bool res = Loops.Simple(13);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestSimple_false8()
        {
            bool res = Loops.Simple(8);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void TestMirrored_m1()
        {
            int res = Loops.Mirrored(-123);
            Assert.AreEqual(-321, res);
        }

        [TestMethod]
        public void TestMirrored_123()
        {
            int res = Loops.Mirrored(123);
            Assert.AreEqual(321, res);
        }

        [TestMethod]
        public void TestMirrored_343()
        {
            int res = Loops.Mirrored(343);
            Assert.AreEqual(343, res);
        }

        [TestMethod]
        public void TestMirrored_0InTheEnd()
        {
            int res = Loops.Mirrored(240);
            Assert.AreEqual(42, res);
        }

        [TestMethod]
        public void TestMirrored_0InTheMiddle()
        {
            int res = Loops.Mirrored(105);
            Assert.AreEqual(501, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSqrtToInt_m1()
        {
            int res = Loops.SqrtToInt(-1);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestSqrtToInt_zero()
        {
            int res = Loops.SqrtToInt(0);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestSqrtToInt_accurate49()
        {
            int res = Loops.SqrtToInt(49);
            Assert.AreEqual(7, res);
        }

        [TestMethod]
        public void TestSqrtToInt_cutting50()
        {
            int res = Loops.SqrtToInt(50);
            Assert.AreEqual(7, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSumOfNaturalDigits_mNumber()
        {
            int res = Loops.SumOfNaturalDigits(-123);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestSumOfNaturalDigits_pNumber()
        {
            int res = Loops.SumOfNaturalDigits(123);
            Assert.AreEqual(6, res);
        }
    }
}
