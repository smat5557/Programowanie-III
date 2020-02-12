using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Piosenka> Playlista = new List<Piosenka>();
        //  Playlista.Add(new Piosenka()("TTTT", "Adele", 4);
          //  Playlista.Add(new Piosenka()("U2","U2", 2);
           // Playlista.Add(new Piosenka()("KKK", "KKK", 5);

            foreach (Piosenka item in Playlista)
            {
                Console.WriteLine(item);
            }

            Playlista.Count();

        }
    }
}
