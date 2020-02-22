using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21
{
    public class Jezioro : Atrakcja
    {
        public double Rozmiar { get; set; }
        public double Glebokosc { get; set; }

        public string Opis(string nazwa, List<string> opinie, double rozmiar, double glebokosc)
        {
            this.Glebokosc = glebokosc;
            this.Rozmiar = rozmiar;
            this.Nazwa = nazwa;
            opinie = new List<string>();
            return nazwa;
        }
    }
}
