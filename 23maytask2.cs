using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
           string [] name={"faiq","beyler","mirqubad"};
            char herf = 'i';
            namechecked(name, herf);
        }

        static void namechecked(string[] name ,char herf)
        {
            foreach (var item in name)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (item[i] == herf)
                    {
                        Console.WriteLine(item);
                    }
                }

            }
           
        }
    }
}
