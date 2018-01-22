using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141293
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wycieczka asd = new Wycieczka("Francja",2000);
            //Console.WriteLine(asd.ToString());
            //Console.WriteLine(asd.Rabat());
            //WycieczkaKraj abc = new WycieczkaKraj("Niemcy", 2000, true);
            //Console.WriteLine(abc.ToString());
            //Console.WriteLine(abc.Rabat());

            List<Wycieczka> biuroPordozy = new List<Wycieczka>();
            Dictionary<string, float> slownik = new Dictionary<string, float>();
            Wycieczka w1 = new Wycieczka("Francja", 2000);
            Wycieczka w2 = new Wycieczka("Niemcy", 3500);
            Wycieczka w3 = new Wycieczka("Hiszpania", 5000);
            WycieczkaKraj wk1 = new WycieczkaKraj("Norwegia", 3700, true);
            WycieczkaKraj wk2 = new WycieczkaKraj("Polska", 1200, true);
            WycieczkaKraj wk3 = new WycieczkaKraj("Rosja", 4000, true);
            WycieczkaKraj wk4 = new WycieczkaKraj("Szwecja", 5500, true);
            WycieczkaKraj wk5 = new WycieczkaKraj("Irlandia", 4300, true);

            biuroPordozy.Add(w1);
            biuroPordozy.Add(w2);
            biuroPordozy.Add(w3);
            biuroPordozy.Add(wk1);
            biuroPordozy.Add(wk2);
            biuroPordozy.Add(wk3);

            foreach (var e in biuroPordozy)
            {
                Console.WriteLine(e.Rabat());
            }
            Console.WriteLine();

            foreach (var e in biuroPordozy)
            {
                Console.WriteLine(e.ToString());
            }
            biuroPordozy.Sort();
            biuroPordozy.Reverse();
            Console.WriteLine();
            foreach (var e in biuroPordozy)
            {
                if (biuroPordozy.IndexOf(e) % 2 != 0)
                    Console.WriteLine(e);
            }
            Console.WriteLine();
            slownik.Add("Jeden", 1);
            slownik.Add("dwa", 2);
            slownik.Add("trzy", 3);
            slownik.Add("cztery",4);
            slownik.Add("piec", 5);

            foreach (KeyValuePair<string, float> e in slownik)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    e.Key, e.Value);
            }
            Console.WriteLine();
            Queue<WycieczkaKraj> pensjonat = new Queue<WycieczkaKraj>();

            pensjonat.Enqueue(wk1);
            pensjonat.Enqueue(wk2);
            pensjonat.Enqueue(wk3);
            pensjonat.Enqueue(wk4);
            pensjonat.Enqueue(wk5);

            foreach (Object obj in pensjonat)
            {

                Console.WriteLine("{0}", obj);

            }
            Console.WriteLine();
            pensjonat.Clear();
            

            Rezerwacje zam = new Rezerwacje();
            zam.Dodaj("asd");
            zam.Dodaj('a');
            zam.Usun();

            Samolot cesna = new Samolot("Cesna 1336");


            Console.ReadKey();
        }
    }
}
