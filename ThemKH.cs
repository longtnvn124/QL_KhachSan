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
    public partial class ThemPhong : Form
    {
        public ThemPhong()
        {
            InitializeComponent();
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            them();
        }
        public void them()
        {
            if(ChuanHoa.CheckNull(textBoxTenP.Text) || ChuanHoa.CheckNull(textBoxThongtin.Text) || ChuanHoa.CheckNull(textBoxTinhTrang.Text) || ChuanHoa.CheckNull(textBoxLoai.Text) || ChuanHoa.CheckNull(textBoxGia.Text))
            {
                if (MessageBox.Show("Bạn có muốn thêm không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int gia = int.Parse(textBoxGia.Text.ToString());
                    string query = "INSERT INTO Phong(TenPhong, ThongTin, TinhTrang, LoaiPhong, GiaPhong) VALUES(N'" + textBoxTenP.Text + "', N'" + textBoxThongtin.Text + "', '" + textBoxTinhTrang.Text + "', '" + textBoxLoai.Text + "','" + gia + "')";

                    dataprovider.addconnect(query);
                    MessageBox.Show("Thêm thành công!", "thông báo");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin !", "Thông báo!");
            }
            
        }

        private void ThemPhong_Load(object sender, EventArgs e)
        {

        }

        private void textBoxGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
