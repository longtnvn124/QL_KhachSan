using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKSpj.DAO
{
    public class KhachHang
    {
        private int id;
        private string tenKH;
        private string gioiTinh;
        private string ngaySinh;
        private string cMND;
        private string soDT;
        private string email;


        public KhachHang(int id, string tenKH,  string gioiTinh, string ngaySinh, string cMND, string soDT, string email)
        {
            this.id = id;
            this.TenKH = tenKH;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.CMND = cMND;
            this.SoDT = soDT;
            this.Email = email;
        }

        public int Id { get => id; set => id = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string Email { get => email; set => email = value; }

        public KhachHang(DataRow row)
        {
            this.id = (int)row["MaKH"];
            this.tenKH = row["TenKH"].ToString();
            this.gioiTinh = row["GioiTinh"].ToString();
            this.ngaySinh = row["NgaySinh"].ToString();
            this.cMND = row["SoCMND"].ToString();
            this.soDT = row["SoDT"].ToString();
            this.email = row["Email"].ToString();
        }
    }
}
