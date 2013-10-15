using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1307_dom02
{
    class IntegerValues
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int number3;
            Console.Write("Insert number 1: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Insert number 2: ");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("Insert number 3: ");
            number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the numbers is {0}.",number1 + number2 + number3);
        }
    }
}