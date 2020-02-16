using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Srednia
    {
        static public float CalcAvg(string inputNumbers)
        {
            float Sum = 0;
            string[] numbers = inputNumbers.Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var number in numbers)
            {
                Sum += Convert.ToSingle(number);
            }
            return (float)Sum / numbers.Length;
        }
        static public string TakeInputNumbers()
        {

            string answer = "";
            StringBuilder result = new StringBuilder();
            do
            {
                answer = Console.ReadLine();
                result.Append(answer);
                result.Append(";");

            } while (answer != string.Empty);
            return result.ToString();
        }
        static public string RoundFloat(float number)
        {
            return Math.Round(number, 2).ToString();
        }
    }
}
    

