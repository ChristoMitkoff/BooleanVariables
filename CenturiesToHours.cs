using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace ConsoleApp14
{
    class CenturiesToHours
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int years = 100 * centuries;
            long days = (long)(365.2422 * years);
            long hours = days * 24;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours");
        }
       
    }
}
