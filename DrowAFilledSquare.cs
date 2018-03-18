using System;

namespace DrowAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTopOrBottom(n);
            PrintHeaderRows(n);
            PrintTopOrBottom(n);

        }
        static void PrintTopOrBottom (int n )
        {
            Console.WriteLine(new string('-', 2 * n));
        }
        static void PrintMiddleRow (int n )
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
        static void PrintHeaderRows (int n)
        {
            for (int i = 0; i <n-2; i++)
            {
                PrintMiddleRow(n);
            }

        }
    }
}
