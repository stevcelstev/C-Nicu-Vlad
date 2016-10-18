using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader cin = new StreamReader("D:\\12A\\Visual\\date.txt");
            string linie = cin.ReadLine();
            cin.Close(); char[] separator = { ' ' };

            string[] cuvinte = linie.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            StreamWriter cout = new StreamWriter("D:\\12A\\Visual\\date.out");
            foreach (string cuv in cuvinte)
                cout.WriteLine(cuv);
            cout.Close();
            
            // INPUT: Doua puncte doua puncte paranteza paranteza
            
            // OUTPUT: *Doua
            //         *puncte
            //         *doua
            //         *puncte
            //         *paranteza
            //         *paranteza
        }
    }
}
