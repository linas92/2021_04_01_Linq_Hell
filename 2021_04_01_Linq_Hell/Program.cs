using System;
using System.Collections.Generic;

namespace _2021_04_01_Linq_Hell
{
    class Program
    {
        static void Main(string[] args)
        {
            int MinNumber = -100;
            int MaxNumber = 100;
            Random RandomNumberGenerator = new Random();
            int [] The20Numbers = new int [20];
            for (int i = 0; i < The20Numbers; i++)
            {
                The20Numbers[i] = RandomNumberGenerator.Next(MinNumber, MaxNumber);
            }

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