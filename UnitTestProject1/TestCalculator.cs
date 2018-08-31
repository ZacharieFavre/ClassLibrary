using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void testAdd()
        {
            ClassLibrary1.Calculator testCalculator = new ClassLibrary1.Calculator();

            int resExpected = 4;
            int resActual = 0;

            resActual = testCalculator.additionner(1, 3);

            Assert.AreEqual(resExpected, resActual);
        }

        [TestMethod]
        public void testSous()
        {
            ClassLibrary1.Calculator testCalculator = new ClassLibrary1.Calculator();

            int resExpected = 4;
            int resActual = 0;

            resActual = testCalculator.soustraire(7, 3);

            Assert.AreEqual(resExpected, resActual);
        }

        [TestMethod]
        public void testMult()
        {
            ClassLibrary1.Calculator testCalculator = new ClassLibrary1.Calculator();

            int resExpected = 4;
            int resActual = 0;

            resActual = testCalculator.multiplier(2, 2);

            Assert.AreEqual(resExpected, resActual);
        }

        [TestMethod]
        public void testDiv()
        {
            ClassLibrary1.Calculator testCalculator = new ClassLibrary1.Calculator();

            int resExpected = 4;
            int resActual = 0;

            resActual = testCalculator.diviser(8, 2);

            Assert.AreEqual(resExpected, resActual);
        }
    }
}
