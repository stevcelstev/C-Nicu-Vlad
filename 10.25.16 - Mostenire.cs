/*
* Mostenirea -------------------------------------------------------------------------------------------------------------------
* 
* Mostenirea va permite sa creati o noua clasa care incorporeaza si extinde o clasa existenta. Daca in C++ o clasa putea mosteni
* mai multe clasa de baza in C# nu este permis decat una singura. In schimb se pot mosteni oricate interfete. Se foloseste ":" 
* pentru mostenire. In C# toate clase sunt mostenite.
* 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenire
{
    // clasa de baza
    class Animal
    {
        private string hrana;
        protected int sperantaViata;

        // proprietate
        public string Hrana 
        {
            set { hrana = value; }
            get { return hrana; }
        }
        protected void SeHraneste()
        {
            Console.WriteLine("Animalul se hraneste ");
        }
    }

    // clasa mostenita
    class Pisica : Animal 
    {
        private string rasa;
        public string Rasa
        {
            set { rasa = value; }
            get { return rasa; }
        }
        public void Toarce()
        {
            sperantaViata = 12;
            Hrana = "lapte";
            SeHraneste();
            Console.WriteLine("Pisica toarce");
        }
    }

    class Program 
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.Hrana = "carne";
            // a.hrana = "carne"; - gresit, camp privat
            // a.sperantaViata = 10; - gresit, camp protejat
            // a.SeHraneste(); - gresit, metoda protejata

            Pisica p = new Pisica();
            p.Hrana = "lapte";
            p.Rasa = "Siameza";
            p.Toarce();
            // p.hrana = "lapte" - gresit, camp privat
            // p.sperantaViata = 32; - gresit, camp protejat
            // p.SeHraneste(); - gresit, metoda protejata
        }
    }
}
