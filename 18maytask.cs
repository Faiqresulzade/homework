using System;

namespace _18maytask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,3,5,6};
            int[] arr2 = { 3, 6 };
            string joinarr = string.Join(" ", arr);
            string joinarr2 = string.Join(" ", arr2);

            Console.WriteLine(joinarr.Contains(joinarr2));

           
        }
    }
}
