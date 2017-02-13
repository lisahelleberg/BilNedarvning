using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNedarvning
{
    sealed class BenzinBil : Bil
    {
        public int Tank;
        public double KmPrLiter;

        // Konstruktør
        public BenzinBil(string Mærke, int BilPrisExAfgift, int KøbsÅr, double KmPrLiter, string RegistreringsNr, int Tank) : base(Mærke, BilPrisExAfgift, KøbsÅr, RegistreringsNr)
        {
            this.KmPrLiter = KmPrLiter;
            this.Tank = Tank;
        }
        public override int HalvÅrligEjerafgift()
        {
            if (KmPrLiter < 20)
            {
                return 1200;
            }
            if (KmPrLiter >=20 && KmPrLiter < 28)
            {
                return 600;
            }
            if (KmPrLiter >= 28)
            {
                return 320;
            }
            else
            {
                return 0;
            }
        }
        public override double RækkeVidde()
        {
            return Tank * KmPrLiter;
        }
        public override string HvilkenBilErJeg()
        {
            return "Jeg er en benzinbil!";
        }

        public override string ToString()
        {
            return ($"Mærke: {Mærke}. \nHalvårlige ejerafgift: {HalvÅrligEjerafgift()} kr. \nKøbsår: {KøbsÅr}. \nPris {BilPrisExAfgift} kr ex afgift. \nRegistreringsnummer: {RegistreringsNr}. \nKm pr liter: {KmPrLiter}. \nTank: {Tank} l. \nRækkevidde: {RækkeVidde()} km på en fuld tankning. \nRegistreringsafgift: {RegistreringsAfgift()} kr. \nTotalprisen på bilen er {Totalpris()} kr.\n");
        }
    }
}
