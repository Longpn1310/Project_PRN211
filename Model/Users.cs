using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRN211.Model
{
    internal class Users
    {
        private string username { get; set; }
        private string password { get; set; }
        private int wallet { get; set; }
        private string email { get; set; }
        private int cccd { get; set; }
        private int creditcard { get; set;}

        private bool role { get; set; }

        public Users()
        {
        }

        public Users(string username, string password, int wallet, string email, int cccd, int creditcard, bool role)
        {
            this.username = username;
            this.password = password;
            this.wallet = wallet;
            this.email = email;
            this.cccd = cccd;
            this.creditcard = creditcard;
            this.role = role;
        }
    }
}
