//CONFIRMED from <Nedelcho.Karageorgiev>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic_SyntaxExercises
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            //here we receives 4 random integers on the console
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            //here we can see them printed in 4-digit debit card format
            Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:D4}", num1, num2, num3, num4);
        }
    }
}