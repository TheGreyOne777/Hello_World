using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_Counts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, count = 0;

            Console.WriteLine("Choose range of numbers: ");
            x = int.Parse(Console.ReadLine());

            int[] y = new int[x];
            Console.WriteLine("Insert only " + x + "numbers ");

            for(int z = 0; z < x; z++)
            {
                y[z] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int o in y)
            {
                if (o == 1)
                    count++;
            }
            Console.WriteLine("The number of 1 is: {0}",count);
            Console.ReadKey();
        }
    }
}
