using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Postac
    {
        public int hp;
        public enum Status
        {
            Normalny,
            Trucizna,
            Ogłuszenie,
            Spowolnienie, 
            Szał
        }
        public Postac()
        {
            hp = 10;
            Postac postac = Postac.Normalny;
        }

        public void Kolejka(int hp)
        {
                       
            if (hp == 10)
            {
                String komenda;
                komenda = Console.ReadLine();

            }
            else if (Trucizna == true)
            {
                hp = hp - 2;
                Console.WriteLine("Straciłeś dwa punkty");
                String komenda;
                komenda = Console.ReadLine();
            }
            else if (Ogłuszenie == true)
            {
                Console.WriteLine("Straciłeś kolejkę");
                Ogłuszenie == false;
                break;
            }
            else if (Spowolnienie == true)
            {
                Console.WriteLine("Tracisz co drugą kolejkę");
                break;
            }
            else if (Szał)
            {
                Console.WriteLine("Ruszyłeś do ataku");
            }
        }

    }
}
