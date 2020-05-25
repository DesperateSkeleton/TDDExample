using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week4_6Robert2;

namespace IndexerTest
{
    [TestClass]
    public class SystemOLETest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FailWithIndexing1()
        {
            SystemOLE listofcoef = new SystemOLE(4);
            listofcoef[0] = new LinearEquation("1, 2, 3, 4");
            listofcoef[1] = new LinearEquation("3, 5, 7, 9");
            listofcoef[2] = new LinearEquation("5, 8, 4, 2");
            listofcoef[3] = new LinearEquation("2, 14, 8, 11");
            Assert.Equals(typeof(ArgumentOutOfRangeException), listofcoef[-1]);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FailWithIndexing2()
        {
            SystemOLE listofcoef = new SystemOLE(4);
            listofcoef[0] = new LinearEquation("1, 2, 3, 4");
            listofcoef[1] = new LinearEquation("3, 5, 7, 9");
            listofcoef[2] = new LinearEquation("5, 8, 4, 2");
            listofcoef[3] = new LinearEquation("2, 14, 8, 11");
            Assert.Equals(typeof(ArgumentOutOfRangeException), listofcoef[7]);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InfinitySolutionsChecking()
        {
            SystemOLE listofcoef = new SystemOLE(4);
            listofcoef.Add(new LinearEquation("1, 2, 3, 4"));
            listofcoef.Add(new LinearEquation("3, 5, 7, 9"));
            listofcoef.Add(new LinearEquation("5, 8, 4, 2"));
            listofcoef.Add(new LinearEquation("2, 14, 8, 11"));
            listofcoef.StepConvert();
            Assert.Equals(typeof(ArgumentException), listofcoef.GaussMethod());
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NoMoreSolutionsChecking()
        {
            SystemOLE listofcoef = new SystemOLE(4);
            listofcoef.Add(new LinearEquation("1, 2, 3, 4"));
            listofcoef.Add(new LinearEquation("15, 35, 14, 9"));
            listofcoef.Add(new LinearEquation("12, 45, 89, 0"));
            listofcoef.Add(new LinearEquation("1, 2, 3, 6"));
            listofcoef.StepConvert();
            Assert.Equals(typeof(ArgumentException), listofcoef.GaussMethod());
        }
    }
}
