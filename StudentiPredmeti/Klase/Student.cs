using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentiPredmeti.Klase
{
    public class Student
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Indeks { get; set; }

        public override string ToString()
        {
            return $"({Indeks}) {Ime} {Prezime}";
        }

    }
}
