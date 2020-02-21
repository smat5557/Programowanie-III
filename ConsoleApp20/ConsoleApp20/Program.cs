using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();

            printer.OutOfPaperEvent += OutOfPaperEventHandler;

            printer.Print();

        }



        static void OutOfPaperEventHandler(object sender, EventArgs args)

        {

            Console.WriteLine("The end of paper, please add some paper ");

        }

    }

}