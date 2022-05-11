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
    public partial class TTKH : Form
    {
        int idKH;
        public TTKH(int idKH)
        {
            InitializeComponent();
            this.idKH = idKH;
        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            if (ChuanHoa.CheckNull(textBoxTenKH.Text) || ChuanHoa.CheckNull(textBoxCMND.Text) || ChuanHoa.CheckNull(textBoxEmail.Text) || ChuanHoa.CheckNull(textBoxGT.Text) || ChuanHoa.CheckNull(textBoxSDT.Text))
            {
                if (MessageBox.Show("Bạn có muốn sửa Thông tin khách hàng này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    KHDAO.UpdateKH(int.Parse(labelId.Text), textBoxTenKH.Text, dateTimePickerNS.Text, textBoxCMND.Text, textBoxSDT.Text, textBoxEmail.Text, textBoxGT.Text);
                    textBoxTenKH.ReadOnly = true;
                    textBoxCMND.ReadOnly = true;
                    textBoxEmail.ReadOnly = true;
                    textBoxGT.ReadOnly = true;
                    textBoxSDT.ReadOnly = true;
                    MessageBox.Show("Sửa thành công!");
                    buttonXacNhan.Visible = false;
                    buttonSua.Visible = true;
                    buttonXóa.Visible = true;
                    buttonHuy.Visible = false;
                }

            }
        }

        private void buttonXóa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa Khách hàng này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                KHDAO.DeleteKH(int.Parse(labelId.Text.ToString()));
                MessageBox.Show("Xóa Thành công !", "Thông báo");
                buttonExit_Click(sender, e);
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            loadKH();
            textBoxTenKH.ReadOnly = true;
            textBoxCMND.ReadOnly = true;
            textBoxEmail.ReadOnly = true;
            textBoxGT.ReadOnly = true;
            textBoxSDT.ReadOnly = true;
            buttonXacNhan.Visible = false;
            buttonSua.Visible = true;
            buttonXóa.Visible = true;
            buttonHuy.Visible = false;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            textBoxTenKH.ReadOnly = false;
            textBoxCMND.ReadOnly = false;
            textBoxEmail.ReadOnly = false;
            textBoxSDT.ReadOnly = false;
            textBoxGT.ReadOnly = false;
            buttonXacNhan.Visible = true;
            buttonSua.Visible = false;
            buttonXóa.Visible = false;
            buttonHuy.Visible = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyKH f = new QuanLyKH();
            f.ShowDialog();
            this.Close();
        }

        private void TTKH_Load(object sender, EventArgs e)
        {
            loadKH();
        }
        public void loadKH()
        {
            int a = idKH;
            List<KhachHang> khachHangs = new List<KhachHang>();
            khachHangs = KHDAO.Load1KH(a);
            foreach (KhachHang item in khachHangs)
            {
                labelId.Text = item.Id.ToString();
                textBoxTenKH.Text = item.TenKH;
                dateTimePickerNS.Text = item.NgaySinh;
                textBoxCMND.Text = item.CMND;
                textBoxSDT.Text = item.SoDT;
                textBoxEmail.Text = item.Email;
                textBoxGT.Text = item.GioiTinh;
            }
        }

        private void dateTimePickerNS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
