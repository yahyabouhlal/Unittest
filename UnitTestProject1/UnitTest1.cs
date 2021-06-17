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
            
            double expectedResult = 16;


            //Act  

            double actualResult = Calculator.Add(8, 8);


            //Assert  

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
