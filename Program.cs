using Projekt_system_zarzadzania_kursami_na_uczelni;
using System;
using System.Collections.Generic;

namespace System_zarzadzania_kursami_na_uczelni
{
    class Program
    {
        static void Main()
        {

            //menu
            var student = new Student();
            var nauczyciel = new Nauczyciel();
            var kurs = new Kurs();
            int maxLiczbaStudentow;
            bool zakoncz = false;

            /*
            Student student1 = new Student { Imie = "Jan", Nazwisko = "Kowalski" };
            student1.Dodaj(student1);
            Student student2 = new Student { Imie = "Patrycja", Nazwisko = "Lipa" };
            student2.Dodaj(student2);
            Kurs kurs1 = new Kurs { NazwaKursu = "Matematyka", MaxLiczbaStudentow = 30 };
            kurs1.Dodaj(kurs1);
            Kurs kurs2 = new Kurs { NazwaKursu = "Angielski", MaxLiczbaStudentow = 12 };
            kurs2.Dodaj(kurs2);
            UsunKurs(kurs);
            WyswietlKursy(Kurs.kursy); */

            
            do
            {
                Console.WriteLine("1. Dodaj studenta");
                Console.WriteLine("2. Znajdź studenta");
                Console.WriteLine("3. Aktualizuj studenta");
                Console.WriteLine("4. Usuń studenta");
                Console.WriteLine("5. Wyświetl studentów");

                Console.WriteLine("6. Dodaj nauczyciela");
                Console.WriteLine("7. Znajdź nauczyciela");
                Console.WriteLine("8. Aktualizuj nauczyciela");
                Console.WriteLine("9. Usuń nauczyciela");
                Console.WriteLine("10. Wyświetl nauczycieli");

                Console.WriteLine("11. Dodaj kurs");
                Console.WriteLine("12. Znajdź kurs");
                Console.WriteLine("13. Aktualizuj kurs");
                Console.WriteLine("14. Usuń kurs");
                Console.WriteLine("15. Wyświetl listę kursów");

                Console.WriteLine("0. Zakończ program");
                string wybor = Console.ReadLine();

                switch(wybor)
                {
                    case "1":
                        DodajStudenta(student);
                        break;
                    case "2":
                        PobierzDaneStudenta(student);
                        break;
                    case "3":
                        AktualizujDaneStudenta(student);
                        break;
                    case "4":
                        UsunStudenta(student);
                        break;
                    case "5":
                        WyswietlListeStudentow(Student.studenci);
                        break;
                    case "6":
                        DodajNauczyciela(nauczyciel);
                        break;
                    case "7":
                        PobierzNauczyciela(nauczyciel);
                        break;
                    case "8":
                        AktualizujNauczyciela(nauczyciel);
                        break;
                    case "9":
                        UsunNauczyciela(nauczyciel);
                        break;
                    case "10":
                        WyswietlNauczycieli(Nauczyciel.nauczyciele);
                        break;
                    case "11":
                        DodajKurs(kurs);
                        break;
                    case "12":
                        PobierzKurs(kurs);
                        break;
                    case "13":
                        AktualizujKurs(kurs);
                        break;
                    case "14":
                        UsunKurs(kurs);
                        break;
                    case "15":
                        WyswietlKursy(Kurs.kursy);
                        break;
                    case "0":
                        zakoncz = true;
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                        break;


                }

            } while (!zakoncz); 

            /*
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

            //nauczyciele
            Nauczyciel nauczyciel1 = new Nauczyciel { Imie = "Piotr", Nazwisko = "Wisniewski" };
            nauczyciel1.Dodaj(nauczyciel1);
            Nauczyciel nauczyciel2 = new Nauczyciel { Imie = "Zenek", Nazwisko = "Martyniuk" };
            nauczyciel2.Dodaj(nauczyciel2);
            Nauczyciel nauczyciel3 = new Nauczyciel { Imie = "Karolina", Nazwisko = "Bocian" };
            nauczyciel3.Dodaj(nauczyciel3);
            Nauczyciel nauczyciel4 = new Nauczyciel { Imie = "Alina", Nazwisko = "Sum" };
            nauczyciel4.Dodaj(nauczyciel4); */

        }

        //studenci
        static void DodajStudenta(Student student)
        {
            Console.Write("Podaj imię studenta: ");
            student.Imie = Console.ReadLine();

            Console.Write("Podaj nazwisko studenta: ");
            student.Nazwisko = Console.ReadLine();

            student.Dodaj(student);
            Console.WriteLine("Dodano studenta!");

        }
        static void PobierzDaneStudenta(Student student)
        {
            Console.Write("Podaj ID studenta do pobrania: ");
            if (int.TryParse(Console.ReadLine(), out int studentId))
            {
                var pobranyStudent = student.Pobierz(studentId);
                if (pobranyStudent != null)
                {
                    Console.WriteLine($"ID: s{pobranyStudent.StudentId}, Imię i nazwisko: {pobranyStudent.Imie} {pobranyStudent.Nazwisko}");
                }
                else
                {
                    Console.WriteLine("Student o podanym ID nie istnieje.");
                }
            }
        }

        static void AktualizujDaneStudenta(Student student)
        {
            Console.Write("Podaj ID studenta do aktualizacji: ");
            if (int.TryParse(Console.ReadLine(), out int studentId))
            {
                var pobranyStudent = student.Pobierz(studentId);
                if (pobranyStudent != null)
                {
                    Console.Write("Nowe imię studenta: ");
                    pobranyStudent.Imie = Console.ReadLine();

                    Console.Write("Nowe nazwisko studenta: ");
                    pobranyStudent.Nazwisko = Console.ReadLine();

                    student.Aktualizuj(pobranyStudent);
                    Console.WriteLine("Zaktualizowano dane studenta.");
                }
                else
                {
                    Console.WriteLine("Student o podanym ID nie istnieje.");
                }
            }
        }

        static void UsunStudenta(Student student)
        {
            Console.Write("Podaj ID studenta do usunięcia: ");
            if (int.TryParse(Console.ReadLine(), out int studentId))
            {
                student.Usun(studentId);
                Console.WriteLine("Usunięto studenta o ID: s" + studentId);
            }
        }
        
        static void WyswietlListeStudentow(List<Student> studenci)
        {
            foreach (var student in studenci)
            {
                Console.WriteLine($"ID: s{student.StudentId}, Imię i nazwisko: {student.Imie} {student.Nazwisko}");
            }
        }

        //nauczyciele
        static void DodajNauczyciela(Nauczyciel nauczyciel)
        {
            Console.Write("Podaj imię nauczyciela: ");
            nauczyciel.Imie = Console.ReadLine();

            Console.Write("Podaj nazwisko nauczyciela: ");
            nauczyciel.Nazwisko = Console.ReadLine();

            nauczyciel.Dodaj(nauczyciel);
            Console.WriteLine("Dodano nauczyciela!");
        }
        static void PobierzNauczyciela(Nauczyciel nauczyciel)
        {
            Console.Write("Podaj ID nauczyciela do pobrania: ");
            if (int.TryParse(Console.ReadLine(), out int nauczycielId))
            {
                var pobranyNauczyciel = nauczyciel.Pobierz(nauczycielId);
                if (pobranyNauczyciel != null)
                {
                    Console.WriteLine($"ID: n{pobranyNauczyciel.NauczycielId}, Imię i nazwisko: {pobranyNauczyciel.Imie} {pobranyNauczyciel.Nazwisko}");
                }
                else
                {
                    Console.WriteLine("Nauczyciel o podanym ID nie istnieje.");
                }
            }
        }
        static void AktualizujNauczyciela(Nauczyciel nauczyciel)
        {
            Console.Write("Podaj ID nauczyciela do aktualizacji: ");
            if (int.TryParse(Console.ReadLine(), out int nauczycielId))
            {
                var pobranyNauczyciel = nauczyciel.Pobierz(nauczycielId);
                if (pobranyNauczyciel != null)
                {
                    Console.Write("Nowe imię nauczyciela: ");
                    pobranyNauczyciel.Imie = Console.ReadLine();

                    Console.Write("Nowe nazwisko nauczyciela: ");
                    pobranyNauczyciel.Nazwisko = Console.ReadLine();

                    nauczyciel.Aktualizuj(pobranyNauczyciel);
                    Console.WriteLine("Zaktualizowano dane nauczyciela.");
                }
                else
                {
                    Console.WriteLine("Nauczyciel o podanym ID nie istnieje.");
                }
            }
        }
        static void UsunNauczyciela(Nauczyciel nauczyciel)
        {
            Console.Write("Podaj ID nauczyciela do usunięcia: ");
            if (int.TryParse(Console.ReadLine(), out int nauczycielId))
            {
                nauczyciel.Usun(nauczycielId);
                Console.WriteLine("Usunięto nauczyciela o ID: n" + nauczycielId);
            }
        }
        static void WyswietlNauczycieli(List<Nauczyciel> nauczyciele)
        {
            foreach (var nauczyciel in nauczyciele)
            {
                Console.WriteLine($"ID: n{nauczyciel.NauczycielId}, Imię i nazwisko: {nauczyciel.Imie} {nauczyciel.Nazwisko}");
            }
        }


        //kursy
        static void DodajKurs(Kurs kurs)
        {
            Console.Write("Podaj nazwę kursu: ");
            kurs.NazwaKursu = Console.ReadLine();

            Console.Write("Podaj maksymalną liczbę osób: ");
            if (int.TryParse(Console.ReadLine(), out int maxLiczbaStudentow))
            {
                kurs.MaxLiczbaStudentow = maxLiczbaStudentow;
                kurs.Dodaj(kurs);
                Console.WriteLine("Dodano nowy kurs!");
            }
        }
        static void PobierzKurs(Kurs kurs)
        {
            Console.Write("Podaj ID kursu do pobrania: ");
            if (int.TryParse(Console.ReadLine(), out int kursId))
            {
                var pobranyKurs = kurs.Pobierz(kursId);
                if (pobranyKurs != null)
                {
                    Console.WriteLine($"ID: k{pobranyKurs.KursId}, Nazwa: {pobranyKurs.NazwaKursu}, Maksymalna liczba osób: {pobranyKurs.MaxLiczbaStudentow}");
                }
                else
                {
                    Console.WriteLine("Kurs o podanym ID nie istnieje.");
                }
            }
        }
        static void AktualizujKurs(Kurs kurs)
        {
            Console.Write("Podaj ID kursu do aktualizacji: ");
            if (int.TryParse(Console.ReadLine(), out int kursId))
            {
                var pobranyKurs = kurs.Pobierz(kursId);
                if (pobranyKurs != null)
                {
                    Console.Write("Nowa nazwa kursu: ");
                    pobranyKurs.NazwaKursu = Console.ReadLine();

                    Console.Write("Maksymalna liczba studentów: ");
                    if (int.TryParse(Console.ReadLine(), out int maxLiczbaStudentow))
                    {
                        pobranyKurs.MaxLiczbaStudentow = maxLiczbaStudentow;
                        kurs.Aktualizuj(pobranyKurs);
                        Console.WriteLine("Zaktualizowano dane kursu.");
                    }
                }
                else
                {
                    Console.WriteLine("Kurs o podanym ID nie istnieje.");
                }
            }
        }
        static void UsunKurs(Kurs kurs)
        {
            Console.Write("Podaj ID kursu do usunięcia: ");
            if (int.TryParse(Console.ReadLine(), out int kursId))
            {
                kurs.Usun(kursId);
                Console.WriteLine("Usunięto kurs o ID: k" + kursId);
            }
        }
        static void WyswietlKursy(List<Kurs> kursy)
        {
            foreach (var kurs in kursy)
            {
                Console.WriteLine($"ID: k{kurs.KursId}, Nazwa kursu: {kurs.NazwaKursu}, Maksymalna liczba studentów: {kurs.MaxLiczbaStudentow}");
            }
        }
    }
}