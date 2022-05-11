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
    public partial class QuanLyTk : Form
    {
        public QuanLyTk()
        {
            InitializeComponent();
        }

        private void QuanLyTk_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            dataGridViewTK.DataSource = AccountDAO.DanhSach();
        }

        private void buttonDangKy_Click(object sender, EventArgs e)
        {
            dangky();
        }

        private void buttonThemTK_Click(object sender, EventArgs e)
        {
            textBoxTK.Enabled = true;
            textBoxMK.Enabled = true;
            buttonDangKy.Enabled = true;
        }
        public void dangky()
        {
            int a = 2;
            if(radioButtonU.Checked == true)
            {
                a = 1;
            }
            else
            {
                if(radioButtonA.Checked == true)
                {
                    a = 0;
                }
                else
                {
                    MessageBox.Show("chưa chọn quyền");
                }
            }
            if (MessageBox.Show("Bạn có muốn tạo tài khoàn không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AccountDAO.Them(textBoxTK.Text, textBoxMK.Text, a.ToString());
                MessageBox.Show("Đăng ký thành công!");
                load();

            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu ad = new TrangChu();
            ad.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
