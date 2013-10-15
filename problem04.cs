using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1307_dom04
{
    class IntegerValues
    {
        static void Main(string[] args)
        {
            //first method
            Console.Write("Insert number 1: ");
            float number1 = float.Parse(Console.ReadLine());
            Console.Write("Insert number 2: ");
            float number2 = float.Parse(Console.ReadLine());
            float number3 = number1;
            number1 = number2;
            number2 = number3;
            Console.WriteLine("Number 1: {0}, number 2: {1}", number1, number2);
            //second method
            Console.Write("Insert number 1: ");
            float number4 = float.Parse(Console.ReadLine());
            Console.Write("Insert number 2: ");
            float number5 = float.Parse(Console.ReadLine());
            number4 += number5;
            number5 = number4 - number5;
            number4 -= number5;
            Console.WriteLine("Number 1: {0}, number 2: {1}", number4, number5);
        }
    }
}