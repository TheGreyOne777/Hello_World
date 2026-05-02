using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, xswap;

            Console.Write("Insert first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Insert second number: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Numbers before swapping are: {0} and {1}", num1, num2);

            xswap = num1;
            num1 = num2;
            num2 = xswap;

            Console.WriteLine("Numbers after swapping are: {0} and {1}", num1, num2);

            Console.ReadKey();
        }
    }
}
