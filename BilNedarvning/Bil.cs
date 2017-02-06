using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNedarvning
{
    public class Bil
    {
        public int BilPrisExAfgift { get; private set; }
        public int KøbsÅr { get; private set; }

        public string Mærke;
        public string RegistreringsNr;
        public double KmPrLiter;

        public virtual double RegistreringsAfgift()
        {
            if (KøbsÅr <= 2014)
            {
                double RegistreringsAfgiften = ((1.05 * 80500) + (1.80 * (BilPrisExAfgift - 80500)));
                return RegistreringsAfgiften;
            }
            else if (KøbsÅr >= 2015)
            {
                double RegistreringsAfgiften = ((1.05 * 81700) + (1.80 * (BilPrisExAfgift - 81700)));
                return RegistreringsAfgiften;
            }
            else
            {
                return 0;
            }
        }

        public double Totalpris()
        {
            return RegistreringsAfgift() + BilPrisExAfgift;
        }

        public virtual int HalvÅrligEjerafgift()
        {
            return 1000;
        }

        // konstruktor
        public Bil(string Mærke, int BilprisExAfgift, int KøbsÅr, double KmPrLiter)
        {

        }
    }
}
