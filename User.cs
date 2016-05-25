using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class User
    {
        public Dictionary<int, string> Users = new Dictionary<int, string>();

        public User()
        {
            Console.WriteLine("Starting User...");
            Console.WriteLine("Loading users..");
            this.Users.Add(0, "test0");
            this.Users.Add(1, "test1");
            this.Users.Add(2, "test2");
            this.Users.Add(2, "test3");
        }

        public string getUserNameById(int Id)
        {
          if (this.Users.ContainsKey(Id))
          {
                return this.Users[Id];
          }

          return "Not Found";

        }

        public void setUserName(string username)
        {
          Random rnd = new Random();
          while(this.Users.ContainsKey(Int32.Parse(rnd.ToString())) == true){
                rnd.NextDouble();
            }

            this.Users.Add(Int32.Parse(rnd.ToString()), username);

        }
    }
}
