using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            var circeArea = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("{0:f12}", circeArea);

        }
    }
}
