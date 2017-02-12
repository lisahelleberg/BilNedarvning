using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNedarvning
{
    class ElBil : Bil , IElMotor
    {
        public int BatteriKapacitet;
        public int KmPrKw;

        public ElBil(string Mærke, int BilPrisExAfgift, int KøbsÅr, string RegistreringsNr, int BatteriKapacitet, int KmPrKw) : base(Mærke, BilPrisExAfgift, KøbsÅr, RegistreringsNr)
        {
            this.BatteriKapacitet = BatteriKapacitet;
            this.KmPrKw = KmPrKw;
        }

        public override int HalvÅrligEjerafgift()
        {
            return 0;
        }

        public override double RegistreringsAfgift()
        {
            return 0.2 * BilPrisExAfgift;
        }

        public override double RækkeVidde()
        {
            return KmPrKw * BatteriKapacitet;
        }

        public int LadeTid()
        {
            return 5;
        }

        public override string HvilkenBilErJeg()
        {
            return "Jeg er en elbil!";
        }

        public override string ToString()
        {
            return ($"Bilen er en: {Mærke}. \nDen halvårlige ejerafgift er {HalvÅrligEjerafgift()} kr. \nDen blev købt i {KøbsÅr} og kostede {BilPrisExAfgift} kr ex moms. \nRegistreringsnummeret er {RegistreringsNr}. \nDen kører {RækkeVidde()} km/kW og da batteriet har en kapacitet på {BatteriKapacitet} kW, \nkan den kører {RækkeVidde()} km på en fuld opladning. \nRegistreringsafgiften er på {RegistreringsAfgift()} kr. \nTotalprisen på bilen er {Totalpris()} kr.\n"); ;
        }
    }
}
