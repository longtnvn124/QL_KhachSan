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
    public partial class QuanLyPhong : Form
    {
        int idP = 0;
        public QuanLyPhong()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void showP()
        {
            List<Phong> phong = PhongDAO.LoadPhong();
            dataGridViewPhong.DataSource = phong;
        }

        private void QuanLyPhong_Load(object sender, EventArgs e)
        {
            showP();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Có thể chỉnh sửa tại bảng", "thông báo!");
            dataGridViewPhong.ReadOnly = false;
            buttonHT.Visible = true;
            buttonSua.Visible = false;
        }

        private void buttonHT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("kết thúc chỉnh sửa tại bảng", "thông báo!");
            buttonSua.Visible = true;
            dataGridViewPhong.ReadOnly = true;
            buttonHT.Visible = false;
        }

        private void dataGridViewPhong_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridViewPhong.CurrentCell.RowIndex;
            string query = "UPDATE Phong SET TenPhong = N'" + dataGridViewPhong.Rows[i].Cells["TenPhong"].Value.ToString() + "',ThongTin = N'" + dataGridViewPhong.Rows[i].Cells["ThongTin"].Value.ToString() + "', TinhTrang = N'" + dataGridViewPhong.Rows[i].Cells["TinhTrang"].Value.ToString() + "', LoaiPhong = N'" + dataGridViewPhong.Rows[i].Cells["LoaiPhong"].Value.ToString() + "', GiaPhong = '" + dataGridViewPhong.Rows[i].Cells["GiaPhong"].Value.ToString() + "'WHERE MaPhong = '" + dataGridViewPhong.Rows[i].Cells["MaPhong"].Value.ToString() + "'";

            dataprovider.addconnect(query);
            MessageBox.Show("Sửa Thành công!");
            //idP = int.Parse(dataGridViewPhong.Rows[i].Cells["MaPhong"].Value.ToString());
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemPhong ad = new ThemPhong();
            ad.ShowDialog();
            //this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu ad = new TrangChu();
            ad.ShowDialog();
            this.Close();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            if(idP == 0)
            {
                MessageBox.Show("bạn chưa chọn phòng cần xem");
            }
            else
            {
                this.Hide();
                ChiTietPhong ad = new ChiTietPhong(idP);
                ad.ShowDialog();
                this.Close();
            }
            
        }

        private void dataGridViewPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridViewPhong.CurrentCell.RowIndex;
            idP = int.Parse(dataGridViewPhong.Rows[i].Cells["MaPhong"].Value.ToString());
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
