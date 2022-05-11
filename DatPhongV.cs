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
    public partial class DatPhongV : Form
    {
        public DatPhongV()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if(Check(comboBoxTen.Text) || Check(textBoxSDT.Text) || Check(textBoxCMND.Text))
            {
                MessageBox.Show("Thiếu thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //HopDongDAO.Them(textBoxTenKH.Text, )
            }
            MessageBox.Show("Thêm Thành công!");
        }
        public void loadPhong()
        {
            dataGridView1.DataSource =  PhongDAO.DanhSach();
        }

        private void DatPhongV_Load(object sender, EventArgs e)
        {
            loadPhong();
            loadCBX();
        }
        private bool Check(string a)
        {
            if (string.IsNullOrWhiteSpace(a) == true) //Nếu txtHoTen rỗng hoặc chỉ có dấu cách
            {
                //MessageBox.Show("Thiếu thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            KHDAO.TinhTrangKH(comboBoxTen.Text);
        }
        public void loadCBX()
        {
            List<KhachHang> khachHangs = KHDAO.KhachHangLoad();
            int i = 0;
            foreach (KhachHang item in khachHangs)
            {
                comboBoxTen.Items.Insert(i,item.TenKH);
                i++;
            }
        }
    }
}
