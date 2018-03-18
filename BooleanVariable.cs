using System;

namespace ConsoleApp17
{
    class VariableInHexadecimalFormat
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            bool areEqual = false;
            decimal difference = Math.Abs(a - b);
            if (difference > 0.000001m)
            {
                areEqual = true;
            }
            if (areEqual == true)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
    

}
