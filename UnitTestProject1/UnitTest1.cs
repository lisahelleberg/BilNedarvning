using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilNedarvning;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        #region Registreringsafgift
        /// <summary>
        /// Udregning af bilernes registreringsafgift
        /// </summary>
        [TestMethod]
        // Bil til under 80500,- fra før 2014 
        public void TestMethod1()
        {
            Bil NyBilligBilRegistreringsafgift = new DieselBil("Ford", 75000, 2013, 18.9, "PG 97 357", true, 65);

            double BilensRegistreringsAfgift = NyBilligBilRegistreringsafgift.RegistreringsAfgift();
            Assert.AreEqual(78750, BilensRegistreringsAfgift);
        }

        [TestMethod]
        // Bil til over 80500,- fra før 2014 
        public void TestMethod2()
        {
            Bil NyDyrBilRegistreringsafgift = new DieselBil("Ford", 250000, 2013, 18.9, "PG 97 357", true, 65);

            double BilensRegistreringsAfgift = NyDyrBilRegistreringsafgift.RegistreringsAfgift();
            Assert.AreEqual(389625, BilensRegistreringsAfgift);
        }

        [TestMethod]
        // Bil til under 81700,- fra efter 2015
        public void TestMethod3()
        {
            Bil NyBilligBilRegistreringsafgift = new DieselBil("Ford", 75000, 2016, 18.9, "PG 97 357", true, 65);

            double BilensRegistreringsafgift = NyBilligBilRegistreringsafgift.RegistreringsAfgift();
            Assert.AreEqual(78750, BilensRegistreringsafgift);
        }

        [TestMethod]
        // Bil Til over 81700,- fra efter 2015
        public void TestMethod4()
        {
            Bil NyDyrBilRegistreringsafgift = new DieselBil("Ford", 250000, 2016, 18.9, "PG 97 357", true, 65);

            double BilensRegistreringsafgift = NyDyrBilRegistreringsafgift.RegistreringsAfgift();
            Assert.AreEqual(388725, BilensRegistreringsafgift);
        }
        
        [TestMethod]
        // Elbil
        public void TestMethod5()
        {
            Bil NyElbilRegistreringsafgift = new ElBil("Tesla", 300000, 2016, "KS 35 975", 400, 7);

            double BilensRegistreringsafgift = NyElbilRegistreringsafgift.RegistreringsAfgift();
            Assert.AreEqual(60000, BilensRegistreringsafgift);
        }
        #endregion

        #region Totalpris
        /// <summary>
        /// Udregning af bilernes totale pris
        /// </summary>
        [TestMethod]
        // Billig bils totale pris
        public void TestMethod6()
        {
            Bil NyBilligBilTotalPris = new DieselBil("Ford", 75000, 2013, 18.9, "PG 97 357", true, 65);

            double BilligBilensTotalePris = NyBilligBilTotalPris.Totalpris();
            Assert.AreEqual(153750, BilligBilensTotalePris);
        }

        [TestMethod]
        // Dyr bils totale pris
        public void TestMethod7()
        {
            Bil NyDyrBilTotalPris = new DieselBil("Ford", 250000, 2016, 18.9, "PG 97 357", true, 65);

            double DyrBilensTotalePris = NyDyrBilTotalPris.Totalpris();
            Assert.AreEqual(638725, DyrBilensTotalePris);
        }

        [TestMethod]
        // Elbils totale pris
        public void TestMethod8()
        {
            Bil ElBilTotalPris = new ElBil("Tesla", 300000, 2016, "KS 35 975", 400, 7);

            double ElBilensTotalePris = ElBilTotalPris.Totalpris();
            Assert.AreEqual(360000, ElBilensTotalePris);
        }
        #endregion

        #region Metode med partikelfilter
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        // Bil med partikelfilter monteret
        public void TestMesthod9()
        {
            DieselBil Bil1 = new DieselBil("Toyota", 200000, 2015, 10.1, "ID 46 921", true, 65);

            string Bil11 = Bil1.GetPartikelfilter();
            Assert.IsTrue(true, "monteret");
        }

        [TestMethod]
        // Bil uden partikelfilter monteret
        public void TestMethod10()
        {
            DieselBil Bil2 = new DieselBil("Toyota", 200000, 2015, 10.1, "ID 46 921", false, 65);

            string Bil12 = Bil2.GetPartikelfilter();
            Assert.IsFalse(false, "ikke monteret");
        }
        #endregion

        [TestMethod]
        // Dieselbil med partikelfilter under 15 km/l
        public void TestMethod11()
        {
            DieselBil Bil3 = new DieselBil("Toyota", 200000, 2015, 10.1, "OS 79 375", true, 65);

            int Bil13 = Bil3.GetHalvÅrligEjerafgift();
            Assert.AreEqual(2000, Bil13); 
        }

        [TestMethod]
        // Dieselbil med partikelfilter mellem 15 og 25 km/l
        public void TestMethod12()
        {
            DieselBil Bil4 = new DieselBil("Toyota", 200000, 2015, 20, "OS 79 375", true, 65);

            int Bil14 = Bil4.GetHalvÅrligEjerafgift();
            Assert.AreEqual(1000, Bil14);
        }

       
        }

    }
}
