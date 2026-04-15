using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Õpilane : Isik, ITööline
    {
        public string Kool { get; set; }
        public int Klass { get; set; }
        public double KeskmineHinne { get; set; } = 3.8;
        public double Puudumised { get; set; } = 30;
        public bool KasOnSotsTõen { get; set; }
        public string Staatus { get; set; }
        public TööTüüp VäljamakseTüüp { get; set; } = TööTüüp.Toetus;


        public void Õpi()
        {
            Console.WriteLine($"{Nimi} õpib {Kool} {Klass}. klassis.");
        }
        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpilane {Nimi} ja käin {Klass}. klassis.");
        }

        public double ArvutaPalk(double Põhitoetus, double Eritoetus)
        {
            Põhitoetus = 60;
            Eritoetus = 40;
            if ((Puudumised >= 31 && KeskmineHinne <= 3.7) && KasOnSotsTõen == false)
            {
                return Põhitoetus;
            }
            else if (KasOnSotsTõen == true && (KeskmineHinne <= 3.7 || Puudumised >= 31))
            {
                return Eritoetus;
            }
            else if (KasOnSotsTõen == true && KeskmineHinne >= 3.8 && Puudumised <= 30)
            {
                return Põhitoetus + Eritoetus;
            }
            else if (KasOnSotsTõen == false && KeskmineHinne >= 3.8 && Puudumised <= 30)
            {
                return Põhitoetus;
            }
            else
            {
                return 0;
            }
        }
    }
}
