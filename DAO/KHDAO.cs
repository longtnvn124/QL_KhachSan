using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKSpj.DAO
{
    public class KHDAO
    {
        public static int btWhidth = 280;
        public static int btHeight = 50;
        public static List<KhachHang> KhachHangLoad()
        {
            string query = "SELECT * FROM KhachHang";
            List<KhachHang> KHlist = new List<KhachHang>();

            DataTable data = dataprovider.ExQuery(query);

            foreach (DataRow item in data.Rows)
            {
                KhachHang KH = new KhachHang(item);
                KHlist.Add(KH);
            }


            return KHlist;
        }
        public static List<KhachHang> Load1KH(int id)
        {
            string query = "SELECT * FROM KhachHang WHERE MaKH = '"+id+"'";
            List<KhachHang> KHlist = new List<KhachHang>();

            DataTable data = dataprovider.ExQuery(query);

            foreach (DataRow item in data.Rows)
            {
                KhachHang KH = new KhachHang(item);
                KHlist.Add(KH);
            }


            return KHlist;
        }
        public static List<KhachHang> Loadif1KH(int ten)
        {
            string query = "SELECT * FROM KhachHang WHERE TenKH = '" + ten + "'";
            List<KhachHang> KHlist = new List<KhachHang>();

            DataTable data = dataprovider.ExQuery(query);

            foreach (DataRow item in data.Rows)
            {
                KhachHang KH = new KhachHang(item);
                KHlist.Add(KH);
            }


            return KHlist;
        }
        public static void UpdateKH(int id, string ten, string ngaysinh, string cmnd, string sdt, string email, string gt)
        {

            string query = "UPDATE KhachHang SET TenKH = N'" + ten + "',NgaySinh = N'" + ngaysinh + "', SoCMND = '" + cmnd + "', SoDT = '" + sdt + "', Email = '" + email + "' , GioiTinh = N'" + gt + "' WHERE MaKH = '" + id + "'";
            dataprovider.addconnect(query);
        }
        public static void DeleteKH(int id)
        {
            string query = "DELETE FROM KhachHang WHERE MaKH = '" + id + "'";
            dataprovider.addconnect(query);
        }
        public static String TinhTrangKH(string ten)
        {
            string query = "SELECT DatPhong.TinhTrang FROM DatPhong, KhachHang WHERE KhachHang.MaKH = DatPhong.MaKH and KhachHang.TenKH = '"+ten+"'";
            DataTable data = dataprovider.ExQuery(query);
            string tinhtrang = data.Rows[0][0].ToString();
            return tinhtrang;

        }
    }
}
