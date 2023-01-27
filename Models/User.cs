using System;
using System.Collections.Generic;

namespace Project_PRN211.Models
{
    public partial class User
    {
        public int Userid { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Fullname { get; set; } = null!;
        public DateTime Dob { get; set; }
        public string Image { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool Role { get; set; }
    }
}
