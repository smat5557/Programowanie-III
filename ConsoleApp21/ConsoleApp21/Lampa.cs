using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21
{
   public class Lampa
    {
        public string Nazwa { get; set; }
        public double Napiecie { get; set; }

        public double Natezenie { get; set; }
        public double Cena { get; set; }

        public void Deconstruct(string nazwa, double cena)
        {
            nazwa = Nazwa;
            cena = Cena;
         

           
        }

        public void Deconstruct(string nazwa, double cena, double napiecie, double natezenie)
        {
            natezenie = Natezenie;
            napiecie = Napiecie;
            nazwa = Nazwa;
           double moc = Napiecie * Natezenie;
           
            
        }
    }
}
