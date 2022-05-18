using System;

namespace _18maytask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 6 };
            int[] arr2 = { 1, 5 };
            Console.WriteLine(IsArrayContains(arr, arr2));


        }
        static bool IsArrayContains(int[] arr,int []arr2)
        {
            string joinarr = string.Join(" ", arr);
            string joinarr2 = string.Join(" ", arr2);

           return joinarr.Contains(joinarr2);
        }
    }
}
