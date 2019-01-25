using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeveloperEvaluation.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeveloperEvaluation;

namespace DeveloperEvaluation.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void FindMeanSingleNumberTest()
        {
            List<int> testList = new List<int> { 1 };
            HomeController testController = new HomeController();
            double expectedMean = 1;
            double actualMean = testController.FindMean(testList);
            Assert.AreEqual(expectedMean, actualMean);
        }
        [TestMethod()]
        public void FindMeanTwoNumbersTest()
        {
            List<int> testList = new List<int> { 1, 2 };
            HomeController testController = new HomeController();
            double expectedMean = 1.5;
            double actualMean = testController.FindMean(testList);
            Assert.AreEqual(expectedMean, actualMean);
        }
        [TestMethod()]
        public void FindMeanEmptyTest()
        {
            List<int> testList = new List<int>();
            HomeController testController = new HomeController();
            double expectedMean = 0;
            double actualMean = testController.FindMean(testList);
            Assert.AreEqual(expectedMean, actualMean);
        }

        [TestMethod()]
        public void FindMedianSingleNumberTest()
        {
            List<int> testList = new List<int> { 1 };
            HomeController testController = new HomeController();
            double expectedMedian = 1;
            double actualMedian = testController.FindMedian(testList);
            Assert.AreEqual(expectedMedian, actualMedian);
        }
        [TestMethod()]
        public void FindMedianTwoNumbersTest()
        {
            List<int> testList = new List<int> { 1, 2 };
            HomeController testController = new HomeController();
            double expectedMedian = 1.5;
            double actualMedian = testController.FindMedian(testList);
            Assert.AreEqual(expectedMedian, actualMedian);
        }
        [TestMethod()]
        public void FindMedianEmptyTest()
        {
            List<int> testList = new List<int>();
            HomeController testController = new HomeController();
            double expectedMedian = 0;
            double actualMedian = testController.FindMedian(testList);
            Assert.AreEqual(expectedMedian, actualMedian);
        }
        [TestMethod()]
        public void FindMedianOutOfOrderListTest()
        {
            List<int> testList = new List<int> { 6, 1, 5, 2, 3 };
            HomeController testController = new HomeController();
            double expectedMedian = 3;
            double actualMedian = testController.FindMedian(testList);
            Assert.AreEqual(expectedMedian, actualMedian);
        }

        [TestMethod()]
        public void FindModeSingleNumberTest()
        {
            List<int> testList = new List<int> { 1 };
            HomeController testController = new HomeController();
            List<int> expectedMode = new List<int> { 1 };
            List<int> actualMode = testController.FindMode(testList);
            CollectionAssert.AreEqual(expectedMode, actualMode);
        }
        [TestMethod()]
        public void FindModeOneModeTest()
        {
            List<int> testList = new List<int> { 1, 1, 1, 2 };
            HomeController testController = new HomeController();
            List<int> expectedMode = new List<int> { 1 };
            List<int> actualMode = testController.FindMode(testList);
            CollectionAssert.AreEqual(expectedMode, actualMode);
        }
        [TestMethod()]
        public void FindModeTwoModesTest()
        {
            List<int> testList = new List<int> { 1, 2, 1, 2, 1, 2, 3 };
            HomeController testController = new HomeController();
            List<int> expectedMode = new List<int> { 1, 2 };
            List<int> actualMode = testController.FindMode(testList);
            CollectionAssert.AreEqual(expectedMode, actualMode);
        }
        [TestMethod()]
        public void FindModeEmptyTest()
        {
            List<int> testList = new List<int>();
            HomeController testController = new HomeController();
            List<int> expectedMode = new List<int>();
            List<int> actualMode = testController.FindMode(testList);
            CollectionAssert.AreEqual(expectedMode, actualMode);
        }

        [TestMethod()]
        public void ConvertStringToIntsOneElementTest()
        {
            string testList = "1";
            HomeController testController = new HomeController();
            List<int> expectedList = new List<int> { 1 };
            List<int> actualList = testController.ConvertStringToInts(testList);
            CollectionAssert.AreEqual(expectedList, actualList);
        }
        [TestMethod()]
        public void ConvertStringToIntsMultipleElementsTest()
        {
            string testList = "1,2,4,5,10";
            HomeController testController = new HomeController();
            List<int> expectedList = new List<int> { 1, 2, 4, 5, 10 };
            List<int> actualList = testController.ConvertStringToInts(testList);
            CollectionAssert.AreEqual(expectedList, actualList);
        }
        [TestMethod()]
        public void ConvertStringToIntsEmptyTest()
        {
            string testList = "";
            HomeController testController = new HomeController();
            List<int> expectedList = new List<int>();
            List<int> actualList = testController.ConvertStringToInts(testList);
            CollectionAssert.AreEqual(expectedList, actualList);
        }
        [TestMethod()]
        public void ConvertStringToIntsWrongFormattingTest()
        {
            string testList = "1,two,,3";
            HomeController testController = new HomeController();
            List<int> expectedList = new List<int> { 1, 3 };
            List<int> actualList = testController.ConvertStringToInts(testList);
            CollectionAssert.AreEqual(expectedList, actualList);
        }

        [TestMethod()]
        public void ConvertIntsToStringOneElementTest()
        {
            List<int> testList = new List<int> { 1 };
            HomeController testController = new HomeController();
            string expectedList = "1";
            string actualList = testController.ConvertIntsToString(testList);
            Assert.AreEqual(expectedList, actualList);
        }
        [TestMethod()]
        public void ConvertIntsToStringManyElementsTest()
        {
            List<int> testList = new List<int> { 1, 2, 10, 4 };
            HomeController testController = new HomeController();
            string expectedList = "1,2,10,4";
            string actualList = testController.ConvertIntsToString(testList);
            Assert.AreEqual(expectedList, actualList);
        }
        [TestMethod()]
        public void ConvertIntsToStringEmptyTest()
        {
            List<int> testList = new List<int> ();
            HomeController testController = new HomeController();
            string expectedList = "";
            string actualList = testController.ConvertIntsToString(testList);
            Assert.AreEqual(expectedList, actualList);
        }
    }
}