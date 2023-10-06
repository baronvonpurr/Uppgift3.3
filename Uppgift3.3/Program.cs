using System;

namespace Uppgift3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bilen?");
            int timmar = int.Parse(Console.ReadLine());
            int maxpris = timmar * 80;
            
            if (maxpris <= 950)
            {
                Console.WriteLine("Det kommer kosta " +  maxpris + "Kr");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Det kostar " + (maxpris - 950) + "kr för mycket!");
                Console.ReadKey();
            }
        }
    }
}