using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Registracija;

namespace RegistracijaUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IzpisRegistracijske()
        {
            Registracija.Registracija registracija = new Registracija.Registracija("LJ", "123AB");
            var izpis = registracija.RegistracijskaTablica();
            Assert.AreEqual("LJ 123AB", izpis, "Izpis registracije ni pravilen.");
        }

        [TestMethod]
        public void NepravilnoObmocje()
        {
            try
            {
                Registracija.Registracija registracija = new Registracija.Registracija("AB", "123AB");
            }
            catch (Exception e)
            {
                Assert.AreEqual("Neveljavno območje.", e.Message);
            }
        }

        [TestMethod]
        public void NerpavilenVnos()
        {
            try
            {
                Registracija.Registracija registracija = new Registracija.Registracija("12", "123AB");
            }
            catch (Exception e)
            {
                Assert.AreEqual("Območje mora biti iz dveh črk.", e.Message);
            }
        }

    }
}
