using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift2
{
   class Account
    {
        // dessa är atrubute för klassen Account 
        public string username; 
        public string password; 
        public string email; 
        public string phoneNumber;
        
        // dessa är metoder för klassen Account 
        public void Login()
        {
            Console.WriteLine("You are now logged in.");
        }
    }
}
