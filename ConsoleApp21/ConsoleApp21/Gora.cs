using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21
{
    public class Gora : Atrakcja
    {
        public double Wysokosc { get; set; }
        public string Pogoda { get; set; }

        public string Opis(string nazwa, List<string> opinie, double wysokosc, string pogoda)
        {
            this.Wysokosc = wysokosc;
            this.Pogoda = pogoda;
            this.Nazwa = nazwa;
            opinie = new List<string>();
            return nazwa;
        }
    }

}
