using System;

namespace _12maytaskk
{
    class Program
    {
        static void Main(string[] args)
        {
           
            IsPrime(9);
         
        }









        static void IsPrime(int a) 
        {

           
            int say = 0;
            bool result = false;
            for (int i = 1; i <= a; i++)
            {

                if (a % i == 0)
                {
                    say++;

                }
            }
            if (a == 1 || a == 0)
            {
                Console.WriteLine("daxile edilen eded ne sadedir ne de murekkeb");

            }
            else if (say > 2)
            {
                Console.WriteLine(result);
            }
            else
            {
                result = true;
                Console.WriteLine(result);
            }

            
        }
            
    } 
}




