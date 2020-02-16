using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            Funkcje obiekt = new Funkcje();
            string text = "@";
            float sum = 0;
            float result = 0;
            while (text != string.Empty)
            {
                text = Console.ReadLine();
                builder.Append(text + "!");
            }
            string gradesString = builder.ToString();

            string[] grades = gradesString.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries);
            float[] gradesInt = new float[grades.Length];
            for (int i = 0; i < grades.Length; i++)
            {
                gradesInt[i] = Convert.ToSingle(grades[i]);
            }
            foreach (float grade in gradesInt)
            {
                sum += grade;
            }
            result = obiekt.ObliczSrednia(sum, gradesInt.Length);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

}