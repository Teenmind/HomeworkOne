using System;
using HW_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestHW_1
{
    [TestClass]
    public class UnitTestFunctions
    {
        [DataTestMethod]
        [DataRow(1, "Sunday")]
        [DataRow(2, "Monday")]
        [DataRow(3, "Tuesday")]
        [DataRow(4, "Wednesday")]
        [DataRow(5, "Thursday")]
        [DataRow(6, "Friday")]
        [DataRow(7, "Saturday")]

        public void TestDayOfTheWeek(int day, string exp)
        {
            string res = Functions.DayOfTheWeek(day);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestDayOfTheWeek_0()
        {
            Functions.DayOfTheWeek(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestDayOfTheWeek_8()
        {
            Functions.DayOfTheWeek(8);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestNumToSpelled_m1()
        {
            Functions.DayOfTheWeek(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestNumToSpelled_1000()
        {
            Functions.DayOfTheWeek(1000);
        }

        [DataTestMethod]
        [DataRow(0, "zero")]
        [DataRow(1, "one")]
        [DataRow(5, "five")]
        [DataRow(9, "nine")]
        [DataRow(11, "eleven")]
        [DataRow(15, "fifteen")]
        [DataRow(19, "nineteen")]
        [DataRow(10, "ten")]
        [DataRow(50, "fifty")]
        [DataRow(90, "ninety")]
        [DataRow(34, "thirty four")]
        [DataRow(100, "one hundred")]
        [DataRow(500, "five hundred")]
        [DataRow(900, "nine hundred")]
        [DataRow(101, "one hundred one")]        
        [DataRow(150, "one hundred fifty")]
        [DataRow(050, "fifty")]
        [DataRow(199, "one hundred ninety nine")]
        [DataRow(381, "three hundred eighty one")]
        [DataRow(999, "nine hundred ninety nine")]

        [TestMethod]
        public void TestNumToSpelled(int value, string exp)
        {
            string res = Functions.NumToSpelled(value);
            Assert.AreEqual(exp, res);
        }

        [DataTestMethod]
        [DataRow(5, 5, 4, 4, 1)]
        [DataRow(-5, -5, -4, -4, 1)]
        [DataRow(0, 0, 0, 0, 0)]
        [DataRow(0, 0, 5, 5, 7)]
        [DataRow(5, 5, 0, 0, 7)]


        [TestMethod]
        public void TestDistance(double x1, double x2, double y1, double y2, double exp)
        {
            int res = (int)Functions.Distance(x1, x2, y1, y2);
            Assert.AreEqual(exp, res);
        }

        [DataTestMethod]
        [DataRow("zero", 0)]
        [DataRow("one", 1)]
        [DataRow("five", 5)]
        [DataRow("nine", 9)]
        [DataRow("ten", 10)]
        [DataRow("eleven", 11)]
        [DataRow("fifteen", 15)]
        [DataRow("nineteen", 19)]
        [DataRow("twenty one", 21)]
        [DataRow("fifty five", 55)]
        [DataRow("ninety nine", 99)]
        [DataRow("one hundred", 100)]
        [DataRow("five hundred", 500)]
        [DataRow("nine hundred", 900)]
        [DataRow("one hundred eleven", 111)]
        [DataRow("five hundred fifteen", 515)]
        [DataRow("nine hundred nineteen", 919)]
        [DataRow("one hundred twenty one", 121)]
        [DataRow("five hundred fifty five", 555)]
        [DataRow("nine hundred ninety nine", 999)]

        [TestMethod]
        public void TestSpelledToNum(string value, int exp)
        {
            int res = Functions.SpelledToNum(value);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSpelledToNum_m1()
        {
            int res = Functions.SpelledToNum("minus one");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSpelledToNum_moreThan4words()
        {
            int res = Functions.SpelledToNum("nine thousand nine hundred ninty one");
        }
        /*[TestMethod]
        public void TestDayOfTheWeek_1()
        {
            string exp = "Sunday";
            string res = Functions.DayOfTheWeek(1);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestDayOfTheWeek_2()
        {
            string exp = "Monday";
            string res = Functions.DayOfTheWeek(2);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestDayOfTheWeek_3()
        {
            string exp = "Tuesday";
            string res = Functions.DayOfTheWeek(3);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestDayOfTheWeek_4()
        {
            string exp = "Wednesday";
            string res = Functions.DayOfTheWeek(4);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestDayOfTheWeek_5()
        {
            string exp = "Thursday";
            string res = Functions.DayOfTheWeek(5);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestDayOfTheWeek_6()
        {
            string exp = "Friday";
            string res = Functions.DayOfTheWeek(6);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestDayOfTheWeek_7()
        {
            string exp = "Saturday";
            string res = Functions.DayOfTheWeek(7);
            Assert.AreEqual(exp, res);
        }*/
    }
}
