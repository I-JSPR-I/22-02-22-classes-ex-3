using System;
using System.Collections;
using System.Collections.Generic;
namespace _22_02_22_classes_ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CD> CDLijst = new List<CD>();
            do
            {
                Input(CDLijst);
                Console.WriteLine("Wilt u nog een liedje toevoegen?? (J/N)");
            } while (Console.ReadLine().ToUpper().Substring(0, 1) == "J");
            output(CDLijst);
        }

        private static void output(List<CD> CDLijst)
        {
            Console.WriteLine($"Er zijn {CDLijst.Count} Liedjes");
            Console.WriteLine();
            Console.WriteLine();

        }

        private static List<CD> Input(List<CD> CDLijst)
        {
            CD Data;
            Console.Clear();
            Data = new CD();

            Console.WriteLine("Wat is de titel van het lied?");
            Data.Titel = Console.ReadLine();

            Console.WriteLine("Wie is de uitvoerder van het lied");
            Data.Uitvoerder = Console.ReadLine();


            CDLijst.Add(Data);
            return CDLijst;
        }
    }
}
