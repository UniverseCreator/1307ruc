using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1307_dom06
{
    class IntegerValues
    {
        static void Main(string[] args)
        {
            Console.Write("Insert string: ");
            string type1 = (Console.ReadLine());
            Console.Write("Insert boolean: ");
            bool type2;
            int type3;
            try
            {
                type2 = Boolean.Parse(Console.ReadLine());
                Console.Write("Insert integer: ");
                type3 = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}, {1}, {2}", type1, type2, type3);
            }

            catch
            {
                Console.WriteLine("Wrong data input");
            }
        }
    }
}