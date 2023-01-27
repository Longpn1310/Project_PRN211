using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Project_PRN211.Models;

namespace Project_PRN211
{
    public partial class ThemChiTieu : Form
    {
        private void ThemChiTieu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public ThemChiTieu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
                }).AsNoTracking().OrderBy(x => x.Ngaychi).ToList();
                var data2 = context.Wallets.Select(x => new
                {
                    TongDu = x.TongDu,
                    Kehoach = x.KeHoach,
                }).ToList();
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (Prn211_AsContext context = new Prn211_AsContext())
                {
                    ChiTieu c = new ChiTieu
                    {
                        SoTienChi = Decimal.Parse(textBoxSoTien.Text),
                        LoaiChi = textBoxLoaiHinh.Text,
                        LoaiChiTieu = textBoxMucDich.Text,
                        Ngaychi = DateTime.Parse(dateTimePicker1.Text),
                        GhiChu = textBox1.Text

                    };
                    if (c != null)
                    {
                        context.ChiTieus.Add(c);
                        if (context.SaveChanges() > 0)
                        {
                            MessageBox.Show("Đã thêm vào mục chi tiêu");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
