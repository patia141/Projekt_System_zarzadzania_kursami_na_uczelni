using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_system_zarzadzania_kursami_na_uczelni
{
    public class OperacjeNauczyciele : IOperacjeCRUD<Nauczyciel>
    {
        public List<Nauczyciel> Nauczyciele { get; private set; } = new List<Nauczyciel>();

        public void Dodaj(Nauczyciel nauczyciel)
        {
            nauczyciel.NauczycielId = Nauczyciele.Count + 1;
            Nauczyciele.Add(nauczyciel);
        }

        public Nauczyciel Pobierz(int id)
        {
            return Nauczyciele.FirstOrDefault(s => s.NauczycielId == id);
        }

        public void Aktualizuj(Nauczyciel nauczyciel)
        {
            var istniejacyNauczyciel = Nauczyciele.FirstOrDefault(s => s.NauczycielId == nauczyciel.NauczycielId);
            if (istniejacyNauczyciel != null)
            {
                istniejacyNauczyciel.Imie = nauczyciel.Imie;
                istniejacyNauczyciel.Nazwisko = nauczyciel.Nazwisko;
            }
        }

        public void Usun(int id)
        {
            Nauczyciele.RemoveAll(s => s.NauczycielId == id);
        }

        public void WyswietlNauczycieli()
        {
            if (Nauczyciele.Any())
            {
                Console.WriteLine("Lista nauczycieli:");

                foreach (var nauczyciel in Nauczyciele)
                {
                    Console.WriteLine($"ID: n{nauczyciel.NauczycielId}, Imię i nazwisko: {nauczyciel.Imie} {nauczyciel.Nazwisko}");
                }
            }
            else
            {
                Console.WriteLine("Lista nauczycieli jest pusta.");
            }
        }
    }
}
