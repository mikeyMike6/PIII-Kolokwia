using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Kolokwium2
{
    public class Student
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int NrIndeksu { get; set; }
        public Student(string imie, string nazwisko, int nrIndeksu)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            NrIndeksu = nrIndeksu;
        }
    }
    public static class ExtensionMethod
    {
        public static void ZapelnijListe(this List<Student> studenci)
        {

        }
        public static void ZapiszListeStudentow(this List<Student> studenci)
        {
            string text = "";
            if (!File.Exists("ListaStudentow.txt"))
            {
                File.WriteAllText("ListaStudentow.txt", "Lista studentow:\n");
            }
            foreach (var student in studenci)
            {
                text += $"{student.NrIndeksu}\n";
                text += $"{student.Imie}\n";
                text += $"{student.Nazwisko}\n\n";
            }
            File.AppendAllText("ListaStudentow.txt", text);
        }
        public static void DodajStudenta(this List<Student> studenci, string imie, string nazwisko, int nrIndeksu)
        {
            studenci.Add(new Student(imie, nazwisko, nrIndeksu));
            Console.WriteLine($"Dodano studenta {imie} {nazwisko}, nr {nrIndeksu}");
        }
        public static void UsunStudenta(this List<Student> studenci, int nrIndeksu)
        {
            studenci.RemoveAll(x => x.NrIndeksu == nrIndeksu);
            Console.WriteLine($"Usunieto studenta nr {nrIndeksu}");
        }
    }
}
