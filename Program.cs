using System;
using System.Collections.Generic;
using System.Text;
using OOP;

    //Isik inimene1 = new Isik();
    //inimene1.Nimi = "Mati";
    //inimene1.Tervita(); // Väljund: Tere! Mina olen Mati...
    //inimene1.Sünniaasta = 2000;

    Console.WriteLine("\n-----Õpetaja andmed-----");
    Õpetaja õpetaja1 = new Õpetaja();
    õpetaja1.Nimi = "Eve";
    õpetaja1.Sünniaasta = 1980;
    õpetaja1.Aine = "Keemia";
    õpetaja1.Tervita();
    õpetaja1.Õpeta();
    õpetaja1.Kirjelda();

    Console.WriteLine("\n-----Õpilane andmed-----");
    Õpilane õpilane1 = new Õpilane();
    õpilane1.Nimi = "Oleg";
    õpilane1.Sünniaasta = 2008;
    õpilane1.Kool = "TTHK";
    õpilane1.Klass = 1;
    õpilane1.Tervita();
    õpilane1.Õpi();
    õpilane1.Kirjelda();
List<ITööline> palgaasjad = new List<ITööline>();
Random klass = new Random();
string[] nimed = { "Anna", "Kola", "Liza", "Oleg", "Danya", "Manya" };
string[] kool = { "TTHK", "Politeh", "Mehaanika Kool" };
Õppevorm[] vormid = (Õppevorm[])Enum.GetValues(typeof(Õppevorm));
for (int i = 0; i < nimed.Length; i++)
{
    Õpilane õpilane = new Õpilane
    {
        Nimi = nimed[klass.Next(nimed.Length)],
        Klass = klass.Next(5,13),
        Kool = kool[klass.Next(kool.Length)],
        KeskmineHinne = klass.NextDouble() * (5 - 2) + 2,
        Puudumised = klass.Next(0,350),
        KasOnSotsTõen = klass.Next(0,2) == 1,
        Staatus = vormid[klass.Next(vormid.Length)]
    };
}
//Õpilane anna = new Õpilane { Nimi = "Anna", Klass = rnd, KeskmineHinne = rn };
//Õpilane kola = new Õpilane { Nimi = "Kola", Klass = rnd, KeskmineHinne = rn };
//Õpilane liza = new Õpilane { Nimi = "Liza", Klass = rnd, KeskmineHinne = rn };
//Õpilane oleg = new Õpilane { Nimi = "Oleg", Klass = rnd, KeskmineHinne = rn };
foreach (ITööline isik in palgaasjad)
{
    string tüüp = isik.ValjamakseTüüp.ToString();
    Console.WriteLine($"{tüüp} summa: {isik.ArvutaPalk() } eurot. {((Isik)isik).Nimi}le");
}






