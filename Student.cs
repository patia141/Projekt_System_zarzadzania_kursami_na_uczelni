using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_system_zarzadzania_kursami_na_uczelni
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public static List<Student> studenci = new List<Student>();

        public void DodajStudenta(Student student)
        {
            student.StudentId = studenci.Count + 1;
            studenci.Add(student);
        }

        public Student PobierzStudenta(int studentId)
        {
            return studenci.Find(s => s.StudentId == studentId);
        }

        public void AktualizujStudenta(Student updatedStudent)
        {
            var existingStudent = studenci.Find(s => s.StudentId == updatedStudent.StudentId);
            if (existingStudent != null)
            {
                existingStudent.Imie = updatedStudent.Imie;
                existingStudent.Nazwisko = updatedStudent.Nazwisko;
            }
        }

        public void UsunStudenta(int studentId)
        {
            studenci.RemoveAll(s => s.StudentId == studentId);
        }
    }
}
