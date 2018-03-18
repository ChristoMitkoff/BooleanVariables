using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                double result = Math.Round(array[i], MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}", array[i], result);
            }

        }
    }
}
