using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_system_zarzadzania_kursami_na_uczelni
{
    public interface IWalidacja<T>
    {
        bool Waliduj(T obiekt);
    }
}
