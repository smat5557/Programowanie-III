using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp21
{
    public static class StringExtension
    {
        public static string Metoda1(string nazwa1)
        {
            string nazwa2 = nazwa1.ToLower();
            return nazwa2;
        }
    }
}
