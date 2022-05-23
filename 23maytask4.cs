namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            user IamUser = new user
            {
                Name = "faiq",
                Password = "r",
            };
            System.Console.WriteLine(IamUser.IsPasswordValid("faiq", "resulzade123"));
        }
    }
    class user
    {
        public string Name;
        public string Password;

        public bool IsPasswordValid(string name, string Password)
        {
            int i = 0;
            int j = 0;
            bool result = true;
            int sum = 0;
            foreach (var item in Password)
            {
                for (int k = 0; k < 10; k++)
                {
                    if (item.ToString()==k.ToString())
                    {
                        sum++;
                    }
                    
                   
                   
                }
               
                //"resulzade1"
            }
            if (sum == 0)
            {
                result = false;
            }


            while (i < name.Length && j < Password.Length)
            {
                if (Password.Length < 6)
                {
                    result = false;

                }
                //Name = "123",
                //Password = "123resulzade123",
                if (Password[j] == name[i])
                {
                    i++;
                    j++;
                    if (j == name.Length)
                    {
                        result = false;
                    }
                }
                else
                {
                    i = i - j + 1;
                    j = 0;
                }



            }

            return result;
        }



    }
}
