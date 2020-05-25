using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week4_6Robert2;

namespace IndexerTest
{
    [TestClass]
    public class LinearEquationTest
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void FailWithWrongIndexing1()
        {
            string listofcoef = "1,3,5,7,9";
            var a = new LinearEquation(listofcoef);
            Assert.Equals(typeof(IndexOutOfRangeException), a[-1]);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FailWithWrongIndexing2()
        {
            string listofcoef = "1,3,5,7,9";
            var a = new LinearEquation(listofcoef);
            Assert.Equals(typeof(ArgumentOutOfRangeException), a[5]);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailWithNegativeArgument()
        {
            string listofcoef = "1,3,5,7,9";
            var a = new LinearEquation(listofcoef);
            Assert.Equals(typeof(ArgumentException), new LinearEquation(-5));
        }
        [TestMethod]
        public void IndexingChecking()
        {
            string listofcoef = "1,3,5,7,9";
            LinearEquation a = new LinearEquation(listofcoef);
            Assert.AreEqual(9, a[4]);
        }
        [TestMethod]
        public void ChechingInputWithoutRandom()
        {
            var a = new LinearEquation(4);
            a.Input(0);
            string listofcoef = "0,0,0,0";
            Assert.AreEqual(new LinearEquation(listofcoef), a);
        }
        [TestMethod]
        public void InitializationCheching()
        {
            List<double> listofcoef = new List<double>() { 2, 4, 6, 8, 10 };
            LinearEquation a = new LinearEquation(listofcoef);
            Assert.AreEqual(10, a[4]);
        }
        [TestMethod]
        public void OperatorCheching1()
        {
            string listofcoef1 = "1,2,3,5.6,12,9,0.8";
            LinearEquation a = new LinearEquation(listofcoef1);
            string listofcoef2 = "2,-4,6.9, 8.9,11,13.8, 15.5";
            LinearEquation b = new LinearEquation(listofcoef2);
            string result = "3,-2,9.9,14.5,23, 22.8, 16.3";
            Assert.AreEqual(new LinearEquation(result), a + b);
        }
        [TestMethod]
        public void OperatorCheching2()
        {
            string listofcoef1 = "1,2,3,5.6,12,9,0.8";
            LinearEquation a = new LinearEquation(listofcoef1);
            string listofcoef2 = "2,-4,6.9, 8.9,11,13.8, 15.5";
            LinearEquation b = new LinearEquation(listofcoef2);
            string result = "-1,6,-3.9,-3.3,1,-4.8,-14.7";
            Assert.AreEqual(new LinearEquation(result), a - b);
        }
        [TestMethod]
        public void OperatorCheching3()
        {
            string listofcoef1 = "1,2,3,5.6,12,9,0.8";
            LinearEquation a = new LinearEquation(listofcoef1);
            string result = "2,4,6,11.2,24,18,1.6";
            Assert.AreEqual(new LinearEquation(result), a * 2);
        }
        [TestMethod]
        public void OperatorCheching4()
        {
            string listofcoef1 = "1,2,3,5.6,12,9,0.8";
            LinearEquation a = new LinearEquation(listofcoef1);
            string result = "-1,-2,-3,-5.6,-12,-9,-0.8";
            Assert.AreEqual(new LinearEquation(result), a * (-1));
        }
        [TestMethod]
        public void WrongEquationCheching()
        {
            string listofcoef1 = "0,0,0,0,0,0,0.8";
            LinearEquation a = new LinearEquation(listofcoef1);
            bool pp;
            if (a) pp = true;
            else pp = false;
            Assert.AreEqual(pp, false);
        }
        [TestMethod]
        public void CorrectlyEquationCheching()
        {
            string listofcoef1 = "1,2,3,5.6,12,9,0.8";
            LinearEquation a = new LinearEquation(listofcoef1);
            bool pp;
            if (a) pp = true;
            else pp = false;
            Assert.AreEqual(pp, true);
        }
    }
}
