using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class ExtensionMethod
    {
       public static int[] tab = new int[10];

        
    
            public static void Main (string[] args)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] *= 10;
                Console.WriteLine("Tab[{0}] = {1}", i, tab[i]);

            }

        }
        
    }
}
