using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_system_zarzadzania_kursami_na_uczelni
{
    public class OperacjeKursy : IOperacjeCRUD<Kurs>
    {
        public List<Kurs> Kursy { get; private set; } = new List<Kurs>();

        public void Dodaj(Kurs kurs)
        {
            kurs.KursId = Kursy.Count + 1;
            Kursy.Add(kurs);
        }

        public Kurs Pobierz(int id)
        {
            return Kursy.FirstOrDefault(s => s.KursId == id);
        }

        public void Aktualizuj(Kurs kurs)
        {
            var istniejacyKurs = Kursy.FirstOrDefault(s => s.KursId == kurs.KursId);
            if (istniejacyKurs != null)
            {
                istniejacyKurs.NazwaKursu = kurs.NazwaKursu;
                istniejacyKurs.MaxLiczbaStudentow = kurs.MaxLiczbaStudentow;
            }
        }

        public void Usun(int id)
        {
            Kursy.RemoveAll(s => s.KursId == id);
        }

        public void WyswietlListeKursow()
        {
            if (Kursy.Any())
            {
                Console.WriteLine("Lista kursów:");

                foreach (var kurs in Kursy)
                {
                    Console.WriteLine($"ID: k{kurs.KursId}, Nazwa kursu: {kurs.NazwaKursu}, Maksymalna liczba studentów: {kurs.MaxLiczbaStudentow}");
                }
            }
            else
            {
                Console.WriteLine("Lista kursów jest pusta.");
            }
        }
    }
}
