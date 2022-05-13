using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_may_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 60, 120, 140, 19 };
            int avg = CalcAvg(arr);


            if (avg > 60)
            {
                Console.WriteLine("Mezun oldunuz");
            }
            else
            {
                Console.WriteLine("Mezun ola bilmediniz");
            }

        }
        static int CalcAvg(int[] arr)
        {
            int sum = 0;
            int say = 0;
            int avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
                say++;
            }
            avg = sum / say;

            return avg;
        }
    }
}
