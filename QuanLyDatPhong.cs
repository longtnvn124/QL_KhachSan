using QLKSpj.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKSpj
{
    public partial class QuanLyDatPhong : Form
    {
        public QuanLyDatPhong()
        {
            InitializeComponent();
        }

        private void QuanLyDatPhong_Load(object sender, EventArgs e)
        {
            loadlist();
        }
        public void loadlist()
        {
            dataGridViewDP.DataSource = HopDongDAO.DanhSach();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu ad = new TrangChu();
            ad.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatPhongV f = new DatPhongV();
            f.ShowDialog();
        }
    }
}
