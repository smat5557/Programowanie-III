using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Wwiadomosc
    {
        public String Tekst;
       public String Autor;
        public DateTime Data;

        ~Wwiadomosc()
        {
            Console.WriteLine("Tekst: " + Tekst);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Data: " + Data);
        }

        ~Wwiadomosc(int iloscZnakow, int iloscDni)
        {
            iloscZnakow = Tekst.Length;
            Console.WriteLine("Ilość znaków: " + iloscZnakow );

            DateTime t = DateTime.Now;
        DateTime dataWyslania = new DateTime(Data);
            TimeSpan iloscDni = now - Data.Value;
        }
    }
}
