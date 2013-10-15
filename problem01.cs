using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1307_dom01
{
    class IntegerValues
    {
        static void Main(string[] args)
        {
            string name1;
            string name2;
            string name3;
            Console.Write("Insert name 1: ");
            name1 = Console.ReadLine();
            Console.Write("Insert name 2: ");
            name2 = Console.ReadLine();
            Console.Write("Insert name 3: ");
            name3 = Console.ReadLine();
            Console.WriteLine("Greetings to {0}, {1} and {2}!",name1, name2, name3);
        }
    }
}