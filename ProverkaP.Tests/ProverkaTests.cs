using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProverkaP.Tests
{
    [TestClass]
    public class ProverkaP
    {
        [TestMethod]
        public void Check_Qwerty1234_0()
        {
            string a = "";
            int expected = 0;
            // act
            PrvP calc = new PrvP();
            int actual = calc.CheckPass(a);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_Qwerty1234_5()
        {
            string a = "Qwerty_1234";
            int expected = 5;
            // act
            PrvP calc = new PrvP();
            int actual = calc.CheckPass(a);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_Qw_efgrtyddd_4()
        {
            string a = "Qw_efgrtyddd";
            int expected = 4;
            // act
            PrvP calc = new PrvP();
            int actual = calc.CheckPass(a);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_qwertywdwdw_2()
        {
            string a = "qwertywdwdw";
            int expected = 2;
            // act
            PrvP calc = new PrvP();
            int actual = calc.CheckPass(a);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_qwerty_1()
        {
            string a = "qwerty";
            int expected = 1;
            // act
            PrvP calc = new PrvP();
            int actual = calc.CheckPass(a);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_QWERTY129q_3()
        {
            string a = "QTY129q";
            int expected = 3;
            // act
            PrvP calc = new PrvP();
            int actual = calc.CheckPass(a);
            // assert
            Assert.AreEqual(expected, actual);
        }
    }

}
