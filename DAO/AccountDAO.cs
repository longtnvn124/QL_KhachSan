using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKSpj.DAO
{
    public class AccountDAO
    {
        public static bool Login(string tk, string mk)
        {
            string query = "SELECT * FROM TaiKhoan WHERE TenDangNhap = '" + tk + "' AND MatKhau = '" + mk + "' ";
            DataTable kq = dataprovider.ExQuery(query);
            return kq.Rows.Count > 0;
        }
        public static int quyen(string tk, string mk)
        {
            int q;
            string query = "SELECT * FROM TaiKhoan WHERE TenDangNhap = '" + tk + "' AND MatKhau = '" + mk + "' ";
            DataTable kq = dataprovider.ExQuery(query);
            q = int.Parse(kq.Rows[0][2].ToString());
            return q;
        }
        public static DataTable DanhSach()
        {
            string query = "SELECT * FROM TaiKhoan ";
            DataTable kq = dataprovider.ExQuery(query);
            return kq;
        }
        public static void Them(string tk, string mk, string quyen)
        {
            string query = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau, PhanQuyen) VALUES (N'" + tk + "', N'" + mk + "', '" + quyen + "') ";
            dataprovider.addconnect(query);
        }
    }
}
