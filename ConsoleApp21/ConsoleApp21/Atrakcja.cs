using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21
{
    public abstract class Atrakcja
    {
        public string Nazwa { get; set; }
        public List<string> Opinie { get; set; }

        public string Opis(string nazwa, List<int>opinie)
        {
            this.Nazwa = nazwa;
            opinie = new List<int>();
            return nazwa;
           

        }

    }
}
