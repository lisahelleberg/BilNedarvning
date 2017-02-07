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
            List<BenzinBil> benzinBilListe = new List<BenzinBil>();


            dieselBilListe.Add(new DieselBil("Ford", 150000, 2011, 14, "GH 59 356", true, 65));
            dieselBilListe.Add(new DieselBil("Ferrari", 350000, 2016, 8.5, "HD 89 125", true, 40));
            dieselBilListe.Add(new DieselBil("Honda", 180000, 2014, 35, "JG 13 159", true, 20));
            dieselBilListe.Add(new DieselBil("Toyota", 110000, 2010, 18, "EJ 79 678", false, 35));
            dieselBilListe.Add(new DieselBil("VW", 190000, 2017, 20, "WP 16 795", false, 54));

            benzinBilListe.Add(new BenzinBil("Citroën", 120000, 2011, 15, "OJ 89 357", 33));
            benzinBilListe.Add(new BenzinBil("Peugeot", 150000, 2007, 22, "PG 68 357", 49));
            benzinBilListe.Add(new BenzinBil("Kia", 80000, 2008, 23, "UG 97 357", 82));
            benzinBilListe.Add(new BenzinBil("Suzuki", 50000, 2016, 35, "US 81 687", 50));
            benzinBilListe.Add(new BenzinBil("Hyundai", 17000, 2015, 29, "SH 91 367", 65));

            foreach (DieselBil dbil in dieselBilListe)
            {
                Console.WriteLine($"Registreringsnummer: {dbil.GetRegistreringsNr()}, Halvårlig ejerafgift: {dbil.GetHalvÅrligEjerafgift()}, Rækkevidde: {dbil.RækkeVidde()}");
            }

            foreach (BenzinBil bBil in benzinBilListe)
            {
                Console.WriteLine($"Registreringsnummer: {bBil.RegistreringsNr}, Km pr. Liter: {bBil.KmPrLiter}, Halvårlig ejerafgift: {bBil.HalvÅrligEjerafgift()}, Rækkevidde: {bBil.RækkeVidde()}");
            }
            {

            }
        }

    }
}
