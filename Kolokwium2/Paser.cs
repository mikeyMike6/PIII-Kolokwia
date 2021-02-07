using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2
{
    class Paser
    {
        Dictionary<int, string> Slownik = new Dictionary<int, string>();
        public Paser()
        {
            Slownik.Add(1, "jeden");
            Slownik.Add(2, "dwa");
            Slownik.Add(3, "trzy");
            Slownik.Add(4, "cztery");
            Slownik.Add(5, "piec");
            Slownik.Add(6, "szesc");
            Slownik.Add(7, "siedem");
            Slownik.Add(8, "osiem");
            Slownik.Add(9, "dziewiec");
            Slownik.Add(10, "dziesiec");
        }
        public int[] ZwrocLiczby(string[] cyfry)
        {
            int[] tmp = new int[cyfry.Length];
            for (int i = 0; i < cyfry.Length; i++)
            {
                    foreach (var item in Slownik)
                    {
                        if (item.Value == cyfry[i])
                        {
                            tmp[i] = item.Key;
                        }
                    }
                
            }
            return tmp;
        }
    }
}
