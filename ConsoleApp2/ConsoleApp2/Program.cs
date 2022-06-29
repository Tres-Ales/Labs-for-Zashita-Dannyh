using System;
using System.IO;
using System.Linq;

namespace TretyakovaAV_JetBrains
{
    class Program
    {
        static void Main()
        {
            int[] arr1 = { 1, 2, 3, 3, 4, 5, 10 };

            int[] arr2 = { 1, 2, 3, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] arr3 = arr1.Intersect(arr2).ToArray();

            foreach (var i in arr3)
            { Console.Write("{0} ", i); }
        }
    }
}