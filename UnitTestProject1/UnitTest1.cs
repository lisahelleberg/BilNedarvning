﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilNedarvning;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
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


    }
}
