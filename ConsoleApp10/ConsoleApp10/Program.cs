using System;
using System.Collections.Generic;
using System.Linq;
using RandomDataGenerator.Randomizer;
using RandomDataGenerator.FieldOptions;

namespace ConsoleApp10
{
    class Osoba
    {
        public int ID;
        public string imie;
        public string nazwisko;
        public Osoba(int id, string imie, string nazwisko)
        {
            ID = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
    }
   class Program
    {
        static void Main(string[] args)
        {
            var intGenerator = RandomizerFactory.GetRandomizer(new FieldOptionsInteger());
            var nameGenerator = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
            var lastnameGenerator = RandomizerFactory.GetRandomizer(new FieldOptionsLastName());
            var random = new Osoba(
                intGenerator.Generate().Value,
                nameGenerator.Generate(),
                lastnameGenerator.Generate());
            Console.WriteLine($"{random.ID} {random.imie} {random.nazwisko} ");

           
            var list = new List<Osoba>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(new Osoba(
                intGenerator.Generate().Value,
                nameGenerator.Generate(),
                lastnameGenerator.Generate()));
            }
            list = list.OrderBy(x => x.nazwisko).ThenBy(x => x.imie).ToList();
            foreach (var item in list)
            {
                Console.WriteLine("{0} {1}", item.nazwisko, item.imie);

            }


        }
    }
}