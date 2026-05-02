using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.Write("Insert any number: ");
            x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.Write("This is an Even number: ");
            }
            else
            {
                Console.Write("This is an ODD number ");
            }
            Console.ReadKey();
        }
    }
}
