using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopSolution.ViewModel.System.Users
{
    public class LoginRequest
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public bool RemeberMe { get; set; }
    }
}
