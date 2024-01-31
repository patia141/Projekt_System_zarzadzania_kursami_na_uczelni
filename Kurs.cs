using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_system_zarzadzania_kursami_na_uczelni
{
    public class Kurs
    {
        public int KursId { get; set; }
        public string NazwaKursu { get; set; }
        public int MaxLiczbaStudentow { get; set; }
    }
}
