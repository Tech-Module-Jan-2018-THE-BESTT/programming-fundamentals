using System;
namespace Area
{
    class Problem_3
    {
        static void Main(string[] args)
        {
            // Initially we receive the parameter: input miles
            var miles = double.Parse(Console.ReadLine());

            // Next step we convert the input miles to kilometers
            var kilometers = miles * 1.60934;

            // Finally we print the result formated to the second decimal place.
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}