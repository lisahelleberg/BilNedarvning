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
            List<ElBil> elBilListe = new List<ElBil>();
            List<IBil> BilListe = new List<IBil>();

            BilListe.Add(new DieselBil("Ford", 150000, 2011, 14, "GH 59 356", true, 65));
            BilListe.Add(new DieselBil("Ferrari", 350000, 2016, 8.5, "HD 89 125", true, 40));
            BilListe.Add(new DieselBil("Honda", 180000, 2014, 35, "JG 13 159", true, 20));
            BilListe.Add(new DieselBil("Toyota", 110000, 2010, 18, "EJ 79 678", false, 35));
            BilListe.Add(new DieselBil("VW", 190000, 2017, 20, "WP 16 795", false, 54));

            BilListe.Add(new BenzinBil("Citroën", 120000, 2011, 15, "OJ 89 357", 33));
            BilListe.Add(new BenzinBil("Peugeot", 150000, 2007, 22, "PG 68 357", 49));
            BilListe.Add(new BenzinBil("Kia", 80000, 2008, 23, "UG 97 357", 82));
            BilListe.Add(new BenzinBil("Suzuki", 50000, 2016, 35, "US 81 687", 50));
            BilListe.Add(new BenzinBil("Hyundai", 17000, 2015, 29, "SH 91 367", 65));

            BilListe.Add(new ElBil("Tesla", 300000, 2016, "KS 35 975", 400, 7));
            BilListe.Add(new ElBil("VW", 150000, 2015, "IV 79 349", 100, 18));
            BilListe.Add(new ElBil("Nissan", 180000, 2014, "OS 79 279", 150, 10));
            BilListe.Add(new ElBil("Renault", 50000, 2016, "PS 97 357", 80, 25));
            BilListe.Add(new ElBil("Ford", 89000, 2013, "RC 37 961", 340, 9));

            //DieselBil dBil = DieselBil as DieselBil;


            foreach (Bil bilitem in BilListe)
            {
                if (bilitem is DieselBil)
                {
                    var dieselbil1 = bilitem as DieselBil;
                    Console.WriteLine(dieselbil1.HvilkenBilErJeg());
                    Console.WriteLine(dieselbil1);
                }
                else if (bilitem is BenzinBil)
                {
                    var benzinbil1 = bilitem as BenzinBil;
                    Console.WriteLine(benzinbil1.HvilkenBilErJeg());
                    Console.WriteLine(benzinbil1);
                }
                else if (bilitem is ElBil)
                {
                    var elbil1 = bilitem as ElBil;
                    Console.WriteLine(elbil1.HvilkenBilErJeg());
                    Console.WriteLine(elbil1);
                }
                else if (bilitem is IElBil)
                {
                    var elmotor1 = bilitem as IElBil;
                    Console.Write("Bilen har elmotor!");
                    Console.WriteLine("Ladetiden er: " + elmotor1.LadeTid());
                }
            }
             
        }

    }
}
