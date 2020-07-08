using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyShopSolution.ViewModel.System.Users
{
    public class UserUpdateRequest
    {
        [DisplayName("Id")]
        public Guid Id { get; set; }

        [DisplayName("Họ")]
        public string FirstName { get; set; }

        [DisplayName("Tên")]
        public string LastName { get; set; }

        [DisplayName("Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Số điện thoại")]
        public string PhoneNumber { get; set; }
    }
}
