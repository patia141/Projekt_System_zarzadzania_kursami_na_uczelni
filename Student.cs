using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_system_zarzadzania_kursami_na_uczelni
{
    public class Student : IOperacjeCRUD<Student>, IWalidacja<Student>
    {
        public int StudentId { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public static List<Student> studenci = new List<Student>();

        public void Dodaj(Student student)
        {
            if (Waliduj(student))
            {
                student.StudentId = studenci.Count + 1;
                studenci.Add(student);
            }
            else
            {
                throw new Exception("Nieprawidłowe dane studenta.");
            }
        }

        public Student Pobierz(int studentId)
        {
            return studenci.Find(s => s.StudentId == studentId);
        }

        public void Aktualizuj(Student updatedStudent)
        {
            var existingStudent = studenci.Find(s => s.StudentId == updatedStudent.StudentId);
            if (existingStudent != null)
            {
                if (Waliduj(updatedStudent))
                {
                    existingStudent.Imie = updatedStudent.Imie;
                    existingStudent.Nazwisko = updatedStudent.Nazwisko;
                }
                else
                {
                    throw new Exception("Nieprawidłowe dane studenta.");
                }
            }
        }

        public void Usun(int studentId)
        {
            studenci.RemoveAll(s => s.StudentId == studentId);
        }

        public bool Waliduj(Student student)
        {
            return !string.IsNullOrWhiteSpace(student.Imie) && !string.IsNullOrWhiteSpace(student.Nazwisko);
        }
    }
}
