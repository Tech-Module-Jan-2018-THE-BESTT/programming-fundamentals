uusing System;

namespace Area
{
    class Problem_3
    {
        static void Main(string[] args)
        {
            var miles = double.Parse(Console.ReadLine());
            var kilometers = miles * 1.60934;

            Console.WriteLine($"{kilometers:F2}");
        }
    }
}