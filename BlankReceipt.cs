using System;

namespace BlankReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeider();
            PrintBoddy();
            PrintFooter();
        }
        static void PrintHeider ()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("-- -- -- -- -- -- -- -- -- -- -- -- -- -- --");
        }
        static void PrintBoddy ()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void PrintFooter ()
        {
            Console.WriteLine("-- -- -- -- -- -- -- -- -- -- -- -- -- -- --");
            Console.WriteLine("© SoftUni");
        }
    }
}
