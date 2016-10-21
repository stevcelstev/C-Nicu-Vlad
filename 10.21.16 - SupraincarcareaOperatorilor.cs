using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase_partiale
{
    /*partial class A
    {
        public void F()
        {
            Console.WriteLine("Metoda F");
        }
    }

    partial class A
    {
        public void G()
        {
            Console.WriteLine("Metoda G");
        }
    }
    */
    public class Fractie
    {
        int numarator;
        int numitor;

        public static int Cmmdc(int a, int b)
        {
            if (b == 0) return a;
            return Cmmdc(b, a % b);
        }

        //Constructor
        public Fractie(int numarator, int numitor)
        {
            int div = Cmmdc(numarator, numitor);
            numarator /= div;
            numitor /= div;
            this.numarator = numarator;
            this.numitor = numitor;
        }

        //Supraincarcarea lui +
        public static Fractie operator+ (Fractie f1, Fractie f2)
        {
            int A = f1.numarator * f2.numitor + f2.numarator * f1.numitor;
            int B = f1.numitor * f2.numitor;
            int cm = Cmmdc(A, B);
            A /= cm;
            B /= cm;
            return new Fractie(A, B);
        }

        public static bool operator== (Fractie f1, Fractie f2)
        {
            if (f1.numitor == f2.numitor && f1.numarator == f2.numarator) return true;
            return false;
        }

        public static bool operator !=(Fractie f1, Fractie f2)
        {
            return !(f1 == f2);
        }

        //Suprascriere
        public override string ToString()
        {
            string s = numarator.ToString() + "/" + numitor.ToString();
            return s;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
                    Clase partiale
             * 
             * O clasa poate fi impartita in cadrul aceluiasi fisier in doua sau mai multe parti folosind cuvantul "partial".
             * 
             *      Supraincarcarea operatorilor
             *      
             * Operatorii pot fi supraincarcati folosind functii publice si statice
             * Transmiterea parametrilor se face prin valoare
             * 
             */
            /*
            A a = new A();
            a.F();
            a.G();
            */
            
            Fractie a = new Fractie(3, 4);
            Fractie b = new Fractie(2, 4);
            Fractie c = a + b;
            Console.WriteLine("{0} = {1} + {2}", c.ToString(), a.ToString(), b.ToString());
            Fractie d = new Fractie(2, 4);
            if (d == b) Console.WriteLine("Egale");
            if (a != b) Console.WriteLine("Diferite");
            a += b;
            Console.WriteLine("a= " + a);

        }
    }
}
