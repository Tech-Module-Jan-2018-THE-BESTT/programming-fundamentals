using System;

namespace Problem_2._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //we receives width and height far  -  integers  on the console  
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            //we calculated area
            double area = width * height;

            ////we printed in format
            Console.WriteLine($"{area:f2}");
        }
    }
}
