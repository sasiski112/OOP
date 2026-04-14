using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Isik
    {

        private int sünniaasta;
        public string Nimi { get; set; }

        public int Sünniaasta
        {
            get { return sünniaasta; }
            set
            {
                if (Sünniaasta > 1900 && Sünniaasta <= DateTime.Now.Year)
                    sünniaasta = value;
                else
                    Console.WriteLine("Vigane sünniaasta!");
            }
        }
        public int Vanus => sünniaasta == 0 ? 0 : DateTime.Now.Year - sünniaasta;
        public void Tervita()
        {
            if (string.IsNullOrEmpty(Nimi) || sünniaasta == 0)
            {
                Console.WriteLine("vale");
            }
            else
            {
                Console.WriteLine($"Tere! Mina olen {Nimi} ja ma olen {Vanus} aastat vana. Ma olen {Sünniaasta}");
            }

        }
        // Abstraktne meetod – sisu puudub, alamklassid PEAVAD selle ise looma
        public abstract void Kirjelda();
    }
}


