using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MyShopSolution.ViewModel.System.Users
{
    public class RegisterRequest
    {
        [DisplayName("Họ")]
        public string FirstName { get; set; }

        [DisplayName("Tên")]
        public string LastName { get; set; }

        [DisplayName("Ngày sinh")]
        public DateTime Dob { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Số điện thoại")]
        public string PhoneNumber { get; set; }

        [DisplayName("Tài khoản")]
        public string UserName { get; set; }

        [DisplayName("Mật khẩu")]
        public string Password { get; set; }

        [DisplayName("Xác nhận mật khẩu")]
        public string ConfirmPassword { get; set; }
    }
}
