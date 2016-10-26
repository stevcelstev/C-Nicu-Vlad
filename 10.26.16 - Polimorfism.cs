/* 
 * Polimorfismul -------------------------------------------------------------
 * 
 * Polimorfismul reprezinta caracteristica unor clase de a se comporta difert.
 */

// EX1 -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfism
{
    class Baza
    {
        public void Metoda()
        {
            Console.WriteLine("Metoda clase de Baza");
        }
    }

    class Derivat : Baza 
    {
        public void Metoda()
        {
            Console.WriteLine("Metoda clase Derivate");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Derivat d = new Derivat();
            d.Metoda();
            Baza b = (Baza)d;
            b.Metoda();
        }
    }
}


// EX2 -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metode_virtuale
{
    class Baza
    {
        virtual public void Metoda()
        {
            Console.WriteLine("Metoda din Baza");
        }
    }
    
    class Derivat : Baza
    {
        public override void Metoda()
        {
            Console.WriteLine("Metoda din Derivat");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Derivat d = new Derivat();
            d.Metoda();
            Baza b = new Baza();
            b.Metoda();
            b = new Derivat();
            b.Metoda();
        }
    }
}


/*
 * Modificatorul Sealed
 * 
 * Nu poti suprascrie metodele / functiile care au "sealed" (sigilat)
 * @sealed (smecherie cu "@")
 * 
 */

// EX3 -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace @sealed
{
    class A
    {
        protected virtual void F(){}
        protected virtual void G(){}
    }

    class B : A 
    {
        protected sealed override void F(){}
        protected override void G(){}
    }

    class C : B 
    {
        // protected override void F(){} - Nu merge pentru ca e "sealed"
        protected override void G(){}
    }

    class Program
    {
        static void Main(string[] args)
        {
               
        }
    }
}
