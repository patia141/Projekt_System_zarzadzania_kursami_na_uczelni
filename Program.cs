using Projekt_system_zarzadzania_kursami_na_uczelni;
using System;
using System.Collections.Generic;

namespace System_zarzadzania_kursami_na_uczelni
{
    class Program
    {
        static void Main()
        {
            //studenci
            Student student1 = new Student { Imie = "Jan", Nazwisko = "Kowalski" };
            student1.DodajStudenta(student1);

            Student student2 = new Student { Imie = "Patrycja", Nazwisko = "Lipa" };
            student2.DodajStudenta(student2);

            Student student3 = new Student { Imie = "Karolina", Nazwisko = "Karp" };
            student3.DodajStudenta(student3);

            Student student4 = new Student { Imie = "Tomasz", Nazwisko = "Jezioro" };
            student4.DodajStudenta(student4);

            student2.UsunStudenta(student2.StudentId);

            Student studentToUpdate = new Student { StudentId = 1, Imie = "Janusz", Nazwisko = "Nowak" };
            student1.AktualizujStudenta(studentToUpdate);

            Student studentDoZnalezienia = student2.PobierzStudenta(2);
            if (studentDoZnalezienia != null)
            {
                Console.WriteLine($"\nStudent o ID {studentDoZnalezienia.StudentId} nadal znajduje się na liście studentów");
            }
            else
            {
                Console.WriteLine("\nNie znaleziono studenta o podanym ID");
            }

            Console.WriteLine("Studenci:");
            foreach (var student in Student.studenci)
            {
                Console.WriteLine($"ID: s{student.StudentId}, Imię i nazwisko: {student.Imie} {student.Nazwisko}");
            }

            //kursy
            Kurs kurs1 = new Kurs { NazwaKursu = "Matematyka", MaxLiczbaStudentow = 30 };
            kurs1.DodajKurs(kurs1);
            Kurs kurs2 = new Kurs { NazwaKursu = "Angielski", MaxLiczbaStudentow = 12 };
            kurs2.DodajKurs(kurs2);
            Kurs kurs3 = new Kurs { NazwaKursu = "Fizyka", MaxLiczbaStudentow = 25 };
            kurs3.DodajKurs(kurs3);
            Kurs kurs4 = new Kurs { NazwaKursu = "Muzyka", MaxLiczbaStudentow = 20 };
            kurs4.DodajKurs(kurs4);

            Kurs kursDoZnalezienia = kurs3.PobierzKurs(3);
            if (kursDoZnalezienia != null)
            {
                Console.WriteLine($"Kurs o numerze ID {kursDoZnalezienia.KursId} istnieje");
            }
            else
            {
                Console.WriteLine("Kurs o podanym ID nie istnieje");
            }

            Kurs kursAktualiz = new Kurs { KursId = 2, MaxLiczbaStudentow = 13, NazwaKursu = "Geografia" };
            kurs2.AktualizujKurs(kursAktualiz);

            kurs4.UsunKurs(kurs4.KursId);

            Console.WriteLine("\nKursy:");
            foreach (var kurs in Kurs.kursy)
            {
                Console.WriteLine($"ID: k{kurs.KursId} {kurs.NazwaKursu}, Maksymalna liczba studentów: {kurs.MaxLiczbaStudentow}");
            }

            //nauczyciele
            Nauczyciel nauczyciel1 = new Nauczyciel { Imie = "Piotr", Nazwisko = "Wisniewski" };
            nauczyciel1.DodajNauczyciela(nauczyciel1);
            Nauczyciel nauczyciel2 = new Nauczyciel { Imie = "Zenek", Nazwisko = "Martyniuk" };
            nauczyciel2.DodajNauczyciela(nauczyciel2);
            Nauczyciel nauczyciel3 = new Nauczyciel { Imie = "Karolina", Nazwisko = "Bocian" };
            nauczyciel3.DodajNauczyciela(nauczyciel3);
            Nauczyciel nauczyciel4 = new Nauczyciel { Imie = "Alina", Nazwisko = "Sum" };
            nauczyciel4.DodajNauczyciela(nauczyciel4);
            Console.WriteLine("\nNauczyciele:");
            foreach (var nauczyciel in Nauczyciel.nauczyciele)
            {
                Console.WriteLine($"ID: n{nauczyciel.NauczycielId}, Imię i nazwisko: {nauczyciel.Imie} {nauczyciel.Nazwisko}");
            }
        }
    }
}