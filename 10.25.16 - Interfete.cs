using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Interfete
{
    interface IPrintare
    {
        void Print(string s);
    }

    public class Mail : IPrintare
    {
        private string s;

        public Mail(string s)
        {
            this.s = s;
        }

        public void Print(string a)
        { Console.WriteLine(s + a); }
    }

    class Animal // Clasa de baza
    {
        private string hrana;
        protected int speranta_Viata;

        public string Hrana //Proprietate
        {
            set { hrana = value; }
            get { return hrana; }
        }

        protected void SeHraneste()
        {
            Console.WriteLine("Animalul se hraneste ");
        }

        class Pisica : Animal //Mostenita
        {
            private string rasa;

            public string Rasa
            {
                set { rasa = value; }
                get { return rasa; }
            }

            public void Toarce()
            {
                speranta_Viata = 12;
                Hrana = "lapte";
                SeHraneste();
                Console.WriteLine("Pisica toarce");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                /*
                 *      Interfete
                 * 
                 *  O interfata reprezinta un tip referinta in care sunt definite metode , clasele si structurile pot mosteni oricat de multe interfete
                 *  , dar clasa respectiva trebuie sa implementeze toate metodele interfetei
                 * 
                 * 
                 *      Mostenirea
                 * 
                 *  Mostenirea permite crearea unei noi clase care incorporeaza si extinde o clasa existenta
                 *  Daca in C++ o clasa putea mosteni mai multe clase de baza , in CS nu este permis de cat una singura.
                 *  In schimb se pot mosteni orcate interfete.Pentru mostenire se foloseste operatorul ":"
                 *  
                 */

                Mail m = new Mail("Salut ");
                m.Print("celor din C Sharp!");

                Animal x = new Animal();
                x.Hrana = "carne";
                //x.hrana = "carne"; - gresit - camp privat
                //x.speranta_Viata; - gresit - camp protejat
                //x.SeHraneste(); - gresit - metoda protejata

                Pisica p = new Pisica();
                p.Hrana = "lapte";
                p.Rasa = "Siameza";
                p.Toarce();
                //p.hrana = "lapte"; - camp privat
                //p.speranta_Viata = 32; - camp protejat
                //p.SeHraneste(); - metoda protejata
            }
        }
    }
}
