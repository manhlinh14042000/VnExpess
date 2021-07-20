using System;
using System.Collections.Generic;
using System.Text;

namespace VnExpress.Data.Entities
{
    public class User
    {

        public int IdUser { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; } 
        public string ConfirmPassword { get; set; }
      
    }
}
