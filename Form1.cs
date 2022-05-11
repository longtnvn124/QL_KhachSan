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
    public partial class Form1 : Form
    {
        int quyen;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login(textBoxTK.Text, textBoxMK.Text))
            {
                quyen = AccountDAO.quyen(textBoxTK.Text, textBoxMK.Text);
                //MessageBox.Show(quyen.ToString(), "Thông báo!");
                this.Hide();
                TrangChu ad = new TrangChu(quyen);
                ad.ShowDialog();
                this.Close();
                

            }
            else
            {
                MessageBox.Show("Thông tin tài khoản mật khẩu không chính xác", "Thông báo!");
            }
        }
        bool login(string tk, string mk)
        {
            return AccountDAO.Login(tk, mk);
            

        }

        private void textBoxMK_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
