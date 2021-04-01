using System;
using System.Collections.Generic;

namespace _2021_04_01_Linq_Hell
{
    class Program
    {
        static void Main(string[] args)
        {
            int MinNumber = -101;
            int MaxNumber = 101;
            Random RandomNumberGenerator = new Random();
            int [] The20Numbers = new int [20];
            for (int i = 0; i < The20Numbers.Length; i++)
            {
                The20Numbers[i] = RandomNumberGenerator.Next(MinNumber, MaxNumber);
            }
            Console.WriteLine($"Neigiami skaiciai {0}", );



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