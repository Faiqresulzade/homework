using System;

namespace _24maytask
{
    class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public bool IsAdult;

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            IsAdult = false;
            if (age > 18)
            {
                IsAdult = true;
                Console.WriteLine(IsAdult);
            }

            else
                Console.WriteLine(IsAdult);
        }
    }
}
