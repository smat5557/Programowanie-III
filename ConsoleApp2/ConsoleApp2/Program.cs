using System;

namespace ConsoleApp2
{
    {
    class Program
    {
        int x = 0, y = 0;
        public void utworzTAblice()
        {
            int[][] tab = new int[4][];
            tab[0] = new int[1];
            tab[1] = new int[3];
            tab[2] = new int[5];
            tab[3] = new int[7];

            tab[0][0] = 1;

            tab[1][0] = 3;
            tab[1][1] = 3;
            tab[1][2] = 3;

            tab[2][0] = 5;
            tab[2][1] = 5;
            tab[2][2] = 5;
            tab[2][3] = 5;
            tab[2][4] = 5;

            tab[3][0] = 7;
            tab[3][1] = 7;
            tab[3][2] = 7;
            tab[3][3] = 7;
            tab[3][4] = 7;
            tab[3][5] = 7;
            tab[3][6] = 7;



        }
        public static int sprawdzCzyPunktNalezy(int x, int y)
        {
            Console.WriteLine("Podaj współrzędną x punktu: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj współrzędną y punktu: ");
            y = int.Parse(Console.ReadLine());

            int funkcja = ((x * x * x) - 3 * x);
            if (y > funkcja)
            {
                Console.WriteLine("Podany punkt znajduje się nad wykresem podanej funkcji");
                return 1;

            }
            if (y < funkcja)
            {
                Console.WriteLine("Podany punkt znajduję się pod wykresem podanej funkcji");
                return 0;
            }
            return funkcja;

        }
        static void Main(string[] args)
        {
            sprawdzCzyPunktNalezy(int x, int y);
        }

    }
}
