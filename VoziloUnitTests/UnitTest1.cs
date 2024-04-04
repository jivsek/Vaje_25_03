using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Vozilo;

namespace VoziloUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PrevoziPot_Test()
        {
            Vozilo.Vozilo moje_vozilo = new Vozilo.Vozilo(50, 5);
            double[] pot = new double[] { 200, 0, 100, 60, 0, 100 };
            Assert.IsTrue(moje_vozilo.LahkoPrevozi(pot));

            pot = new double[] { 200, 0, 100, 60, 0, 100, 500, 250, 300 };
            Assert.IsFalse(moje_vozilo.LahkoPrevozi(pot));

            pot = new double[] { 200, 0, 0, 100, 60, 0, 100 };
            try
            {
                bool lahko = moje_vozilo.LahkoPrevozi(pot);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Dve zaporedni polnjenji.", e.Message);                
            }

            pot = new double[] { 200, 0, -100, 60, 0, 100 };
            try
            {
                bool lahko = moje_vozilo.LahkoPrevozi(pot);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Pot ne mora biti negativna.", e.Message);
            }
        }
    }
}
