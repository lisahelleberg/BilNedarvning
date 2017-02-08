using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using 

namespace UnitTestBil
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        // Bilpris 70.000 kr
        public void TestMethod1()
        {
            
             public void TestMethod1()
        {
            PrisBeregning beregn = new PrisBeregning();
            KuverterListe liste = new KuverterListe();

            double aktuel = beregn.ReturKuvert(liste);
            Assert.AreEqual(0, aktuel);
        }
    }
    }
}
