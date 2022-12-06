using System;
using System.Collections.Generic;

namespace Project_PRN211.Model
{
    public partial class Account
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Citizencard { get; set; } = null!;
        public bool Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Creditcard { get; set; } = null!;
        public bool Role { get; set; }
        public string Address { get; set; } = null!;
    }
}
