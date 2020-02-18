using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    [Flags]

    public enum AgeRange

    {

        Brak = 0,

        Dzieci = 1,

        Mlodziez = 2,

        Dorosli = 4,

        Starsi = 8

    }



    [Flags]

    public enum Interests

    {

        Elektronika,

        Motoryzacja,

        Gaming,

        Ekonomia

    }

}