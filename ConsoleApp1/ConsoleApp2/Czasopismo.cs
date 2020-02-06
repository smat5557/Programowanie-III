using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Czasopismo : Dzielo
    {
        public String ISSN;
        public int Czestotliwosc;

        public void OpisCzasopismo()
        {
            Opis();
            Console.WriteLine("ISSN: " + ISSN);
            Console.WriteLine("Częstotliwość: " + Czestotliwosc);
        }

    }
}
