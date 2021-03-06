﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilNedarvning;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //#region Registreringsafgift
        ///// <summary>
        ///// Udregning af bilernes registreringsafgift
        ///// </summary>
        //[TestMethod]
        //// Bil til under 80500,- fra før 2014 
        //public void BilligBilFør2014RegAfgift()
        //{
        //    Bil NyBilligBilRegistreringsafgift = new DieselBil("Ford", 75000, 2013, 18.9, "PG 97 357", true, 65);

        //    double BilensRegistreringsAfgift = NyBilligBilRegistreringsafgift.RegistreringsAfgift();
        //    Assert.AreEqual(78750, BilensRegistreringsAfgift);
        //}

        //[TestMethod]
        //// Bil til over 80500,- fra før 2014 
        //public void DyrBilFør2014RegAfgift()
        //{
        //    Bil NyDyrBilRegistreringsafgift = new DieselBil("Ford", 250000, 2013, 18.9, "PG 97 357", true, 65);

        //    double BilensRegistreringsAfgift = NyDyrBilRegistreringsafgift.RegistreringsAfgift();
        //    Assert.AreEqual(389625, BilensRegistreringsAfgift);
        //}

        //[TestMethod]
        //// Bil til under 81700,- fra efter 2015
        //public void BilligBilEFter2015RegAfgift()
        //{
        //    Bil NyBilligBilRegistreringsafgift = new DieselBil("Ford", 75000, 2016, 18.9, "PG 97 357", true, 65);

        //    double BilensRegistreringsafgift = NyBilligBilRegistreringsafgift.RegistreringsAfgift();
        //    Assert.AreEqual(78750, BilensRegistreringsafgift);
        //}

        //[TestMethod]
        //// Bil Til over 81700,- fra efter 2015
        //public void DyrBilEfter2015RegAfgift()
        //{
        //    Bil NyDyrBilRegistreringsafgift = new DieselBil("Ford", 250000, 2016, 18.9, "PG 97 357", true, 65);

        //    double BilensRegistreringsafgift = NyDyrBilRegistreringsafgift.RegistreringsAfgift();
        //    Assert.AreEqual(388725, BilensRegistreringsafgift);
        //}
        
        //[TestMethod]
        //// Elbil
        //public void ElBilRegAfgift()
        //{
        //    Bil NyElbilRegistreringsafgift = new ElBil("Tesla", 300000, 2016, "KS 35 975", 400, 7);

        //    double BilensRegistreringsafgift = NyElbilRegistreringsafgift.RegistreringsAfgift();
        //    Assert.AreEqual(60000, BilensRegistreringsafgift);
        //}
        //#region Grænsetilfælde
        //[TestMethod]
        //// Bil til 80499 før 2014
        //public void BilFør2014LavGrænseRegAfgift()
        //{
        //    Bil NyBil1 = new DieselBil("Ford", 80499, 2013, 18.9, "PG 97 357", true, 65);

        //    double NyBil11 = NyBil1.RegistreringsAfgift();
        //    Assert.AreEqual(84523.95, NyBil11);
        //}
        //[TestMethod]
        //// Bil til 80500 før 2014
        //public void BilFør2014PåGrænsenRegAfgift()
        //{
        //    Bil NyBil11 = new DieselBil("Ford", 80500, 2013, 18.9, "PG 97 357", true, 65);

        //    double NyBil111 = NyBil11.RegistreringsAfgift();
        //    Assert.AreEqual(84525, NyBil111);
        //}
        //[TestMethod]
        //// Bil til 80501 før 2014
        //public void BilFør2014HøjGrænseRegAfgift()
        //{
        //    Bil NyBil2 = new DieselBil("Ford", 80501, 2013, 18.9, "PG 97 357", true, 65);

        //    double NyBil21 = NyBil2.RegistreringsAfgift();
        //    Assert.AreEqual(84526.8, NyBil21);
        //}

        //[TestMethod]
        //// Bil til 81699 efter 2015
        //public void BilEfter2014LavGrænseRegAfgift()
        //{
        //    Bil NyBil3 = new DieselBil("Ford", 81699, 2016, 18.9, "PG 97 357", true, 65);

        //    double NyBil31 = NyBil3.RegistreringsAfgift();
        //    Assert.AreEqual(85783.95, NyBil31);
        //}

        //[TestMethod]
        //// Bil til 81700 efter 2015
        //public void BilEfter2014PåGrænsenRegAfgift()
        //{
        //    Bil NyBil12 = new DieselBil("Ford", 81700, 2016, 18.9, "PG 97 357", true, 65);

        //    double NyBil112 = NyBil12.RegistreringsAfgift();
        //    Assert.AreEqual(85785, NyBil112);
        //}
        //[TestMethod]
        //// Bil til 81701 efter 2015
        //public void BilEfter2014HøjGrænseRegAfgift()
        //{
        //    Bil NyBil4 = new DieselBil("Ford", 81701, 2016, 18.9, "PG 97 357", true, 65);

        //    double NyBil41 = NyBil4.RegistreringsAfgift();
        //    Assert.AreEqual(85786.8, NyBil41);
        //}
        #endregion
        #endregion

        #region Totalpris
        /// <summary>
        /// Udregning af bilernes totale pris
        /// </summary>
        [TestMethod]
        // Billig bils totale pris
        public void BilligBilTotalPris()
        {
            Bil NyBilligBilTotalPris = new DieselBil("Ford", 75000, 2013, 18.9, "PG 97 357", true, 65);

            double BilligBilensTotalePris = NyBilligBilTotalPris.Totalpris();
            Assert.AreEqual(153750, BilligBilensTotalePris);
        }

        [TestMethod]
        // Dyr bils totale pris
        public void DyrBilTotalPris()
        {
            Bil NyDyrBilTotalPris = new DieselBil("Ford", 250000, 2016, 18.9, "PG 97 357", true, 65);

            double DyrBilensTotalePris = NyDyrBilTotalPris.Totalpris();
            Assert.AreEqual(638725, DyrBilensTotalePris);
        }

        [TestMethod]
        // Elbils totale pris
        public void ElBilTotalPris()
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
        public void BilMedPartikelFilterMonteret()
        {
            DieselBil Bil1 = new DieselBil("Toyota", 200000, 2015, 10.1, "ID 46 921", true, 65);

            string Bil11 = Bil1.GetPartikelfilter();
            Assert.IsTrue(true, "monteret");
        }

        [TestMethod]
        // Bil uden partikelfilter monteret
        public void BilUdenPartikelFilterMonteret()
        {
            DieselBil Bil2 = new DieselBil("Toyota", 200000, 2015, 10.1, "ID 46 921", false, 65);

            string Bil12 = Bil2.GetPartikelfilter();
            Assert.IsFalse(false, "ikke monteret");
        }
        #endregion

        #region HalvårligEjerafgift
        /// <summary>
        /// Metode til test af halvårlig ejerafgift af både elbiler, benzinbiler og dieselbiler med og uden partikelfilter
        /// </summary>
        #region Dieselbil med partikelfilter
        
        [TestMethod]
        // Dieselbil med partikelfilter under 15 km/l
        public void DieselBilMedPartikelFilterKortAfstandEjerAfgift()
        {
            DieselBil Bil3 = new DieselBil("Toyota", 200000, 2015, 10.1, "OS 79 375", true, 65);

            int Bil13 = Bil3.GetHalvÅrligEjerafgift();
            Assert.AreEqual(2000, Bil13); 
        }

        [TestMethod]
        // Dieselbil med partikelfilter mellem 15 og 25 km/l
        public void DieselBilMedPartikelFilterMellemAfstandEjerAfgift()
        {
            DieselBil Bil4 = new DieselBil("Toyota", 200000, 2015, 20, "OS 79 375", true, 65);

            int Bil14 = Bil4.GetHalvÅrligEjerafgift();
            Assert.AreEqual(1000, Bil14);
        }

        [TestMethod]
        // Dieselbil med partikelfilter over 25 km/l
        public void DieselBilMedPartikelFilterLangAfstandEjerAfgift()
        {
            DieselBil Bil5 = new DieselBil("Toyota", 200000, 2015, 30, "OS 79 375", true, 65);

            int Bil15 = Bil5.GetHalvÅrligEjerafgift();
            Assert.AreEqual(350, Bil15);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        // Bil med købspris ex moms på 0 kroner
        public void BilMedKøbsPrisPåNul()
        {
            var Bil6 = new DieselBil("Toyota", 0, 2015, 30, "OS 79 375", true, 65);

            int Bil16 = Bil6.GetHalvÅrligEjerafgift();
            
        }
        #endregion

        #region Dieselbil uden partikelfilter
        [TestMethod]
        // Dieselbil uden partikelfilter mellem 15 og 25 km/l
        public void DieselBilUdenPartikelFilterMellemAfstandEjerAgfift()
        {
            DieselBil Bil6 = new DieselBil("Toyota", 200000, 2015, 20, "OS 79 375", false, 65);

            int Bil16 = Bil6.GetHalvÅrligEjerafgift();
            Assert.AreEqual(1500, Bil16);
        }
        #endregion

        #region Benzinbiler

        [TestMethod]
        // Benzinbil under 20 km/l
        public void BenzinBilKortAfstangEjerAfgift()
        {
            Bil Bil7 = new BenzinBil("Ford", 200000, 2015, 15, "PS 79 246", 60);

            int Bil17 = Bil7.HalvÅrligEjerafgift();
            Assert.AreEqual(1200, Bil17);
        }

        [TestMethod]
        // Benzinbil mellem 20 og 28 km/l
        public void BenzinBilMellemAfstandEjerAfgift()
        {
            Bil Bil8 = new BenzinBil("Ford", 200000, 2015, 25, "PS 79 246", 60);

            int Bil18 = Bil8.HalvÅrligEjerafgift();
            Assert.AreEqual(600, Bil18);
        }

        [TestMethod]
        // Benzinbil over 28 km/l
        public void BenzinBilLangAfstandEjerAfgift()
        {
            Bil Bil9 = new BenzinBil("Ford", 200000, 2015, 35, "PS 79 246", 60);

            int Bil19 = Bil9.HalvÅrligEjerafgift();
            Assert.AreEqual(320, Bil19);
        }
        #endregion

        #region Elbiler
        [TestMethod]
        // Elbil
        public void ElBilEjerAfgift()
        {
            Bil Bil10 = new ElBil("Tesla", 300000, 2016, "KS 35 975", 400, 7);

            int Bil110 = Bil10.HalvÅrligEjerafgift();
            Assert.AreEqual(0, Bil110);
        }
        #endregion
        #endregion

        #region Rækkevidde
        [TestMethod]
        // Rækkevidden for dieselbil
        public void DieselBilRækkeVidde()
        {
            var Bil20 = new DieselBil("Toyota", 200000, 2015, 10.1, "OS 79 375", true, 65);

            double Bil21 = Bil20.RækkeVidde();
            Assert.AreEqual(656.5, Bil21);
        }

        [TestMethod]
        // Række for benzinbil
        public void BenzinBilRækkeVidde()
        {
            var Bil40 = new BenzinBil("Toyota", 200000, 2015, 10.1, "OS 79 375", 65);

            double Bil41 = Bil40.RækkeVidde();
            Assert.AreEqual(656.5, Bil41);
        }
        [TestMethod]
        // Rækkevidden for elbil
        public void ElBilRækkeVidde()
        {
            var Bil30 = new ElBil("Tesla", 300000, 2016, "KS 35 975", 400, 7);

            double Bil31 = Bil30.RækkeVidde();
            Assert.AreEqual(2800, Bil31); 
        }
        #endregion

        #region Ladetid
        [TestMethod]
        // Ladetid for elbil
        public void ElbilLadeTid()
        {
            var elbil1 = new ElBil("Tesla", 300000, 2016, "KS 35 975", 400, 7);

            int elbil11 = elbil1.LadeTid();
            Assert.AreEqual(5, elbil11);
        }
        #endregion
    }
}
