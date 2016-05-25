using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            Console.WriteLine("Want to search for a user?");
            string action = Console.ReadLine();
            if (action == "y" || action == "Y" || action == "yes")
            {
                Console.WriteLine("User id (int)");
                try
                {
                    int id = Int32.Parse(Console.ReadLine());
                    User user = new User();
                    var username = user.getUserNameById(id);
                    if (username == "Not Found") {
                        Console.WriteLine("Sorry we couldn't find the user");
                    } else {
                        Console.WriteLine("Find: " + username);
                    }

                }
                catch
                {
                    throw new System.ArgumentException("id must be integer");
                }

            }
            else
            {
                Console.WriteLine("Bye.");
            }
        }
    }
}
