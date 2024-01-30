using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_system_zarzadzania_kursami_na_uczelni
{
    public class Nauczyciel : IOperacjeCRUD<Nauczyciel>, IWalidacja<Nauczyciel>
    {
        public int NauczycielId { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public static List<Nauczyciel> nauczyciele = new List<Nauczyciel>();

        public void Dodaj(Nauczyciel nauczyciel)
        {
            if (Waliduj(nauczyciel))
            {
                nauczyciel.NauczycielId = nauczyciele.Count + 1;
                nauczyciele.Add(nauczyciel);
            }
            else
            {
                throw new Exception("Nieprawidłowe dane nauczyciela.");
            }
        }

        public Nauczyciel Pobierz(int nauczycielId)
        {
            return nauczyciele.Find(n => n.NauczycielId == nauczycielId);
        }

        public void Aktualizuj(Nauczyciel updatedNauczyciel)
        {
            var existingNauczyciel = nauczyciele.Find(n => n.NauczycielId == updatedNauczyciel.NauczycielId);
            if (existingNauczyciel != null)
            {
                if (Waliduj(updatedNauczyciel))
                {
                    existingNauczyciel.Imie = updatedNauczyciel.Imie;
                    existingNauczyciel.Nazwisko = updatedNauczyciel.Nazwisko;
                }
                else
                {
                    throw new Exception("Nieprawidłowe dane nauczyciela.");
                }
            }
        }

        public void Usun(int nauczycielId)
        {
            nauczyciele.RemoveAll(n => n.NauczycielId == nauczycielId);
        }

        public bool Waliduj(Nauczyciel nauczyciel)
        {
            return !string.IsNullOrWhiteSpace(nauczyciel.Imie) && !string.IsNullOrWhiteSpace(nauczyciel.Nazwisko);
        }
    }
}
