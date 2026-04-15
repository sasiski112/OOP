using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Õpetaja : Isik, ITööline
    {
        public string Aine { get; set; }
        public double Tunnitasu { get; set; } = 8.3;
        public double Tunidkuus { get; set; } = 88;
        public TööTüüp VäljamakseTüüp { get; set; } = TööTüüp.Palk;


        public void Õpeta()
        {
            Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
        }
        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpetaja {Nimi} ja ma õpetan: {Aine}.");
        }
        public double ArvutPalk()
        {
            return Tunnitasu * Tunidkuus;
        }
    }
}
