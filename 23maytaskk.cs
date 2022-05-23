using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 2, 4, 6, 8, 1, 3, 5, 9 };
            SortArray(ref num);
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
        }

        static Array SortArray(ref int[] num)
        {

            int temp = 0;
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;

                    }
                }
            }
            return num;
        }
    }
}
