using System;
using System.Linq;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            
            foreach(var a in array.Reverse())
            {
                Console.Write(a);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
