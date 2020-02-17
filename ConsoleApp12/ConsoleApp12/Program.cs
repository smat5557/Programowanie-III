using System;

namespace ConsoleApp12
{
    class Program
    {
        static int iloscProduktow = 0;
        static void UnikalnaNazwa(string nazwaProduktu)
        {
            iloscProduktow++;
            Console.WriteLine("Produkt [" + nazwaProduktu + "]" + iloscProduktow);
        }
        static void Main(string[] args)
        {
            string escape = "exit";
            string odpowiedz = "";
            while (!odpowiedz.Equals(escape))
            {
                odpowiedz = Console.ReadLine();
                switch (odpowiedz)
                {
                    case "1":
                        UnikalnaNazwa("1");
                        break;
                    case "2":
                        UnikalnaNazwa("2");
                        break;
                    case "3":
                        UnikalnaNazwa("3");
                        break;
                }
            }
        }
    }
}