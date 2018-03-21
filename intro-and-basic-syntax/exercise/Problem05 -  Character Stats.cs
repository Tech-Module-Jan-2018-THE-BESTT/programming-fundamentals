using System;

namespace Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int currentH = int.Parse(Console.ReadLine());
            int maxH = int.Parse(Console.ReadLine());
            int currentE = int.Parse(Console.ReadLine());
            int maxE = int.Parse(Console.ReadLine());
            var wands = new string('|', currentH);
            var nowands = new string('.', maxH - currentH);
            var eWands = new string('|', currentE);
            var noeWands = new string('.', maxE - currentE);


            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{wands}{nowands}|");
            Console.WriteLine($"Energy: |{eWands}{noeWands}|");


            //Name: Mayro
             //Health: ||||||.....|
               //Energy: ||||||||||.|
            //Console.WriteLine("Hello World!");
        }
    }
}
