using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_for_Test {

    class _C {
        private int re, im;

        protected _C() {
            re = im = 0;
        }

        protected _C(int a, int b) {
            re = a;
            im = b;
        }

        protected int r {
            get { return re; }
            set { re = value; }
        }
        
        protected int i {
            get { return im; }
            set { im = value; }
        }

        virtual public double Mod() {
            return 2;
        }
    }
    
    class complex : _C {
        public complex() : base(0, 0) { }
        public complex(int x) : base(x, 0) { }
        public complex(int x, int y) : base(x, y) { }
        public complex(complex x) : base(x.r, x.i) { }
        ~complex() { }

        public override double Mod() {
            return Math.Sqrt(this.r * this.r + this.i * this.i);
        }

        public int R
        {
            get { return r; }
            set { r = value; }
        }

        public int I
        {
            get { return i; }
            set { i = value; }
        }

        static public complex operator +(complex a, complex b) {
            complex c = new complex(a.r + b.r, a.i + b.i);
            return c;
        }

        static public complex operator -(complex a) {
            complex b = new complex(-a.r, -a.i);
            return b;
        }

        static public complex operator ++(complex a) {
            a.r++;
            return a;
        }

        static public bool operator ==(complex a, complex b) {
            return (a.r == b.r) && (a.i == b.i);
        }

        static public bool operator !=(complex a, complex b) {
            return !((a.r == b.r) && (a.i == b.i));
        }
    }

    class complex_vector : complex {
        complex[] v;

        public complex_vector(int n) {
            v = new complex[n];
            for (int i = 0; i < n; i++) {
                complex c = new complex(0);
                v[i] = c;
            }
        }

        public complex this[int index] {
            get {
                complex c;
                if (index < 0) return (c = new complex(-1));
                return v[index];
            }
            set {
                v[index] = value;
            }
        }
    }

    class Program {

        static void swap(ref int a, ref int b) {
            int c = a;
            a = b;
            b = c;
        }

        static complex make_complex(int x) {
            complex a = new complex(x);
            return a;
        }

        static void Main(string[] args) {
           /* complex x = new complex(3, 5);
            complex y = new complex(4, 6); 
            Console.WriteLine(x.Mod());
            Console.WriteLine(x.R + " + " + x.I + "i");
            Console.WriteLine("{0}, {1}", x == y, y != x);*/
            complex_vector v = new complex_vector(6);
            v[2] = make_complex(15);
            int x = 2, y = 3;
            swap(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);
            /*for (int i = 1; i <= 5; i++)
                Console.WriteLine(v[i].R);*/
        }
    }
}
