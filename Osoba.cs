using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    [Serializable]
    public class Osoba
    {
        public string ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public string Wiek { get; set; }    
        public string Stanowisko { get; set; }

        public Osoba() { }

        public Osoba(string id, string imie, string nazwisko, string wiek, string stanowisko)
        {
            ID = id;
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
            Stanowisko = stanowisko;
        }
    }
}
