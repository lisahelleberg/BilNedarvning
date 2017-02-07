using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNedarvning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DieselBil> dieselBilListe = new List<DieselBil>();


            dieselBilListe.Add(new DieselBil("Ford", 150000, 2011, 14, "GH 59 356", true));
            dieselBilListe.Add(new DieselBil("Ferrari", 350000, 2016, 8.5, "HD 89 125", true));
            dieselBilListe.Add(new DieselBil("Honda", 180000, 2014, 35, "JG 13 159", true));
            dieselBilListe.Add(new DieselBil("Toyota", 110000, 2010, 18, "EJ 79 678", false));
            dieselBilListe.Add(new DieselBil("VW", 190000, 2017, 20, "WP 16 795", false));

            foreach (DieselBil dbil in dieselBilListe)
            {
                Console.WriteLine($"Registreringsnummer {dbil.GetRegistreringsNr()}, Halvårlig ejerafgift {dbil.GetHalvÅrligEjerafgift()}");
            }
        }

    }
}
