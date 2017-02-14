using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNedarvning
{
    public abstract class Bil : IBil
    {
        public int BilPrisExAfgift { get; private set; }
        public int KøbsÅr { get; private set; }

        public string Mærke;
        public string RegistreringsNr;

        #region Registreringsafgift
        /// <summary>
        /// Udregning af Registreringsafgiften efter bilens pris ex afgift samt købsår
        /// </summary>
        /// <returns></returns>
        public virtual double RegistreringsAfgift()
        {
            if (KøbsÅr <= 2014 && BilPrisExAfgift < 80500)
            {
                double RegistreringsAfgiften = (1.05 * BilPrisExAfgift);
                return RegistreringsAfgiften;
            }
            else if (KøbsÅr <= 2014 && BilPrisExAfgift >= 80500)
            {
                double RegistreringsAfgiften = ((1.05 * 80500) + (1.80 * (BilPrisExAfgift - 80500)));
                return RegistreringsAfgiften;
            }
            else if (KøbsÅr >= 2015 && BilPrisExAfgift < 81700)
            {
                double RegistreringsAfgiften = (1.05 * BilPrisExAfgift);
                return RegistreringsAfgiften;
            }
            else if (KøbsÅr >= 2015 && BilPrisExAfgift >= 81700)
            {
                double RegistreringsAfgiften = ((1.05 * 81700) + (1.80 * (BilPrisExAfgift - 81700)));
                return RegistreringsAfgiften;
            }
            else
            {
                return 0;
            }
        }
#endregion
        
        
        public double Totalpris()
        {
            return RegistreringsAfgift() + BilPrisExAfgift;
        }

        public abstract int HalvÅrligEjerafgift();

        // konstruktor
        public Bil(string Mærke, int BilPrisExAfgift, int KøbsÅr, string RegistreringsNr)
        {

            this.Mærke = Mærke;
            this.BilPrisExAfgift = BilPrisExAfgift;
            this.KøbsÅr = KøbsÅr;
            this.RegistreringsNr = RegistreringsNr;
        }

        public abstract double RækkeVidde();

        public abstract string HvilkenBilErJeg();
    }

    
}
