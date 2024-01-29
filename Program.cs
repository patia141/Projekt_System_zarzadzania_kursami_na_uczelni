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
        }
    }
}