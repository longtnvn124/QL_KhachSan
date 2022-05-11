using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKSpj.DAO;

namespace QLKSpj
{
    public partial class ChiTietPhong : Form
    {
        int idP;
        public ChiTietPhong(int idP)
        {
            InitializeComponent();
            this.idP = idP;
        }


        private void ChiTietPhong_Load(object sender, EventArgs e)
        {
            loadP();
        }
        public void loadP()
        {
            int a = idP;
            //Phong item = new Phong();
            List<Phong> phong = new List<Phong>();
            phong = PhongDAO.Load1p(a);
            foreach (Phong item in phong)
            {
                labelId.Text = item.Id.ToString();
                textBoxTenPhong.Text = item.Ten;
                richTextBoxThongTin.Text = item.ThongTin;
                textBoxTinhTrang.Text = item.TinhTrang;
                textBoxLoai.Text = item.Loai;
                textBoxGiaP.Text = item.Tien.ToString();
            }
        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            //ChuanHoa c = new ChuanHoa();
            if (ChuanHoa.CheckNull(textBoxTenPhong.Text) || ChuanHoa.CheckNull(textBoxTinhTrang.Text) || ChuanHoa.CheckNull(richTextBoxThongTin.Text) || ChuanHoa.CheckNull(textBoxLoai.Text) || ChuanHoa.CheckNull(textBoxGiaP.Text)) 
            {
                if (MessageBox.Show("Bạn có muốn sửa phòng này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PhongDAO.UpdateP(int.Parse(labelId.Text), textBoxTenPhong.Text, richTextBoxThongTin.Text, textBoxTinhTrang.Text, textBoxLoai.Text, int.Parse(textBoxGiaP.Text));
                    textBoxTenPhong.ReadOnly = true;
                    textBoxTinhTrang.ReadOnly = true;
                    textBoxLoai.ReadOnly = true;
                    richTextBoxThongTin.ReadOnly = true;
                    textBoxGiaP.ReadOnly = true;
                    MessageBox.Show("Sửa thành công!");
                    buttonXacNhan.Visible = false;
                    buttonSua.Visible = true;
                    buttonXóa.Visible = true;
                    buttonHuy.Visible = false;
                }
                    
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            textBoxTenPhong.ReadOnly = false;
            textBoxTinhTrang.ReadOnly = false;
            textBoxLoai.ReadOnly = false;
            richTextBoxThongTin.ReadOnly = false;
            textBoxGiaP.ReadOnly = false;
            buttonXacNhan.Visible = true;
            buttonSua.Visible = false;
            buttonXóa.Visible = false;
            buttonHuy.Visible = true;
        }

        private void buttonXóa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa phòng này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                PhongDAO.DeleteP(int.Parse(labelId.Text.ToString()));
                MessageBox.Show("Xóa Thành công !", "Thông báo");
                buttonExit_Click(sender, e);
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyPhong f = new QuanLyPhong();
            f.ShowDialog();
            this.Close();
        }

        private void textBoxGiaP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            loadP();
            textBoxTenPhong.ReadOnly = true;
            textBoxTinhTrang.ReadOnly = true;
            textBoxLoai.ReadOnly = true;
            richTextBoxThongTin.ReadOnly = true;
            textBoxGiaP.ReadOnly = true;
            buttonXacNhan.Visible = false;
            buttonSua.Visible = true;
            buttonXóa.Visible = true;
            buttonHuy.Visible = false;
        }
    }
}
