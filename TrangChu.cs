using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLKSpj.DAO;

namespace QLKSpj
{
    public partial class TrangChu : Form
    {
        int quyen;
        int idP;
        int idKH = 0;
        public TrangChu()
        {
            InitializeComponent();
        }
        public TrangChu(int quyen2)
        {
            InitializeComponent();
            this.quyen = quyen2;
        }


        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }

        public void loadlishPhong()
        {
            List<Phong> phonglist = PhongDAO.LoadPhong();
            foreach(Phong item in phonglist)
            {
                Button btn = new Button() { Width = PhongDAO.btWhidth, Height = PhongDAO.btHeight };
                btn.Text = item.Ten + Environment.NewLine +"Loại: "+ item.Loai + Environment.NewLine +"Tình Trạng: "+ item.TinhTrang;
                btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //btn.Name = item.Id.ToString();
                btn.Click += Btn_Click;
                btn.Tag = item;
                
                if (item.TinhTrang == "Đã thuê" || item.TinhTrang == "đã thuê")
                {
                    btn.BackColor = Color.LightPink;
                }

                else
                {
                    if (item.TinhTrang == "Đã đặt" || item.TinhTrang == "đã đặt")
                    {
                        btn.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        if (item.TinhTrang == "Trống" || item.TinhTrang == "trống")
                        {
                            btn.BackColor = Color.LightBlue;
                        }
                    }
                }
                flowLayoutPanelPhong.Controls.Add(btn);
                
                
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            
            //getName()
            buttonThuePhong.Enabled = true;
            buttonTraPhong.Enabled = true;
            buttonDatPhong.Enabled = true;
            int PhongId = ((sender as Button).Tag as Phong).Id;
            idP = PhongId;


        }

        public void loadlistKH()
        {
            List<KhachHang> khachHangs = KHDAO.KhachHangLoad();
            foreach (KhachHang item in khachHangs)
            {
                Button btn = new Button() { Width = KHDAO.btWhidth, Height = KHDAO.btHeight };
                btn.Text = item.TenKH;
                btn.Click += Btn_Click1;
                btn.Tag = item;
                btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                flowLayoutPanelKH.Controls.Add(btn);
            }
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            idKH = ((sender as Button).Tag as KhachHang).Id;
            //MessageBox.Show(idKH.ToString());
            this.Hide();
            TTKH ad = new TTKH(idKH);
            ad.ShowDialog();
            this.Close();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            loadlishPhong();
            loadlistKH();
        }

        private void listViewKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyKH f = new QuanLyKH();
            f.ShowDialog();
            //this.Close();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyKH f = new QuanLyKH();
            f.ShowDialog();
            //this.Close();
        }

        private void buttonThuePhong_Click(object sender, EventArgs e)
        {
            //
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyPhong f = new QuanLyPhong();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            ChiTietPhong ad = new ChiTietPhong(idP);
            ad.ShowDialog();
            this.Close();
            //MessageBox.Show(idP.ToString());
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(quyen == 1)
            {
                MessageBox.Show("Không thể truy cập, bạn không phải admin!", "Thông báo!");
            }
            else
            {
                this.Hide();
                QuanLyTk f = new QuanLyTk();
                f.ShowDialog();
            }
        }

        private void quảnLýĐặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyDatPhong f = new QuanLyDatPhong();
            f.ShowDialog();
        }
        public string getName(string str)
        {
            int vtri = 0;
            int end = 0;
            string kq = "";
            vtri = str.IndexOf(':') + 2;
            end = str.IndexOf('\n');
            kq = str.Substring(vtri, end - vtri);
            return kq;
        }
    }
    
    
}
