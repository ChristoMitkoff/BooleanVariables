using System;

namespace ConsoleApp17
{
    class VariabelInHexadecimalFormat
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int output = Convert.ToInt32(input,16);
            Console.WriteLine(output);

                
        }
    }
}
