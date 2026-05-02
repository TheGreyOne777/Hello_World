using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_ASCII_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;

            Console.Write("Insert any Characcter: ");
            ch = Char.Parse(Console.ReadLine());

            Console.WriteLine("The value of the ASCII character is: " + (int)ch);

            Console.ReadLine();
        }
    }
}
