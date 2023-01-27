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
    public partial class MainPage : Form
    {
        private void MainPage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public MainPage()
        {
            InitializeComponent();
        }
        public MainPage(string username)
        {
            InitializeComponent();
            this.Text = "Hello" + username;
        }
        private void LoadData()
        {
            using (Prn211_AsContext context = new Prn211_AsContext())
            {
                var data = context.ChiTieus.Select(x => new
                {
                    Loaichi = x.LoaiChi,
                    LoaiChiTieu = x.LoaiChiTieu,
                    Ngaychi = x.Ngaychi,
                    Ghichu = x.GhiChu,
                    Sotienchi = x.SoTienChi
                }).OrderBy(x => x.Ngaychi).ToList();
                dataGridView1.DataSource = data;
                var data2 = context.Wallets.Select(x => new
                {
                    TongDu = x.TongDu,
                    Kehoach = x.KeHoach,
                }).ToList();
                textBoxUserName.DataBindings.Clear();
                textBoxUserName.DataBindings.Add("Text", data2, "TongDu");
                int sum = 0;
                int sum2 = 0;
                sum = dataGridView1.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToInt32(t.Cells[4].Value));
                sum2 = Int32.Parse(textBoxUserName.Text) - sum;
                textBoxTongTien.Text = sum2.ToString();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ThemChiTieu t = new ThemChiTieu();
            t.Show();
        }
    }
}

