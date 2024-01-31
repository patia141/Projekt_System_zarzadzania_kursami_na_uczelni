using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_system_zarzadzania_kursami_na_uczelni
{
    public class Kurs : IOperacjeCRUD<Kurs>, IWalidacja<Kurs>
    {
        public int KursId { get; set; }
        public string NazwaKursu { get; set; }
        public int MaxLiczbaStudentow { get; set; }

        public static List<Kurs> kursy = new List<Kurs>();

        public void Dodaj(Kurs kurs)
        {
            if (Waliduj(kurs))
            {
                kurs.KursId = kursy.Count + 1;
                kursy.Add(kurs);
            }
        }

        public Kurs Pobierz(int kursId)
        {
            return kursy.Find(k => k.KursId == kursId);
        }

        public void Aktualizuj(Kurs updatedKurs)
        {
            var existingKurs = kursy.Find(k => k.KursId == updatedKurs.KursId);
            if (existingKurs != null)
            {
                if (Waliduj(updatedKurs))
                {
                    existingKurs.NazwaKursu = updatedKurs.NazwaKursu;
                    existingKurs.MaxLiczbaStudentow = updatedKurs.MaxLiczbaStudentow;
                }
                else
                {
                    throw new Exception("Nieprawidłowe dane kursu.");
                }
            }
        }

        public void Usun(int kursId)
        {
            kursy.RemoveAll(k => k.KursId == kursId);
        }

        public bool Waliduj(Kurs kurs)
        {
            return !string.IsNullOrWhiteSpace(kurs.NazwaKursu) && kurs.MaxLiczbaStudentow > 0;
        }
    }
}
