using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delegari
{
    public delegate double Mydelegate();

    public class Cerc
    {
        public double raza;
        private const float PI = 3.14149f;

        public double Aria()
        {
            return (PI * raza * raza);
        }
        public double LungFrontiera()
        {
            return (2 * PI * raza);
        }
        public Cerc(double r)
        {
            raza = r;
        }

    }
    
    class DelegateDemo
    {
        public static void Main(string[] args)
        {
            /*
             *      Delegari
             *      
             * Delegarile reprezinta un tip referinta utilizat sa incapsuleze o lista ordonata de metode cu aceeasi semnatura ca si tipul de retur.
             * O delegare se declara astfel : folosind cuvantul cheie delegate
	     *
             */ 
             

            Cerc c = new Cerc(3);
            Mydelegate del = new Mydelegate(c.Aria);
            Console.WriteLine("Aria = {0:#.##}", del());
            del = new Mydelegate(c.LungFrontiera);
            Console.WriteLine("Lungimea frontierei = {0:#.##}", del());
            
        }
    }
}
