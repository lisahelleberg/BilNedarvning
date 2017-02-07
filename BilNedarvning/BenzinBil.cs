using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNedarvning
{
    sealed class BenzinBil : Bil
    {
        public double Tank;

        // Konstruktør
        public BenzinBil(string Mærke, int BilPrisExAfgift, int KøbsÅr, double KmPrLiter, string RegistreringsNr, double Tank) : base(Mærke, BilPrisExAfgift, KøbsÅr, KmPrLiter, RegistreringsNr)
        {

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
    }
}
