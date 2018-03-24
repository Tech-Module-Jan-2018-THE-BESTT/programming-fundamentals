using System;

namespace Area
{
    class Problem04
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var sugar = int.Parse(Console.ReadLine());
            var enrgyVolume = volume * energy / 100.0;
            var sugarVolume = volume * sugar / 100.0;
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{enrgyVolume}kcal, {sugarVolume}g sugars");
        }
    }
}
