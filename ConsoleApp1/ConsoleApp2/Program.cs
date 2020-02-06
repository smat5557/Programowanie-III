using System;
using System.Collections;
namespace ExtensionMethod
{
    public static decimal Netto(decimal liczba, int vat)
    {
        liczba = (liczba * (100 + vat) / 100);
        return liczba;
       
}
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ksiazka ksiazka1 = new Ksiazka();
            ksiazka1.ISBN = "2516";
            ArrayList lista = new ArrayList();
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                lista.Add(i);
                Console.WriteLine(i);
            }

            lista.Sort();
            foreach (var item in lista)
            {
                Console.Write(item + " ");
            }
        }
    }
}
