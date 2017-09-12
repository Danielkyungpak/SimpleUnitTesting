using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyPrograms.Test
{
    [TestClass]
    public class TTDProgramsTest
    {
        [TestMethod]
        public void TestSmallest()
        {
            //Assemble
            TTDPrograms ttd = new TTDPrograms();
            int[] arr = { 9, 3, 5, 7, 8 };
            int expectedValue = 3;

            //Act
            int actualValue = ttd.Smallest(arr);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        
        }
        [TestMethod]
        public void TestSmallest_WithSizeOne()
        {
            //Assemble
            TTDPrograms ttd = new TTDPrograms();
            int[] arr = { 9};
            int expectedValue = 9;

            //Act
            int actualValue = ttd.Smallest(arr);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);

        }

        [TestMethod]
        public void TestPower()
        {
            //Assemble
            TTDPrograms ttd = new TTDPrograms();
            int baseValue = 2;
            int expValue = 3;
            int expectedValue = 8;

            //Act
            int actualValue = ttd.Power(baseValue, expValue);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);

        }
    }
}
