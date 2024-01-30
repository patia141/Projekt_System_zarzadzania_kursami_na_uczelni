using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_system_zarzadzania_kursami_na_uczelni
{
    public interface IOperacjeCRUD<T>
    {
        void Dodaj(T obiekt);
        T Pobierz(int id);
        void Aktualizuj(T obiekt);
        void Usun(int id);
    }
}
