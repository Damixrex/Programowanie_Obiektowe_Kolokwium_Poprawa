using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141293
{
    class WycieczkaKraj : Wycieczka
    {
        private bool vip;

        public WycieczkaKraj(string kierunek, double cena, bool vip)
            : base(kierunek, cena)
        {
            this.vip = vip;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override double Rabat()
        {
            return (base.Rabat() * 4) / 3;
        }

    }
}
