using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_PRN211.DBContext;

namespace Project_PRN211
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (PRN211_ProjectContext context = new PRN211_ProjectContext())
                {
                    var data = context.Accounts.Where(x => x.Username.Equals(textBoxUsername.Text) && x.Password.Equals(textBoxPassword.Text)).Count();
                    if (data > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Thong tin dang nhap khong chinh xac");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
