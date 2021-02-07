using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2
{
    class Projekt : ICloneable
    {
        public string NazwaKlasy { get; set; }
        public string Kod { get; set; }
        public int[] NumerWersji { get; set; }
        public Projekt(string nazwaKlasy, string kod)
        {
            NazwaKlasy = nazwaKlasy;
            Kod = kod;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
    static class ProjectExtensionMethod
    {
        public static void NowaWersja(this List<Projekt> projekty, string kod, int[] nrWersji)
        {
        }
    }
}
