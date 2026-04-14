using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Õpetaja : Isik
    {
        public string Aine { get; set; }

        public void Õpeta()
        {
            Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
        }
        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpetaja {Nimi} ja ma õpetan: {Aine}.");
        }
    }
}
