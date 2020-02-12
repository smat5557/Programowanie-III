using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    interface IKopiarka : ISkaner, IDrukarka
    {
     // Skanuj();
       // Drukuj();
       public string Kopiuj(string kopiuj)
        {
            Skanuj();
            Drukuj("jjj");
            string wartosc = "ooo";
            return wartosc;
        }
    }
}
