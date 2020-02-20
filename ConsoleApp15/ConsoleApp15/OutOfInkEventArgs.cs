using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    public class OutOfInkEventArgs : EventArgs

    {

        public string Colour { get; set; }

        public int PageNumber { get; set; }

        public OutOfInkEventArgs(string colour, int pageNumber)

        {

            Colour = colour;

            PageNumber = pageNumber;

        }

    }

}
