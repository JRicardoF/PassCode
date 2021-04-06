using System;

namespace PassCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var Pass = "";
            var CheckPass = "Secret";

            while (Pass != CheckPass)
            { 
            Console.WriteLine("Please insert your Username");
            var UserName = Console.ReadLine();

            Console.WriteLine("Please insert your Password");
            Pass = Console.ReadLine();            

            if (Pass != CheckPass)
                    { 
                Console.WriteLine("UserName or Password does not Match. Please try Again");
                    }
            }

            Console.WriteLine("You are now Logged in.");
        }

    }
}
