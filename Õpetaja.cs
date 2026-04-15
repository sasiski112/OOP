using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace OOP
{
    public class Õpetaja : Isik, ITööline
    {
        public string Aine { get; set; }
        public double Tunnitasu { get; set; } 
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
        public double ArvutaPalk()
        {
            Random rnd = new Random();
            Tunidkuus = rnd.Next(2,12);
            return Tunnitasu * Tunidkuus;
        }
    }
}
