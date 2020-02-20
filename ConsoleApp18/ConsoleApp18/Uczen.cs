using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp18
{
    class Uczen
    {
        static public List<string> Przedmioty = new List<string>

        {

            "Statystyka",

            "Programowanie",

            "Bazy Danych",

            "Matematyka"

        };

        public string Imie { get; }

        public string Nazwisko { get; }

        List<Ocena> Oceny;

        public Uczen(string imie, string nazwisko)

        {

            Imie = imie;

            Nazwisko = nazwisko;

            Oceny = new List<Ocena>();

        }

        public void DodajOcene(float ocena, int waga, string nazwaPrzedmiotu)

        {

            if (Przedmioty.Contains(nazwaPrzedmiotu))

                Oceny.Add(new Ocena(ocena, waga, nazwaPrzedmiotu));

            else Console.WriteLine("Nie ma takiego przedmiotu w programie");

        } // tak, pamiętam żeby uważać na pojedyńcze ify bez klamr :)



        public float SredniaPrzedmiotu(string _przedmiot)

        {

            return Oceny.Where(ocena => ocena.Przedmiot == _przedmiot).

                Sum(ocena => ocena.Wartosc * ocena.Waga)

                /

                Oceny.Where(ocena => ocena.Przedmiot == _przedmiot).

                Sum(ocena => ocena.Waga);

            

        }



        public float SredniaSemestru()

        {

            float suma = 0;

            float ilosc = 0;

            foreach (var przedmiot in Przedmioty)

            {

                if (Oceny.Any(ocena => ocena.Przedmiot == przedmiot))

                {

                    suma += SredniaPrzedmiotu(przedmiot);

                    ilosc++;

                }

            }

            return suma / ilosc;

        }

    }

}