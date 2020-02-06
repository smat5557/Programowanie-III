using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Ksiazka : Dzielo
    {
        public String ISBN;
        public int RokWydania;

        public void OpisKsiazka()
        {
            Opis();
            Console.WriteLine("ISBN : " + ISBN);
            Console.WriteLine("Rok Wydania: " + RokWydania);
        }
    }
}
