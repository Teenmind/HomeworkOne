using System;
using HW_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestHW_1
{
    [TestClass]
    public class UnitTestConditions
    {

        [TestMethod]
        public void TestEvenAMultBOddAPlusB_Odd()
        {
            int res = Conditions.EvenAMultBOddAPlusB(3, 5);
            Assert.AreEqual(8, res);
        }

        [TestMethod]
        public void TestEvenAMultBOddAPlusB_Even()
        {
            int res = Conditions.EvenAMultBOddAPlusB(2,3);
            Assert.AreEqual(6, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestQuarter_xZero()
        {
            int res = Conditions.Quarter(0, 5);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestQuarter_yZero()
        {
            int res = Conditions.Quarter(5, 0);
            Assert.AreEqual(1, res);
        }

        [DataTestMethod]
        [DataRow(5, 5, 1)]
        [DataRow(-5, 5, 2)]
        [DataRow(-5, -5, 3)]
        [DataRow(5, -5, 4)]


        [TestMethod]
        public void TestQuarter(int x, int y, int exp)
        {
            int res = Conditions.Quarter(x, y);
            Assert.AreEqual(exp, res);
        }

        [DataTestMethod]
        [DataRow(-1, -1, -1, 0)]
        [DataRow(1, 1, 1, 3)]
        [DataRow(-1, 1, 1, 2)]
        [DataRow(1, -1, 1, 2)]
        [DataRow(1, 1, -1, 2)]     

        [TestMethod]
        public void TestSumPositiveNum(int a, int b, int c, int exp)
        {
            int res = Conditions.SumPositiveNum(a,b,c);
            Assert.AreEqual(exp, res);
        }


        [DataTestMethod]
        [DataRow(2, 2, 2, 11)]
        [DataRow(1, 1, 1, 6)]
        [DataRow(0, 0, 0, 3)]

        [TestMethod]
        public void TestMaxOfaPbPc_aMbMcPlus3(int a, int b, int c, int exp)
        {
            int res = Conditions.MaxOfaPbPc_aMbMcPlus3(a, b, c);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRating_Ex_m1()
        {
            char res = Conditions.Rating(-1);
            Assert.AreEqual('F', res);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRating_Ex_101()
        {
            char res = Conditions.Rating(101);
            Assert.AreEqual('F', res);
        }

        [DataTestMethod]
        [DataRow(0, 'F')]
        [DataRow(10, 'F')]
        [DataRow(19, 'F')]
        [DataRow(20, 'E')]
        [DataRow(30, 'E')]
        [DataRow(39, 'E')]
        [DataRow(40, 'D')]
        [DataRow(50, 'D')]
        [DataRow(59, 'D')]
        [DataRow(60, 'C')]
        [DataRow(67, 'C')]
        [DataRow(74, 'C')]
        [DataRow(75, 'B')]
        [DataRow(83, 'B')]
        [DataRow(89, 'B')]
        [DataRow(90, 'A')]
        [DataRow(95, 'A')]
        [DataRow(100, 'A')]

        [TestMethod]
        public void TestRating(int rating, char exp)
        {
            char res = Conditions.Rating(rating);
            Assert.AreEqual(exp, res);
        }
    }
}
