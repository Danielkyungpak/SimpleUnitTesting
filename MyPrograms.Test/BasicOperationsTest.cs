using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyPrograms;

namespace MyPrograms.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            //Assemble
            BasicOperations basicOp = new BasicOperations();
            int expected = 5;
            
            //Act
            int actualResult = basicOp.Add(2, 3);

            //Assert
            Assert.AreEqual(expected, actualResult);

        }

        [TestMethod]
        public void TestSub()
        {
            //Assemble
            BasicOperations basicOp = new BasicOperations();
            int expected = 5;

            //Act
            int actualResult = basicOp.Sub(10, 5);

            //Assert
            Assert.AreEqual(expected, actualResult);

        }

        [TestMethod]
        public void TestMul()
        {
            //Assemble
            BasicOperations basicOp = new BasicOperations();
            int expected = 6;

            //Act
            int actualResult = basicOp.Mul(2, 3);

            //Assert
            Assert.AreEqual(expected, actualResult);

        }

        [TestMethod]
        public void TestDiv()
        {
            //Assemble
            BasicOperations basicOp = new BasicOperations();
            int expected = 3;

            //Act
            int actualResult = basicOp.Div(10, 5);

            //Assert
            Assert.AreNotEqual(expected, actualResult);

        }
    }
}
