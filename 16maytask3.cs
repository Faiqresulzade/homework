using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// parametrinde en ve hundurluk alib , asagidaki kimi bir piramida cap eden method yazin. meselen  en 5 , hundurluk 5 ->
//    *
//    * *
//    * * *
//    * * * *
//    * * * * * 
namespace _16maytaskk2
{
    class Program
    {
        static void Main(string[] args)
        {
            Master(5, 5);
        }
        static void Master(int en, int uzunluq)
        {
            for (int j = 0; j < en; j++)
            {

                for (int i = 1; i < uzunluq; i++)
                {
                    
                    Console.Write("*");
                    

                }
                uzunluq--;
                Console.WriteLine("*");
            }
        }
    }
}
