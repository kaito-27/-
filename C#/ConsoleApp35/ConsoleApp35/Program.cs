using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Pre(new User() { Name = null, Address = null, Birthday = null }));
        }

        static string Pre(User user)
        {
            return user.Address ?. Prefecture ?? "不明";
        }
    }

    class User
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public DateTime? Birthday { get; set; }
    }

    class Address
    {
        public string Prefecture { get; set; }
        public string AddresAfterPrefecture { get; set; }
    }
}
