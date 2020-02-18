using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    public class Advertisement

    {

        public string text;

        public AgeRange ageRange;

        public Interests interests;



        public Advertisement(string text, AgeRange ageRange, Interests interests)

        {

            this.text = text;

            this.ageRange = ageRange;

            this.interests = interests;

        }



        public void Test()

        {

            if (ageRange.HasFlag(AgeRange.Dzieci))

            {

                Console.WriteLine("Reklama dla dzieci");

            }

            if (ageRange >= AgeRange.Dorosli)

            {

                Console.WriteLine("Reklama dla doroslych");

            }

        }

    }

}
