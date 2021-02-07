using System;
using System.Collections.Generic;
using System.IO;

namespace Kolokwium2
{
    static class Program
    {
        static void Main(string[] args)
        {
           
        }

        static void zad2()
        {
            Paser paser = new Paser();
            string[] text = new string[] { "jeden", "szesc", "piec" };
            int[] tab = paser.ZwrocLiczby(text);
            foreach (var item in tab)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
