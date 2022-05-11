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
    public partial class QuanLyKH : Form
    {
        public QuanLyKH()
        {
            InitializeComponent();
        }

        private void QuanLyKH_Load(object sender, EventArgs e)
        {
            loadlistKH();
        }
        public void loadlistKH()
        {
            List<KhachHang> khachHangs = KHDAO.KhachHangLoad();
            dataGridViewKH.DataSource = khachHangs;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu ad = new TrangChu();
            ad.ShowDialog();
            this.Close();
        }


        private void buttonSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Có thể chỉnh sửa tại bảng", "thông báo!");
            dataGridViewKH.ReadOnly = false;
            buttonHoanThanh.Visible = true;
            buttonSua.Visible = false;

        }

        private void dataGridViewKH_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridViewKH.CurrentCell.RowIndex;
            string query = "UPDATE KhachHang SET TenKH = N'" + dataGridViewKH.Rows[i].Cells["TenKH"].Value.ToString() + "',GioiTinh = N'" + dataGridViewKH.Rows[i].Cells["GioiTinh"].Value.ToString()  + "', SoCMND = '" + dataGridViewKH.Rows[i].Cells["SoCMND"].Value.ToString() + "', SoDT = '"+ dataGridViewKH.Rows[i].Cells["SoDT"].Value.ToString() +"', Email = '" + dataGridViewKH.Rows[i].Cells["Email"].Value.ToString() + "'WHERE MaKH = '" + dataGridViewKH.Rows[i].Cells["MaKH"].Value.ToString() + "'";

            dataprovider.addconnect(query);
            MessageBox.Show("Sửa Thành công!");
        }

        private void buttonHoanThanh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("kết thúc chỉnh sửa tại bảng", "thông báo!");
            buttonSua.Visible = true;
            dataGridViewKH.ReadOnly = true;
            buttonHoanThanh.Visible = false;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = dataGridViewKH.CurrentCell.RowIndex;
                string query = "DELETE FROM KhachHang WHERE MaKH = '" + dataGridViewKH.Rows[i].Cells["MaKH"].Value.ToString() + "'";

                dataprovider.addconnect(query);
                MessageBox.Show("Xóa thành công!");
                loadlistKH();
            }
               
        }
    }
}
