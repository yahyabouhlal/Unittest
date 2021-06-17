using Calculatorr;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange  
            
            double expectedResult = 8;


            //Act  

            double actualResult = Calculator.Multiply(2,4);


            //Assert  

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
