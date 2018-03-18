using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));

        }
        public static bool IsPrime (int n )
        {
            if (n == 1)
            { return false; }
            if (n == 2)
            {
                return false;
            }
            if (n % 2 ==0 )
            { return false; }
            var boundary = (int)Math.Floor(Math.Sqrt(n));
            for (int i = 3; i <= boundary; i+=2)
            {
                if (n % i == 0)

                { return false; }
                
            }
            return true;
        }
    }
}
