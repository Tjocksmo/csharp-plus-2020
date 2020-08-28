using System;

namespace Session02Excersise04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ange ålder: ");

            //var input = Console.ReadLine();
            //var integer = Convert.ToInt32(input);

            //if (integer >= 18)
            //{
            //    Console.WriteLine("Du får köpa tobaksprodukter.");
            //}
            //else
            //{
            //    Console.WriteLine("Du får inte köpa tobak! ");
            //}

            //if (integer >= 40)
            //{
            //    Console.WriteLine("Men du är för gammal för att röka!");
            //}

            Console.WriteLine("Ange en badtemperatur i grader C: ");

            var input = Console.ReadLine();
            var integer = Convert.ToInt32(input);

            string waterLabel = integer >= 27 ? "Det går bra att bada" : "Det går inte att bada";
            Console.WriteLine($"{waterLabel} i havet!");

            Console.WriteLine("Tryck på valfri tangent för att avsluta...");
            Console.ReadKey(true);
        }
    }
}
