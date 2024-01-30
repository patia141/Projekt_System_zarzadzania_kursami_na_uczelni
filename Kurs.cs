using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_system_zarzadzania_kursami_na_uczelni
{
    public class Kurs
    {
        public int KursId { get; set; }
        public string NazwaKursu { get; set; }
        public int MaxLiczbaStudentow { get; set; }

        public static List<Kurs> kursy = new List<Kurs>();

        public void DodajKurs(Kurs kurs)
        {
            kurs.KursId = kursy.Count + 1;
            kursy.Add(kurs);
        }

        public Kurs PobierzKurs(int kursId)
        {
            return kursy.Find(k => k.KursId == kursId);
        }

        public void AktualizujKurs(Kurs updatedKurs)
        {
            var existingKurs = kursy.Find(k => k.KursId == updatedKurs.KursId);
            if (existingKurs != null)
            {
                existingKurs.NazwaKursu = updatedKurs.NazwaKursu;
                existingKurs.MaxLiczbaStudentow = updatedKurs.MaxLiczbaStudentow;
            }
        }

        public void UsunKurs(int kursId)
        {
            kursy.RemoveAll(k => k.KursId == kursId);
        }
    }
}
