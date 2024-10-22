
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class UserClass : IAccount
    {
        int Id;
        private static int _id;
        

        string FullName;
        string Email;
        string Password;

        public UserClass(string fullname, string email, string password)
        {
            _id++;
            Id= _id;
            FullName = fullname;
            Email = email;
            Password = password;
        }
        public bool PasswordChecker(string password)
        {
            bool check = false;
            if (password.Length >= 8 && Regex.IsMatch(password, @"[A-Z]") && Regex.IsMatch(password, @"[a-z]") && Regex.IsMatch(password, @"[0-9]"))
            {
                check = true;
            }
            return check;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Id: " + Id + "FullName: "  + FullName  + "Email:  " + Email);
        }
    }
}
