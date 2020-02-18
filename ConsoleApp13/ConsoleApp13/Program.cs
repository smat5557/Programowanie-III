using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Advertisement ad = new Advertisement(

                "Kup teraz!",

                AgeRange.Dzieci | AgeRange.Mlodziez,

                Interests.Elektronika

                );

            ad.Test();



            Advertisement ad2 = new Advertisement(

                "Kup teraz!",

                AgeRange.Dorosli | AgeRange.Starsi,

                Interests.Elektronika

            );

            ad2.Test();

        }

    }

}
