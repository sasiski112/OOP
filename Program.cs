using System;
using System.Collections.Generic;
using System.Text;
using OOP;

    Isik inimene1 = new Isik();
    inimene1.Nimi = "Mati";
    inimene1.Tervita(); // Väljund: Tere! Mina olen Mati...
    inimene1.Sünniaasta = 2000;
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

        
