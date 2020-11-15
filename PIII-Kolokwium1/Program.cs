using System;

namespace PIII_Kolokwium1
{
    class Program
    {
        static void Main(string[] args)
        {
            CzujnikGazu.wczytajDane();

        }


    }
    class Zad1
    {
        /*Stwórz konwerter temperatur ze skali Fahrenheita na Kelvina. 
             * Wzór to *C razy (5/9) - 241.15. Napisz konwerter w przeciwną 
             * stronę (dzielenie i dodawanie). Funkcje powinny przyjmować parametr 
             * zmiennoprzecinkowy i zwracać liczbę zmiennoprzecinkową. Wczytaj od 
             * użytkownika parametr i zastosuj na nim obie konwersje.	
             */
        static Zad1() {
            Console.WriteLine("Podaj temperature w stopniach Fahrenheita");
            string input = Console.ReadLine();
            bool czyPrawidlowa = Double.TryParse(input, out double temperatura);
            if (czyPrawidlowa)
            {
                Console.WriteLine($"Temperatura {temperatura} Fahrenheita to {FahrenheitNaKelvin(temperatura)} Kelvinow");
            }
            else
            {
                Console.WriteLine("Nieprawidlowa wartosc");
            }
            Console.WriteLine("Podaj temperature w stopniach Kelvina");
            input = Console.ReadLine();
            czyPrawidlowa = Double.TryParse(input, out temperatura);
            if (czyPrawidlowa)
            {
                Console.WriteLine($"Temperatura {temperatura} Kelvinow to {KelvinNaFahrenheit(temperatura)} Fahrenhaitow");
            }
            else
            {
                Console.WriteLine("Nieprawidlowa wartosc");
            }

             static double FahrenheitNaKelvin(double fah)
            {
                return (fah * (5 / 9)) - 241.15;
            }
            static double KelvinNaFahrenheit(double kel)
            {
                return kel + 241.15 / (5 / 9);
            }
        }

       
    }
    public class CzujnikGazu
    {
        public static double []pomiary = new double[10];
        public static void wczytajDane()
        {
            for (int i = 0; i < pomiary.Length; i++)
            {
                Console.WriteLine("Podaj pomiar gazu");
                string input = Console.ReadLine();
                bool czyPrawidlowa = Double.TryParse(input, out double pomiar);
                if(czyPrawidlowa)
                {
                    pomiary[i] = pomiar;
                }
                else
                {
                    Console.WriteLine("Nieprawidlowa wartosc");
                    i--;
                }
            }
            double srednia = new double();
            foreach (var pomiar in pomiary)
            {
                srednia += pomiar;
            }
            if(srednia/pomiary.Length > 100)
            {
                Console.WriteLine("Sredni pomiar gazu ponad 100, zara wybuchnie");
            }
        }
    }
    public class Reklama
    {
        private int iloscWyswietlen;
        public int MaxKwota;
        public int MinKwota;
        string Link = "http://link.com";
        bool Status;

        public void zmienIloscWyswietlen(int ilosc)
        {
            iloscWyswietlen = ilosc;
        }
        public string wyswietlReklame()
        {
            iloscWyswietlen++;
            return Link;
        }
        public bool Filtr(int kwotaZamowienia, bool status)
        {
            if(status)
            {
                return true;
            }
            return false;
        }
    }
}