using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                var printer = new Printer(100, Ink.StandardInkSet());

                printer.OutOfPaperEvent += OutOfPaperEventHandler;

                printer.OutOfInkEvent += OutOfInkEventHandler;

                printer.PrintCompleteEvent += PrintCompleteEventHAndler;

                printer.Print(30);

                printer.Print(30);

                printer.Print(30);

                //Porządna firma więc czasem tylko raz tuszu zabraknie

                printer.BuyNewInk();

                printer.Print(30);

            }

            static void OutOfPaperEventHandler(object sender, EventArgs args)

            {

                Console.WriteLine("Get me new paper!");

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Printing not started.");

                Console.ResetColor();

            }

            static void OutOfInkEventHandler(

                object sender, EventArgs args)

            {

                Console.WriteLine("I've got no ink!");

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Printing not completed.");

                Console.ResetColor();

            }

            static void PrintCompleteEventHAndler(object sender, EventArgs args)

            {

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Printing completed successfully.");

                Console.ResetColor();

            }

        }

    }