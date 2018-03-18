using System;
using System.Linq;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int biggerLength = Math.Max(firstArray.Length, secondArray.Length);
            int[] summed = new int[biggerLength];
            if (firstArray.Length == secondArray.Length)
            {
                summed = GetArrayEqual(firstArray, secondArray, firstArray.Length);
                foreach (var item in summed)
                {
                    Console.Write(item);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            else if(firstArray.Length>secondArray.Length) //first[6] > second[2]
            {
               GetArrayFirstBigger(firstArray, secondArray, biggerLength);
            }
            else if (firstArray.Length<secondArray.Length) //first[2] > secong[6]
            {
                GetArraySecondBigger(firstArray, secondArray, biggerLength);
            }
           
        }
        static int[] GetArrayEqual(int[]a , int[]b, int length)
        {
            int[] summed = new int[length];
            for (int i = 0; i<length; i++)
            {

                summed[i] = a[i] + b[i];
            }
            return summed;
        }
        static void GetArrayFirstBigger(int[] a, int[]b, int length)
        {
            var sum = a.Length;
            for (int i = 0; i<=a.Length; i++)
            {
                sum = (a[i % a.Length] + b[i % b.Length]);
                if (i >= a.Length)
                {
                    break;
                }
                Console.Write(sum + " ");
            }
            Console.WriteLine();
        }
        static void GetArraySecondBigger(int[] a, int[] b, int length)
        {
            var sum = b.Length;
            for (int i = 0; i <= b.Length; i++)
            {
                sum = (a[i % a.Length] + b[i % b.Length]);
                if (i >= b.Length)
                {
                    break;
                }
                Console.Write(sum + " ");
            }
            Console.WriteLine();
        }
    }
}
