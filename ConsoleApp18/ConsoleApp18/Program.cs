using System;

namespace ConsoleApp18
{
    class Program
    {
        static string Najlepszy(params Uczen[] lista)

        {

            Uczen najlepszy = lista[0];

            foreach (var uczen in lista)

            {

                if (uczen.SredniaSemestru() > najlepszy.SredniaSemestru())

                    najlepszy = uczen;

            }

            return najlepszy.Imie + " " + najlepszy.Nazwisko;

        }

        static string Najlepszy(List<Uczen> lista)

        {

            Uczen najlepszy = lista[0];

            foreach (var uczen in lista)

            {

                if (uczen.SredniaSemestru() > najlepszy.SredniaSemestru())

                    najlepszy = uczen;

            }

            return najlepszy.Imie + " " + najlepszy.Nazwisko;

        }





        static void Main(string[] args)

        {

            string p = "Programowanie";

            string s = "Statystyka";

            string bd = "Bazy Danych";

            string m = "Matematyka";

            var Janek = new Uczen("Janek", "Mol");

            var Robert = new Uczen("Robert", "Bal");

            var Zenek = new Uczen("Zenek", "But");

            Janek.DodajOcene(5, 1, p);

            Janek.DodajOcene(3, 3, p);

            Janek.DodajOcene(5, 1, p);

            Janek.DodajOcene(4, 1, s);

            Janek.DodajOcene(5, 1, bd);

            Janek.DodajOcene(4, 1, m);

            Robert.DodajOcene(4, 1, p);

            Robert.DodajOcene(4, 1, s);

            Robert.DodajOcene(4, 1, bd);

            Robert.DodajOcene(4, 1, m);

            Zenek.DodajOcene(5, 1, p);

            Zenek.DodajOcene(5, 1, s);

            Zenek.DodajOcene(5, 1, bd);

            Zenek.DodajOcene(5, 1, m);



            Console.WriteLine(Janek.SredniaPrzedmiotu(p));



            Console.WriteLine("Najlepszy uczen to: {0}",

                Najlepszy(Janek, Robert, Zenek));



        }

    }

}