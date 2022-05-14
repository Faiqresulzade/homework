using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practis
{
   // Parametrinde array qebul edib, arrayin ededlerinin cemin tapan ve o cemin 2e bolunub bolunmemesini geri qaytaran bir method yazin.
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(master(11, 14, 16));
        }
        static bool master(params int[] num)
        {
           int  sum = 0;
            bool result =false;
            for (int i = 0; i < num.Length; i++) 
            {
                sum = num[i] + sum;
            }
            if (sum % 2 == 0)
            {
                result = true;
                return result;
            }
            return result;
            
        }
    }
}
