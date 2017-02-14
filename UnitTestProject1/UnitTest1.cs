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
        public void BilligBil2014()
        {
            Bil NyBilligBilRegistreringsafgift = new DieselBil("Ford", 75000, 2013, 18.9, "PG 97 357", true, 65);

            double BilensRegistreringsAfgift = NyBilligBilRegistreringsafgift.RegistreringsAfgift();
            Assert.AreEqual(78750, BilensRegistreringsAfgift);
        }

        [TestMethod]
        // Bil til over 80500,- fra før 2014 
        public void DyrBil2014()
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
        #region Grænsetilfælde
        [TestMethod]
        // Bil til 80499 før 2014
        public void TestMethod17()
        {
            Bil NyBil1 = new DieselBil("Ford", 80499, 2013, 18.9, "PG 97 357", true, 65);

            double NyBil11 = NyBil1.RegistreringsAfgift();
            Assert.AreEqual(84523.95, NyBil11);
        }

        [TestMethod]
        // Bil til 80501 før 2014
        public void TestMethod18()
        {
            Bil NyBil2 = new DieselBil("Ford", 80501, 2013, 18.9, "PG 97 357", true, 65);

            double NyBil21 = NyBil2.RegistreringsAfgift();
            Assert.AreEqual(84526.8, NyBil21);
        }

        [TestMethod]
        // Bil til 81699 efter 2015
        public void BilEfter2014LavGrænse()
        {
            Bil NyBil3 = new DieselBil("Ford", 81699, 2016, 18.9, "PG 97 357", true, 65);

            double NyBil31 = NyBil3.RegistreringsAfgift();
            Assert.AreEqual(85783.95, NyBil31);
        }
        #endregion
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

        [TestMethod]
        // Bieselbil med partikelfilter over 25 km/l
        public void TestMethod13()
        {
            DieselBil Bil5 = new DieselBil("Toyota", 200000, 2015, 30, "OS 79 375", true, 65);

            int Bil15 = Bil5.GetHalvÅrligEjerafgift();
            Assert.AreEqual(350, Bil15);
        }

        [TestMethod]
        // Dieselbil uden partikelfilter mellem 15 og 25 km/l
        public void TestMethod14()
        {
            DieselBil Bil6 = new DieselBil("Toyota", 200000, 2015, 20, "OS 79 375", false, 65);

            int Bil16 = Bil6.GetHalvÅrligEjerafgift();
            Assert.AreEqual(1500, Bil16);
        }

        [TestMethod]
        // Benzinbil under 20 km/l
        public void TestMethod15()
        {
            Bil Bil7 = new BenzinBil("Ford", 200000, 2015, 15, "PS 79 246", 60);

            int Bil17 = Bil7.HalvÅrligEjerafgift();
            Assert.AreEqual(1200, Bil17);
        }

        [TestMethod]
        // Benzinbil mellem 20 og 28 km/l
        public void TestMethod16()
        {
            Bil Bil8 = new BenzinBil("Ford", 200000, 2015, 25, "PS 79 246", 60);

            int Bil18 = Bil8.HalvÅrligEjerafgift();
            Assert.AreEqual(600, Bil18);
        }
    }
}
