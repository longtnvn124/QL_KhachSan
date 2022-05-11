using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKSpj.DAO
{
    public class HopDongDAO
    {
        public static DataTable DanhSach()
        {
            string query = "SELECT MaDP, TenKH, TenPhong, ThoiGianDat,ThoiGianTra, TienPhong, DatPhong.TinhTrang FROM DatPhong, KhachHang, Phong WHERE DatPhong.MaKH = KhachHang.MaKH and DatPhong.MaPhong = Phong.MaPhong";
            DataTable table = dataprovider.ExQuery(query);
            return table;
        }
        public static void Them(string TenKH,  string NS, string SoDT, string CMND, string Email, string phong)
        {
            string query = "INSERT INTO KhachHang (TenKH, NgaySinh, SoCMND, SoDT, Email) VALUES (N'" + TenKH + "', '" + NS + "',N'" + CMND + "', N'" + SoDT + "', '" + Email + "') ";
            dataprovider.addconnect(query);
        }
        public static void Them2(string MaKH, string MaPhong)
        {
            string query = "INSERT INTO DatPhong (MaKH, MaPhong, TienPhong, TinhTrang) VALUES (N'" + MaKH + "', N'" + MaPhong + "', '" + 0 + "',N'" + "đã đặt" + "') ";
            dataprovider.addconnect(query);
        }
    }
}
