using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public abstract class Dzielo
    {
        String NrKarty;
        String Tytuł;

        public Dzielo()
        {

        }

        virtual public void Opis()
        {

            Console.WriteLine("Nr Karty: " + NrKarty);
            Console.WriteLine("Tytuł: " + Tytuł);
        }
    }
}
