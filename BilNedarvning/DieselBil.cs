using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNedarvning
{
    public class DieselBil : Bil
    {
        public double KmPrLiter;
        public bool Partikelfilter;
        public double Tank;

        // Konstruktør med partikelfilter?
        public DieselBil(string Mærke, int BilPrisExAfgift, int KøbsÅr, double KmPrLiter, string RegistreringsNr, bool Partikelfilter, double Tank) : base(Mærke, BilPrisExAfgift, KøbsÅr, RegistreringsNr)
        {
            this.KmPrLiter = KmPrLiter;
            this.Partikelfilter = Partikelfilter;
            this.Tank = Tank;
        }

        // Konstruktør med partikelfilter monteret
        public DieselBil(string Mærke, int BilPrisExAfgift, int KøbsÅr, double KmPrLiter, string RegistreringsNr, double Tank) : this(Mærke, BilPrisExAfgift, KøbsÅr, KmPrLiter, RegistreringsNr, true, Tank)
        {
            this.RegistreringsNr = RegistreringsNr;
            this.Tank = Tank;
        }

        public int KmPrLiterAfgift()
        {
            if (KmPrLiter < 15)
            {
                return 2000;
            }
            if (KmPrLiter >= 15 && KmPrLiter < 25)
            {
                return 1000;
            }
            if (KmPrLiter >= 25)
            {
                return 350;
            }
            else
            {
                return 0;
            }
        }

        public int PartikelfilterMonteret()
        {
            if (Partikelfilter == false)
            {
                return 500;
            }
            else
            {
                return 0;
            }
        }

        public string GetPartikelfilter()
        {
            if (Partikelfilter == true)
            {
                return "Monteret";
            }
            else if (Partikelfilter == false)
            {
                return "Ikke monteret";
            }
            else
            {
                return null;
            }
        }
        // Halvårlig ejerafgift er afhængig af KmPrLiter
        public override int HalvÅrligEjerafgift()
        {
            return KmPrLiterAfgift();
        }

        public string GetRegistreringsNr()
        {
            return RegistreringsNr;
        }

        public int GetHalvÅrligEjerafgift()
        {
            return HalvÅrligEjerafgift() + PartikelfilterMonteret();
        }

        public override double RækkeVidde()
        {
            return Tank * KmPrLiter;
        }

        public override string HvilkenBilErJeg()
        {
            return "Jeg er en dieselbil!";
        }
        public override string ToString()
        {
            return ($"Mærke: {Mærke}. \nHalvårlig ejerafgift: {GetHalvÅrligEjerafgift()} kr. \nPartikelfilter: {GetPartikelfilter()}. \nKøbsår: {KøbsÅr}. \nPris: {BilPrisExAfgift} kr ex afgift. \nRegistreringsnummer: {RegistreringsNr}. \nKm pr liter: {KmPrLiter}. \nTank: {Tank} l. \nRækkevidde {RækkeVidde()} km på en fuld tankning. \nRegistreringsafgift: {RegistreringsAfgift()} kr. \nTotalprisen på bilen er {Totalpris()} kr.\n");
        }
    }
}
