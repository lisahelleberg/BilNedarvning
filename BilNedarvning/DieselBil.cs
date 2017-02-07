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

        public override int HalvÅrligEjerafgift()
        {
            if (Partikelfilter == false)
            {
                return 500;
            }
            else if (Partikelfilter == true) 
            {
                return 0;
            }
            else
            {
                return 0;
            }
        }

        public string GetRegistreringsNr()
        {
            return RegistreringsNr;
        }

        public int GetHalvÅrligEjerafgift()
        {
            return HalvÅrligEjerafgift();
        }

        //public void PrintInfo()
        //{
        //    Console.WriteLine($"Registreringsnummer: {GetRegistreringsNr()}, Halvårlig ejerafgift: {GetHalvÅrligEjerafgift()}");
        //}
    }
}
