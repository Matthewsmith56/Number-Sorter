using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# Sharp to store elements in an array and print it.

            var numbers = new[] {5, 7, 2, 1, 8, 3, 10};

            int bse = 1;

            for (int y = 0; y < 1000; y++)
            {
                foreach (var i in numbers)
                {
                    if (i == bse)
                    {
                        Console.WriteLine(i);
                    }
                }

                bse++;
            }
        }
    }
}
