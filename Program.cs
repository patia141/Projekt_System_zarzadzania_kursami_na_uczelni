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
            student1.Dodaj(student1);

            Student student2 = new Student { Imie = "Patrycja", Nazwisko = "Lipa" };
            student2.Dodaj(student2);

            Student student3 = new Student { Imie = "Karolina", Nazwisko = "Karp" };
            student3.Dodaj(student3);

            Student student4 = new Student { Imie = "Tomasz", Nazwisko = "Jezioro" };
            student4.Dodaj(student4);

            student2.Usun(student2.StudentId);

            Student studentToUpdate = new Student { StudentId = 1, Imie = "Janusz", Nazwisko = "Nowak" };

            try
            {
                student1.Aktualizuj(studentToUpdate);
                Console.WriteLine("Dane studenta zaktualizowane.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd podczas aktualizacji danych studenta: {ex.Message}");
            }

            Student studentDoZnalezienia = student2.Pobierz(2);
            if (studentDoZnalezienia != null)
            {
                Console.WriteLine($"\nStudent o ID {studentDoZnalezienia.StudentId} nadal znajduje się na liście studentów");
            }
            else
            {
                Console.WriteLine("\nNie znaleziono studenta o podanym ID");
            }

            Console.WriteLine("Studenci po operacjach CRUD:");
            WyswietlInformacjeOStudentach(Student.studenci);

            //kursy
            Kurs kurs1 = new Kurs { NazwaKursu = "Matematyka", MaxLiczbaStudentow = 30 };
            kurs1.Dodaj(kurs1);
            Kurs kurs2 = new Kurs { NazwaKursu = "Angielski", MaxLiczbaStudentow = 12 };
            kurs2.Dodaj(kurs2);
            Kurs kurs3 = new Kurs { NazwaKursu = "Fizyka", MaxLiczbaStudentow = 25 };
            kurs3.Dodaj(kurs3);
            Kurs kurs4 = new Kurs { NazwaKursu = "Muzyka", MaxLiczbaStudentow = 20 };
            kurs4.Dodaj(kurs4);

            Kurs kursDoZnalezienia = kurs3.Pobierz(3);
            if (kursDoZnalezienia != null)
            {
                Console.WriteLine($"Kurs o numerze ID {kursDoZnalezienia.KursId} istnieje");
            }
            else
            {
                Console.WriteLine("Kurs o podanym ID nie istnieje");
            }

            Kurs kursAktualiz = new Kurs { KursId = 2, MaxLiczbaStudentow = 13, NazwaKursu = "Geografia" };
            kurs2.Aktualizuj(kursAktualiz);

            kurs4.Usun(kurs4.KursId);

            Console.WriteLine("\nKursy:");
            foreach (var kurs in Kurs.kursy)
            {
                Console.WriteLine($"ID: k{kurs.KursId} {kurs.NazwaKursu}, Maksymalna liczba studentów: {kurs.MaxLiczbaStudentow}");
            }

            //nauczyciele
            Nauczyciel nauczyciel1 = new Nauczyciel { Imie = "Piotr", Nazwisko = "Wisniewski" };
            nauczyciel1.Dodaj(nauczyciel1);
            Nauczyciel nauczyciel2 = new Nauczyciel { Imie = "Zenek", Nazwisko = "Martyniuk" };
            nauczyciel2.Dodaj(nauczyciel2);
            Nauczyciel nauczyciel3 = new Nauczyciel { Imie = "Karolina", Nazwisko = "Bocian" };
            nauczyciel3.Dodaj(nauczyciel3);
            Nauczyciel nauczyciel4 = new Nauczyciel { Imie = "Alina", Nazwisko = "Sum" };
            nauczyciel4.Dodaj(nauczyciel4);
            Console.WriteLine("\nNauczyciele:");
            foreach (var nauczyciel in Nauczyciel.nauczyciele)
            {
                Console.WriteLine($"ID: n{nauczyciel.NauczycielId}, Imię i nazwisko: {nauczyciel.Imie} {nauczyciel.Nazwisko}");
            }
        }

        static void WyswietlInformacjeOStudentach(List<Student> listaStudentow)
        {
            foreach (var student in listaStudentow)
            {
                Console.WriteLine($"ID: s{student.StudentId}, Imię i nazwisko: {student.Imie} {student.Nazwisko}");
            }
        }

    }
}