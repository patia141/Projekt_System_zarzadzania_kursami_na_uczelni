using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_system_zarzadzania_kursami_na_uczelni
{
    public class OperacjeStudenci : IOperacjeCRUD<Student>
    {
        public List<Student> Studenci { get; private set; } = new List<Student>();

        public void Dodaj(Student student)
        {
            student.StudentId = Studenci.Count + 1;
            Studenci.Add(student);
        }

        public Student Pobierz(int id)
        {
            return Studenci.FirstOrDefault(s => s.StudentId == id);
        }

        public void Aktualizuj(Student student)
        {
            var istniejacyStudent = Studenci.FirstOrDefault(s => s.StudentId == student.StudentId);
            if (istniejacyStudent != null)
            {
                istniejacyStudent.Imie = student.Imie;
                istniejacyStudent.Nazwisko = student.Nazwisko;
            }
        }

        public void Usun(int id)
        {
            Studenci.RemoveAll(s => s.StudentId == id);
        }

        public void WyswietlStudentow()
        {
            if (Studenci.Any())
            {
                Console.WriteLine("Lista studentów:");

                foreach (var student in Studenci)
                {
                    Console.WriteLine($"ID: s{student.StudentId}, Imię i nazwisko: {student.Imie} {student.Nazwisko}");
                }
            }
            else
            {
                Console.WriteLine("Lista studentów jest pusta.");
            }
        }
    }
}
