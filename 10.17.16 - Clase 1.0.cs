using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    // Constante
    class C
    {
        public const int H = 12;
    }

    // Constructori
    class Masina
    {
        public string marca;
        public int pret;

        public Masina()
        {
            marca = "Dacia";
            pret = 10000;
        }

        public Masina(string m)
        {
            marca = m;
            pret = 1000;
        }

        public Masina(int p)
        {
            marca = "Logan";
            pret = p;
        }

        public Masina(string m, int p)
        {
            marca = m;
            pret = p;
        }
    }

    // Operatorul This
    class Copil
    {
        string nume;
        int varsta;

        public Copil(string nume, int varsta)
        {
            this.nume = nume;
            this.varsta = varsta;
        }

        public Copil ModificVarsta(int varsta)
        {
            this.varsta = varsta;
            return this;
        }

        public void Afiseaza()
        {
            Console.WriteLine(nume + " " + varsta);
        }
        // Destructor
        ~Copil()
        {
            Console.WriteLine("Am distrus obiectul");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Lectia de 17-10-16 
             * Clase in C#
             * O clasa din C# permite urmatorii specificatori:
             * -public:poate fi accesat de oriunde
             * -private:acces limitat doar la propria clasa
             * -protected:acces limitat doar la propria clasa si la clasele derivate din aceasta
             * -internal:acces limitat la programul respectiv
             * -protected internal:atat programul cat si clasele derivate
             * 
             * Membri statici si membri nestatici ai unei clase
             * Variabilele statice pot exista si fara obiect pe cand cele nestatice sunt oblicatoriu prin intermediul unui obiect de tip clasa
             * Pentru obiectele statice se aloca memorie, pe cand la cele nestatice se aloca memorie in mod automat
             * 
             * Constante in cadrul unei clase
             * Constatele se comporta la fel ca variabilele statice
             * 
             * Constructori
             * Constructorii reprezinta metode speciale ale clasei care au rolul de a crea obiectele
             * O clasa are cel putin un contructor. Daca nu se defineste constructorul , se creeaza in mod automat
             * Pot fi declarati statici, privati
             * Daca ati creat un constructor nu se mai creeaza constructor implicit 
             * 
             * Operatorul This
             * This reprezinta o referinta pentru obiectul curent
             * 
             * Destructorul clasei
             * Destructorul este o metoda speciala care distruge instantsele claselor. Desi o clasa are mai multi constructori , poate avea doar un singur destructor
             * De cele mai multe ori nu mai e nevoie de destructori , din princina GarbageCollector-ului
             * Aveti nevoie de destructor atunci cand trebuie gestionate obiecte care nu tin de .NET Framework
             * Destructorii au acelasi nume ca numele clasei, nu au parametrii si au un tilda (~) in fata
             * 
             * Proprietati
             * 
            */

            // Constante
            Console.WriteLine(C.H);

            //Constructori
            Masina m = new Masina("Audi", 50000);
            Masina m1 = new Masina();
            Masina m2 = new Masina("Opel");
            Masina m3 = new Masina(20000);
            Console.WriteLine(m.marca + " " + m.pret + "\n");
            Console.WriteLine(m1.marca + " " + m1.pret + "\n");
            Console.WriteLine(m2.marca + " " + m2.pret + "\n");
            Console.WriteLine(m3.marca + " " + m3.pret + "\n");

            //Operatorul This
            Copil c = new Copil("Oana", 17);
            c.Afiseaza();
            c.ModificVarsta(18);
            c.Afiseaza();

        }
    }
}
