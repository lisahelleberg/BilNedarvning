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
            return ($"Bilen er en: {Mærke}. \nDen halvårlige ejerafgift er {HalvÅrligEjerafgift()} kr. \nDen blev købt i {KøbsÅr} og kostede {BilPrisExAfgift} kr ex moms. \nRegistreringsnummeret er {RegistreringsNr}. \nDen kører {KmPrLiter} km/l og da tanken er på {Tank} l, \nkan den køre {RækkeVidde()} km på en fuld tankning. \nRegistreringsafgiften er på {RegistreringsAfgift()} kr. \nTotalprisen på bilen er {Totalpris()} kr.\n");
        }
    }
}
