using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator_66_NguyenHuuToan;
namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Caculation_66_NguyenHuuToan c;

        public TestContext TestContext{ get; set; }
        [TestInitialize] // thiet lap du lieu dung chung cho TC
        public void SetUp()
        {
            c = new Caculation_66_NguyenHuuToan(10, 5);
        }
        [TestMethod] //TC1: a =10, b = 5, kq= 15
        public void Test_Cong_66_NguyenHuuToan()
        {
            int expected, actual;
            expected = 15;
            actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] //TC1: a =10, b = 5, kq= 5
        public void Test_Tru_66_NguyenHuuToan()
        {
            int expected, actual;
            expected = 5;
            actual = c.Execute("-");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] //TC1: a =10, b = 5, kq= 50
        public void Test_Nhan_66_NguyenHuuToan()
        {
            int expected, actual;
            expected = 50;
            actual = c.Execute("*");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] //TC1: a =10, b = 5, kq= 2
        public void Test_Chia_66_NguyenHuuToan()
        {
            int expected, actual;
            expected = 2;
            actual = c.Execute("/");
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_ChiaZero_66_NguyenHuuToan()
        {
            c = new Caculation_66_NguyenHuuToan(10, 0);
            c.Execute("/");
        }


        //Lien ket Data vs project

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
           @"D:\Calculator_66_NguyenHuuToan\CalculatorTester_66_NguyenHuutoan\Data\TestData2.csv", "TestData2#csv", DataAccessMethod.Sequential)]

        public void Test_Cong_with_DataOperation_NguyenHuuToan_66()
        {
            int a,b ,expected, actual;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            expected = int.Parse(TestContext.DataRow[2].ToString());
            c = new Caculation_66_NguyenHuuToan(a, b);
            actual = c.Execute("+");
            Assert.AreEqual(expected, actual);  
        }
    }
}
