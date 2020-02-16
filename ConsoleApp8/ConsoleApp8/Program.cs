using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string stopnie;
            stopnie = Srednia.TakeInputNumbers();
            float avg = Srednia.CalcAvg(stopnie);

            Console.WriteLine("Srednia wynosi: {0}", avg.ToString());


        }
    }
}
