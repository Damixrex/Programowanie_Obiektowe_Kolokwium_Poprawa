using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141293
{
    class Rezerwacje : IOperacje
    {
        public List<string> stos = new List<string>();

        public void Dodaj(string wartosc)
        {
            stos.Add(wartosc);
        }
        public void Dodaj(char wartosc)
        {
            stos.Add(System.Convert.ToString(wartosc));
        }
        public void Usun()
        {
            stos.RemoveAt(1);
        }
    }
}
