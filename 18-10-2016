using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DenyInvataDeLaStev
{
    class Copil
    {
        string nume;
        int varsta;

        public Copil(string n, int v)
        {
            nume = n;
            varsta = v;
        }

        // Proprietatea Nume
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        // Proprietatea Varsta
        public int Varsta
        {
            get { return varsta; }
            set { varsta = value; }
        }

    }

    class Tablou
    {
        private int[] a;
        private int n;
        private const int MAX = 100;

        public Tablou(int dim)
        {
            n = dim;
            a = new int[n];
        }
        public int this[int index]
        {
            get
            {
                if (index < 0) return a[0];
                else if (index > MAX) return a[MAX];
                else return a[index];
            }
            set
            {
                if (index < 0) a[0] = value;
                else if (index > MAX) a[MAX] = value;
                else a[index] = value;
            }
        }
    }

    class A
    {
        public class B
        {
            public void F() { Console.WriteLine("Clasa int F()"); }
        }
    }

    /*
             Indexatori
     * 
     * Indexatorii reprezinta instantsele unei clase sau ale unei structuri, sa fie indexate la fel ca un tablou
     * Acesti indexatori sunt similari d.p.d.v sintactic cu proprietatile.Asta inseamna ca:
     * -Au doi accesori (set si get)
     * -Nu defineste o locatie de memorie
     * -Pot sa nu fie asociate unui tip
     * Diferenta dintre proprietati si indexatori este ca proprietatea acceseaza doar un singur element pe cand indexatorii
     * acceseaza mai multi membri
     * Intotdeauna numele unui indexator este THIS
     *
     * 
     *      Clase interioate
     *
     * O clasa interioara este o clasa a carei definitie se gaseste in interiorul altei clase
     * Se mai numesc inner class sau nested class
     * Pentru a instantia un obiect de tipul clasei interioare nu este nevoie sa creem si un obiect al clasei exterioare
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {
            Copil c = new Copil("IoaneCriminalu'", 18);  // get
            Console.WriteLine(c.Nume + " " + c.Varsta + "\n");  // set
            c.Nume = "PictorVonta";
            c.Varsta = 44;
            Console.WriteLine(c.Nume + " " + c.Varsta + "\n");  // set

            Tablou t = new Tablou(100);
            for (int i = 0; i < 10; i++)
                t[i] = i;  //set
            t[-1] = 10;
            for (int i = 0; i < 10; i++) Console.WriteLine(t[i] + " ");

            Console.WriteLine("\n"); // Spatiere pentru ordonare

            A.B obj = new A.B();
            obj.F();
        }
    }
}
