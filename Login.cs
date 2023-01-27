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
using Project_PRN211.Models;



namespace Project_PRN211
{
    public partial class Login : Form
    {
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (Prn211_AsContext context = new Prn211_AsContext())
                {
                    var data = context.Users.Where(x => x.Username.Equals(textBoxUsername.Text) && x.Password.Equals(textBoxPassword.Text)).Count();
                    if (data > 0)
                    {
                        MessageBox.Show("Login success");
                        string name = getNameByAccount(textBoxUsername.Text);
                        MainPage m = new MainPage();
                        m.Show();
                        this.Hide();
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
         public Login()
            {
         InitializeComponent();
                }

            private string getNameByAccount(string text)
            {
                using (Prn211_AsContext context = new Prn211_AsContext())
                {
                    User data = context.Users
                        .FirstOrDefault(u => u.Username.Equals(text));
                    return data.Username;

                }
                return "";
            }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
                }
