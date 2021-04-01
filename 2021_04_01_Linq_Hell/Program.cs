using System;
using System.Collections.Generic;

namespace _2021_04_01_Linq_Hell
{
    class Program
    {
        public static List<int> skaiciai = new List<int> {-55, 93, 37, -17, 7, -82, 100,-55, -38, 37, 5, 7, 8, 10, -55, 3, 31, 5, 7, 8, 10,-55, 3, -94, 5, 7, 8, 10, };

        static void Main(string[] args)
        {
            Console.WriteLine("Skaiciu maximali reiksme {0}",
                skaiciai.Where(s => s <=0 ).Distinct()
                );

            Console.WriteLine("Goodbye Cruel World!");
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
        }
    }
}
/*          Sugeneruoti 20 elementų masyvą su reikšmėmis nuo -100 iki 100.
            a) Suskaičiuoti teigiamas reikšmes.
            b) Suskaičiuoti neigiamas reikšmes.
            c) Atspausdinti kurių reikšmių daugiau (teigiamu/neigiamu/po lygiai).


*/