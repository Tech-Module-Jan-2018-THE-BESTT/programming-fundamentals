using System;

namespace Area
{
    class Problem04
    {
        static void Main(string[] args)
        {
            //here we receives 1 string and  3 random integers on the console
            string name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var sugar = int.Parse(Console.ReadLine());

            //we calculated the energy and sugar content for the given volume 
            var enrgyVolume = volume * energy / 100.0;
            var sugarVolume = volume * sugar / 100.0;

            //we printed  Volume – integer, suffixed by “ml”, Name and next line: Energy content – integer, suffixed by “kcal” , Sugar content – integer, suffixed by “g” 
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{enrgyVolume}kcal, {sugarVolume}g sugars");
        }
    }
}
