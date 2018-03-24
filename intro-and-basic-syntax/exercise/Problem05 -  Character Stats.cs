// CONFIRMED from Nedelcho.Karageorgiev
using System;

namespace Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            //here we receive their name, current health, maximum health, current energy and maximum energy
            string name = Console.ReadLine();
            int currentH = int.Parse(Console.ReadLine());
            int maxHelath = int.Parse(Console.ReadLine());
            int currentE = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            //here we draw the corresponding health and energy wands and the remaining positions with no so called nowands=dots
            var wands = new string('|', currentH);
            var nowands = new string('.', maxHelath - currentH);
            var eWands = new string('|', currentE);
            var noeWands = new string('.', maxEnergy - currentE);

            //TODO
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{wands}{nowands}|");
            Console.WriteLine($"Energy: |{eWands}{noeWands}|");


            //Name: Mayro
             //Health: ||||||.....|
               //Energy: ||||||||||.|
            
        }
    }
}
