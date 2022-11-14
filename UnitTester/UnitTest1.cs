using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _2054050254_TranNgocTrung;
using System.Collections.Generic;

namespace UnitTester
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        public void TestBT1T()
        {
            double x = 2;
            int n = 0;
            double momgdoi = 1;
            Assert.AreEqual(momgdoi, BT1.Power(x, n));
        }
        [TestMethod]
        public void TestBT1TF()
        {
            double x = 3;
            int n = 2;
            double momgdoi = 9;
            Assert.AreEqual(momgdoi, BT1.Power(x, n));
        }
        [TestMethod]
        public void TestBT1FF()
        {
            double x = 2;
            int n = -1;
            double momgdoi = 0;
            Assert.AreEqual(momgdoi, BT1.Power(x, n));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBT2THS1()

        {
            int n = -1;
            int y = 1;
            List<int> ListSo = new List<int> { 1 };
            BT2 p = new BT2(n, ListSo);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBT2THS2()

        {
            int n = 2;
            int y = 1;
            List<int> ListSo = new List<int> { 3, 4 };
            BT2 p = new BT2(n, ListSo);
        }
        [TestMethod]
        public void TestBT2THD1()

        {
            int n = 2;
            int y = 1;
            List<int> listSo = new List<int> { 2, 3, 0 };
            BT2 p = new BT2(n, listSo);
            //int mongdoi = 5;
            Assert.AreEqual(5, p.Cal(y));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBT3THF1()
        {
            int r = 2;
            int n = -1;
            BT3 p = new BT3(n);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBT3THF2()
        {
            int r = 1;
            int n = 5;
            BT3 p = new BT3(n);
            string mongdoi = "110";
            Assert.AreEqual(mongdoi, p.ConvertDecimalToAnother(r));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBT3THF3()
        {
            int r = 17;
            int n = 5;
            BT3 p = new BT3(n);
            string mongdoi = "110";
            Assert.AreEqual(mongdoi, p.ConvertDecimalToAnother(r));
        }
        [TestMethod]
        public void TestBT3THT1()
        {
            int r = 2;
            int n = 6;
            BT3 p = new BT3(n);
            string mongdoi = "110";
            Assert.AreEqual(mongdoi, p.ConvertDecimalToAnother(r));
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
           @"D.\Data\Testdata.CSV"),"Testdata#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestBai3THT2()
        {
            int r = int.Parse(TestContext.DataRow[0].ToString());
            int n = int.Parse(TestContext.DataRow[1].ToString());
            string mongdoi = TestContext.DataRow[2].ToString();
            mongdoi = mongdoi.Remove(0, 1);
            BT3 P = new BT3(n);
            Assert.AreEqual(mongdoi, P.ConvertDecimalToAnother(r));

        }
    } 
}

 