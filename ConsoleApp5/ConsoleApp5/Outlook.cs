using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Outlook
    {
        static void Wyslij(EventArgs Nadawca, EventArgs SkrotTresc)
        {
            string Autor = "Jan Kowalski";
            string SkrotWiadomosci = "Cośtam";
            Console.WriteLine("{0}  {1}", Autor, SkrotWiadomosci);
        }

    }
}
