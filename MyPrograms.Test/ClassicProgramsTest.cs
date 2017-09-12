using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyPrograms;

namespace MyPrograms.Test
{
    [TestClass]
    public class ClassicProgramsTest
    {
        [TestMethod]
        public void TestIsEven()
        {
            //Assemble
            ClassicPrograms classic = new ClassicPrograms();
            bool expectedResult = true;

            //Act
            bool actualResult = classic.IsEven(8);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestIsNotEven()
        {
            //Assemble
            ClassicPrograms classic = new ClassicPrograms();
            bool expectedResult = false;

            //Act
            bool actualResult = classic.IsEven(7);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestIsOdd()
        {
            //Assemble
            ClassicPrograms classic = new ClassicPrograms();
            bool expectedResult = true;

            //Act
            bool actualResult = classic.IsOdd(7);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestIsNotOdd()
        {
            //Assemble
            ClassicPrograms classic = new ClassicPrograms();
            bool expectedResult = false;

            //Act
            bool actualResult = classic.IsOdd(8);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestIsNotPrime_WithNegativeValue()
        {
            //Assemble
            ClassicPrograms classic = new ClassicPrograms();
            bool expectedResult = false;

            //Act
            bool actualResult = classic.IsPrime(-1);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestIsPrime_With0and1()
        {
            //Assemble
            ClassicPrograms classic = new ClassicPrograms();
            bool expectedResult = true;

            //Act
            bool actualResult = classic.IsPrime(1);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestIsPrime_WithTruePrimeValue()
        {
            //Assemble
            ClassicPrograms classic = new ClassicPrograms();
            bool expectedResult = true;

            //Act
            bool actualResult = classic.IsPrime(13);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestIsPrime_WithFalsePrimeValue()
        {
            //Assemble
            ClassicPrograms classic = new ClassicPrograms();
            bool expectedResult = false;

            //Act
            bool actualResult = classic.IsPrime(12);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



    }
}
