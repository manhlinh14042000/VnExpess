using System;
using System.Collections.Generic;
using System.Text;

namespace VnExpress.ViewModel.Users
{
    public class LoginRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Remember { get; set; }
    }
}
