using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17maytask
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string name="Nurlan Faiq Emil Tural Yusif"; //{nurlan,faiq}
            Console.WriteLine(ReturnString("Nurlan Faiq Emil Tural Yusif"));
           
        }
        static string ReturnString(string name)
        {


            string[] namearr = name.Split(' ');

            string b = "";
            foreach (var item in namearr)

            {
                for (int j = item.Length - 1; j >= 0; j--)
                {
                    b =b+ item[j];

                }
                b = b + " ";
            }
            return b;




        }
       
    }
}
