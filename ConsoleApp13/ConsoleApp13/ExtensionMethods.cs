using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    public static class ExtensionMethods

    {

        public static (int result, int remainder) DivideWithRemainder(this int dividend, int divisor) =>

                                                                    (dividend / divisor, dividend % divisor);

        public static int CountLetters(this string text, char letter) => text.Where(x => x.Equals(letter)).Count();



        public static int CountLetters(this string text, string letter)

        {

            if (letter.Length > 1)

            {

                throw new ArgumentException();

            }



            return text.CountLetters(letter[0]);

        }



        public static int CountLetters(this string text, char letter, bool caseInvariant = true)
        {

            return (caseInvariant ?

                      text.ToLower()

                          .CountLetters(char.ToLower(letter))

                      : text.CountLetters(letter));

        }

        public static bool IsSuitableForMinors(this AgeRange przedzial)

        {

            return (przedzial == AgeRange.Dzieci || przedzial == AgeRange.Mlodziez) ? true : false;

        }

    }

}