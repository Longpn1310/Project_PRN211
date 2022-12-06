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
            DataProvider d = new DataProvider(); 
            try
            {
                string strSelect = "select Username, Password from Users where Username = @username and Password = @password";
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@username",textBoxUsername.Text),
                    new SqlParameter("@password",textBoxPassword.Text)
                };
                IDataReader dr = d.executeQuery2(strSelect, param);
                if (dr.Read())
                {
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Thong tin dang nhap khong chinh xac!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thong tin dang nhap khong chinh xac!" + ex.Message);
            }

        }
    }
}
