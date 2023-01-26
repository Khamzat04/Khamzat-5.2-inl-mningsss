using System;

namespace Uppgift_5._
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] tal = new int[3];

            tal[0] = 2;
            tal[1] = 4;

            {
                Console.WriteLine("den Första talet " + tal[0]);
                Console.WriteLine("den Andra tal " + tal[1]);
                Console.WriteLine("Skriv in det tredje talet");
            }
            tal[2] = int.Parse(Console.ReadLine());

            Console.WriteLine($"Alla tal och den du skrev är {tal[0]}, {tal[1]}, {tal[2]}");


        }

    }
}







        

    



