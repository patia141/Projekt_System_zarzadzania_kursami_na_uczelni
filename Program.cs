using Projekt_system_zarzadzania_kursami_na_uczelni;
using System;
using System.Collections.Generic;

namespace System_zarzadzania_kursami_na_uczelni
{
    class Program
    {
        static void Main()
        {
            OperacjeStudenci operStud = new OperacjeStudenci();
            OperacjeNauczyciele operNaucz = new OperacjeNauczyciele();
            OperacjeKursy operKurs = new OperacjeKursy();
            bool zakoncz = false;

            //dodanie przykladowych danych
            Student student1 = new Student { Imie = "Jan", Nazwisko = "Kowalski" };
            operStud.Dodaj(student1);
            Student student2 = new Student { Imie = "Patrycja", Nazwisko = "Lipa" };
            operStud.Dodaj(student2);
            Student student3 = new Student { Imie = "Kamil", Nazwisko = "Zachodni" };
            operStud.Dodaj(student3);
            Student student4 = new Student { Imie = "Tadeusz", Nazwisko = "Szczotka" };
            operStud.Dodaj(student4);

            Nauczyciel nauczyciel1 = new Nauczyciel { Imie = "Piotr", Nazwisko = "Wisniewski" };
            operNaucz.Dodaj(nauczyciel1);
            Nauczyciel nauczyciel2 = new Nauczyciel { Imie = "Ewa", Nazwisko = "Buniowska" };
            operNaucz.Dodaj(nauczyciel2);
            Nauczyciel nauczyciel3 = new Nauczyciel { Imie = "Stanisław", Nazwisko = "Kolorowy" };
            operNaucz.Dodaj(nauczyciel3);
            Nauczyciel nauczyciel4 = new Nauczyciel { Imie = "Wiktoria", Nazwisko = "Żuraw" };
            operNaucz.Dodaj(nauczyciel4);

            Kurs kurs1 = new Kurs { NazwaKursu = "Matematyka", MaxLiczbaStudentow = 30 };
            operKurs.Dodaj(kurs1);
            Kurs kurs2 = new Kurs { NazwaKursu = "Angielski", MaxLiczbaStudentow = 12 };
            operKurs.Dodaj(kurs2);
            Kurs kurs3 = new Kurs { NazwaKursu = "Geografia", MaxLiczbaStudentow = 20 };
            operKurs.Dodaj(kurs3);
            Kurs kurs4 = new Kurs { NazwaKursu = "Fizyka", MaxLiczbaStudentow = 25 };
            operKurs.Dodaj(kurs4);

            //menu
            Console.WriteLine("System zarządzania kursami na uczelni");
            
            do
            {
                Console.WriteLine("\nWybierz jedną z opcji:");
                Console.WriteLine("1. Dodaj studenta");
                Console.WriteLine("2. Znajdź studenta");
                Console.WriteLine("3. Aktualizuj dane studenta");
                Console.WriteLine("4. Usuń studenta");
                Console.WriteLine("5. Wyświetl studentów");

                Console.WriteLine("6. Dodaj nauczyciela");
                Console.WriteLine("7. Znajdź nauczyciela");
                Console.WriteLine("8. Aktualizuj dane nauczyciela");
                Console.WriteLine("9. Usuń nauczyciela");
                Console.WriteLine("10. Wyświetl nauczycieli");

                Console.WriteLine("11. Dodaj kurs");
                Console.WriteLine("12. Znajdź kurs");
                Console.WriteLine("13. Aktualizuj informacje o kursie");
                Console.WriteLine("14. Usuń kurs");
                Console.WriteLine("15. Wyświetl listę kursów");

                Console.WriteLine("0. Zakończ program\n");
                string wybor = Console.ReadLine();

                switch(wybor)
                {
                    case "1":
                        DodajStudenta(operStud);
                        break;
                    case "2":
                        PobierzDaneStudenta(operStud);
                        break;
                    case "3":
                        AktualizujStudenta(operStud);
                        break;
                    case "4":
                        UsunStudenta(operStud);
                        break;
                    case "5":
                        operStud.WyswietlStudentow();
                        break;
                    case "6":
                        DodajNauczyciela(operNaucz);
                        break;
                    case "7":
                        PobierzDaneNauczyciela(operNaucz);
                        break;
                    case "8":
                        AktualizujNauczyciela(operNaucz);
                        break;
                    case "9":
                        UsunNauczyciela(operNaucz);
                        break;
                    case "10":
                        operNaucz.WyswietlNauczycieli();
                        break;
                    case "11":
                        DodajKurs(operKurs);
                        break;
                    case "12":
                        PobierzKurs(operKurs);
                        break;
                    case "13":
                        AktualizujKurs(operKurs);
                        break;
                    case "14":
                        UsunKurs(operKurs);
                        break;
                    case "15":
                        operKurs.WyswietlListeKursow();
                        break;
                    case "0":
                        zakoncz = true;
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.\n");
                        break;


                }

            } while (!zakoncz); 
        }

        //funkcje
        //studenci
        static void DodajStudenta(OperacjeStudenci operStud)
        {
            Student student = new Student();

            Console.Write("Podaj imię studenta: ");
            student.Imie = Console.ReadLine();

            Console.Write("Podaj nazwisko studenta: ");
            student.Nazwisko = Console.ReadLine();

            operStud.Dodaj(student);
            Console.WriteLine("Dodano studenta!");

        } 
        static void PobierzDaneStudenta(OperacjeStudenci operStud)
        {
            Console.Write("Podaj ID studenta do pobrania: ");
            if (int.TryParse(Console.ReadLine(), out int studentId))
            {
                var pobranyStudent = operStud.Pobierz(studentId);
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
        static void AktualizujStudenta(OperacjeStudenci operStud)
        {
            Console.Write("Podaj ID studenta do aktualizacji: ");
            if (int.TryParse(Console.ReadLine(), out int studentId))
            {
                var pobranyStudent = operStud.Pobierz(studentId);
                if (pobranyStudent != null)
                {
                    Console.Write("Nowe imię studenta: ");
                    string noweImie = Console.ReadLine();

                    Console.Write("Nowe nazwisko studenta: ");
                    string noweNazwisko = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(noweImie))
                    {
                        pobranyStudent.Imie = noweImie;
                    }

                    if (!string.IsNullOrWhiteSpace(noweNazwisko))
                    {
                        pobranyStudent.Nazwisko = noweNazwisko;
                    }

                    operStud.Aktualizuj(pobranyStudent); 
                    Console.WriteLine("Zaktualizowano dane studenta.");
                }
                else
                {
                    Console.WriteLine("Student o podanym ID nie istnieje.");
                }
            }
            else
            {
                Console.WriteLine("Wprowadzono błędny format danych.");
            }
        }
        static void UsunStudenta(OperacjeStudenci operStud)
        {
            Console.Write("Podaj ID studenta do usunięcia: ");
            if (int.TryParse(Console.ReadLine(), out int studentId))
            {
                bool czyUsunieto = false;
                operStud.Usun(studentId);

                var usunietyStudent = operStud.Pobierz(studentId);
                czyUsunieto = usunietyStudent == null;

                if (czyUsunieto)
                {
                    Console.WriteLine("Usunięto studenta o ID: s" + studentId);
                }
                else
                {
                    Console.WriteLine("Student o podanym ID nie istnieje.");
                }
            }
            else
            {
                Console.WriteLine("Wprowadzono błędne dane.");
            }
        }

        //nauczyciele
        static void DodajNauczyciela(OperacjeNauczyciele operNaucz)
        {
            Nauczyciel nauczyciel = new Nauczyciel();

            Console.Write("Podaj imię nauczyciela: ");
            nauczyciel.Imie = Console.ReadLine();

            Console.Write("Podaj nazwisko nauczyciela: ");
            nauczyciel.Nazwisko = Console.ReadLine();

            operNaucz.Dodaj(nauczyciel);
            Console.WriteLine("Dodano nauczyciela!");

        }
        static void PobierzDaneNauczyciela(OperacjeNauczyciele operNaucz)
        {
            Console.Write("Podaj ID nauczyciela do pobrania: ");
            if (int.TryParse(Console.ReadLine(), out int nauczycielId))
            {
                var pobranyNauczyciel = operNaucz.Pobierz(nauczycielId);
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
        static void AktualizujNauczyciela(OperacjeNauczyciele operNaucz)
        {
            Console.Write("Podaj ID nauczyciela do aktualizacji: ");
            if (int.TryParse(Console.ReadLine(), out int nauczycielId))
            {
                var pobranyNauczyciel = operNaucz.Pobierz(nauczycielId);
                if (pobranyNauczyciel != null)
                {
                    Console.Write("Nowe imię nauczyciela: ");
                    string noweImie = Console.ReadLine();

                    Console.Write("Nowe nazwisko nauczyciela: ");
                    string noweNazwisko = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(noweImie))
                    {
                        pobranyNauczyciel.Imie = noweImie;
                    }

                    if (!string.IsNullOrWhiteSpace(noweNazwisko))
                    {
                        pobranyNauczyciel.Nazwisko = noweNazwisko;
                    }

                    operNaucz.Aktualizuj(pobranyNauczyciel);
                    Console.WriteLine("Zaktualizowano dane nauczyciela.");
                }
                else
                {
                    Console.WriteLine("Nauczyciel o podanym ID nie istnieje.");
                }
            }
            else
            {
                Console.WriteLine("Wprowadzono błędny format danych.");
            }
        }
        static void UsunNauczyciela(OperacjeNauczyciele operNaucz)
        {
            Console.Write("Podaj ID nauczyciela do usunięcia: ");
            if (int.TryParse(Console.ReadLine(), out int nauczycielId))
            {
                bool czyUsunieto = false;
                operNaucz.Usun(nauczycielId);

                var usunietyNauczyciel = operNaucz.Pobierz(nauczycielId);
                czyUsunieto = usunietyNauczyciel == null;

                if (czyUsunieto)
                {
                    Console.WriteLine("Usunięto nauczyciela o ID: n" + nauczycielId);
                }
                else
                {
                    Console.WriteLine("Nauczyciel o podanym ID nie istnieje.");
                }
            }
            else
            {
                Console.WriteLine("Wprowadzono błędny format danych.");
            }
        }

        //kursy
        static void DodajKurs(OperacjeKursy operKurs)
        {
            Kurs kurs = new Kurs();

            Console.Write("Podaj nazwę kursu: ");
            kurs.NazwaKursu = Console.ReadLine();

            Console.Write("Podaj maksymalną liczbę studentów: ");
            if (int.TryParse(Console.ReadLine(), out int maxLiczbaStudentow))
            {
                kurs.MaxLiczbaStudentow = maxLiczbaStudentow;
                operKurs.Dodaj(kurs);
                Console.WriteLine("Dodano nowy kurs!");
            }
        }
        static void PobierzKurs(OperacjeKursy operKurs)
        {
            Console.Write("Podaj ID kursu do pobrania: ");
            if (int.TryParse(Console.ReadLine(), out int kursId))
            {
                var pobranyKurs = operKurs.Pobierz(kursId);
                if (pobranyKurs != null)
                {
                    Console.WriteLine($"ID: k{pobranyKurs.KursId}, Nazwa: {pobranyKurs.NazwaKursu}, Maksymalna liczba studentów: {pobranyKurs.MaxLiczbaStudentow}");
                }
                else
                {
                    Console.WriteLine("Kurs o podanym ID nie istnieje.");
                }
            }
        }
        static void AktualizujKurs(OperacjeKursy operKurs)
        {
            Console.Write("Podaj ID kursu do aktualizacji: ");
            if (int.TryParse(Console.ReadLine(), out int kursId))
            {
                var pobranyKurs = operKurs.Pobierz(kursId);
                if (pobranyKurs != null)
                {
                    Console.Write("Nowa nazwa kursu: ");
                    pobranyKurs.NazwaKursu = Console.ReadLine();

                    Console.Write("Maksymalna liczba studentów: ");
                    if (int.TryParse(Console.ReadLine(), out int maxLiczbaStudentow))
                    {
                        pobranyKurs.MaxLiczbaStudentow = maxLiczbaStudentow;
                        operKurs.Aktualizuj(pobranyKurs);
                        Console.WriteLine("Zaktualizowano dane kursu.");
                    }
                }
                else
                {
                    Console.WriteLine("Kurs o podanym ID nie istnieje.");
                }
            }
        }
        static void UsunKurs(OperacjeKursy operKurs)
        {
            Console.Write("Podaj ID kursu do usunięcia: ");
            if (int.TryParse(Console.ReadLine(), out int kursId))
            {
                bool czyUsunieto = false;
                operKurs.Usun(kursId);

                var usunietyKurs = operKurs.Pobierz(kursId);
                czyUsunieto = usunietyKurs == null;

                if (czyUsunieto)
                {
                    Console.WriteLine("Usunięto kurs o ID: k" + kursId);
                }
                else
                {
                    Console.WriteLine("Kurs o podanym ID nie istnieje.");
                }
            }
        }
    }
}