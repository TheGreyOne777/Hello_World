using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearCoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert any year to check Leap year: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x % 4 == 0)
            {
                Console.WriteLine("Year  " + x + " is a Leap Year ");
            }
            else
            {
                Console.WriteLine("Year  " + x + " is not a Leap Year ");
            }
            Console.ReadKey();  
        }
    }
}
