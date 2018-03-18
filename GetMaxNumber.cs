using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            GetMaxNumber(first, second, third);
        }
        static void GetMaxNumber (int a, int b, int c)
        {
            if (a<b)
            {
                if (b<c)
                {
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(b);
                }
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
