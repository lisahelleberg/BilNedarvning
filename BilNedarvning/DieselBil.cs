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

        public override int HalvÅrligEjerafgift()
        {
            return base.HalvÅrligEjerafgift();
        }
    }
}
