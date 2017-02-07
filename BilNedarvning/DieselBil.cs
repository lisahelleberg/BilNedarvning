using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNedarvning
{
    public class DieselBil : Bil
    {
        public bool Partikelfilter;

        // Konstruktør med partikelfilter?
        public DieselBil(string Mærke, int BilPrisExAfgift, int KøbsÅr, double KmPrLiter, string RegistreringsNr, bool Partikelfilter) : base(Mærke, BilPrisExAfgift, KøbsÅr, KmPrLiter, RegistreringsNr)
        {
            this.RegistreringsNr = RegistreringsNr;
            this.Partikelfilter = Partikelfilter;
        }

        // Konstruktør med partikelfilter monteret
        public DieselBil(string Mærke, int BilPrisExAfgift, int KøbsÅr, double KmPrLiter, string RegistreringsNr) : this(Mærke, BilPrisExAfgift, KøbsÅr, KmPrLiter, RegistreringsNr, true)
        {
            this.RegistreringsNr = RegistreringsNr;
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

        //public void PrintInfo()
        //{
        //    Console.WriteLine($"Registreringsnummer: {GetRegistreringsNr()}, Halvårlig ejerafgift: {GetHalvÅrligEjerafgift()}");
        //}
    }
}
