using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Insert second number: ");
            int num2= int.Parse(Console.ReadLine());
            int sum = num1 + num2;

            Console.WriteLine("The sum of: " + num1 + " + " + num2 + " is: " + sum);
            Console.ReadKey();
        }
    }
}
