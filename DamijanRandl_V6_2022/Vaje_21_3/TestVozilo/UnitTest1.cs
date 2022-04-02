using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Vaje_21_3;
namespace TestVozilo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Assert.AreEqual(1, 1);

            Vozilo audi = new Vozilo(50.0, 8.2);
            Assert.AreEqual(audi.Poraba(), 8.2);
            Assert.AreEqual(audi.Kapaciteta(), 50.0);
            Assert.AreEqual(audi.Gorivo(), 50.0);

        }
        [TestMethod]
        public void TestMethod2()
        {

            Vozilo audi = new Vozilo(50.0, 8.2);
            Assert.AreEqual(audi.Poraba(), 8.2);
            Assert.AreEqual(audi.Kapaciteta(), 50.0);
            Assert.AreEqual(audi.Gorivo(), 50.0);
            double[] tab = { 100.0 };
            Assert.AreEqual(audi.pot(tab), true);
            Assert.AreEqual(audi.Gorivo(), 41.8);

        }
        [TestMethod]
        public void TestMethod3()
        {

            Vozilo audi = new Vozilo(50.0, 8.2);
            Assert.AreEqual(audi.Poraba(), 8.2);

        }

    }
}
