using System;
using System.Runtime.CompilerServices;

namespace Excample02
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Do you want to enter your name? (y/n)");
            var key = Console.ReadKey();

            if (key.KeyChar == 'n')
                return;

            else if (key.KeyChar == 'y')
            {
                Console.WriteLine("\nEnter your name: ");
                var name = Console.ReadLine();

                Console.WriteLine($"Hello, {name}");
            }
            else
            {
                Console.WriteLine("\nI don't understand?");                
            }
            Console.WriteLine("Press any key to exit program...");
            Console.ReadKey(true);
        }
    }
}
