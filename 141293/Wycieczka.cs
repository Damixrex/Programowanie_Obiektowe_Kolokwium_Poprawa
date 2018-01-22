using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141293
{
    class Wycieczka:IComparable<Wycieczka>
    {
        private string kierunek;
        private double cena;

        public Wycieczka(string kierunek,double cena)
        {
            this.kierunek = kierunek;
            this.cena = cena;

        }
        public override string ToString()
        {
            return "Wycieczka: " + kierunek + ", cena: " + cena;
        }
        public virtual double Rabat()
        {
            double temp = cena / 2;
            return temp;
        }
        public int CompareTo(Wycieczka other)
        {
            return cena.CompareTo(cena);
        }
    }
}
