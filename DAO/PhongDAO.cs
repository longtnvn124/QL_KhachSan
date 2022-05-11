using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKSpj.DAO
{
    public class PhongDAO
    {
        public static int btWhidth = 120;
        public static int btHeight = 120;
        public static List<Phong> LoadPhong()
        {
            string query = "SELECT * FROM Phong";
            List<Phong> Plist = new List<Phong>();

            DataTable data = dataprovider.ExQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Phong phong = new Phong(item);
                Plist.Add(phong);
            }

            return Plist;
        }
        public static DataTable DanhSach()
        {
            string query = "SELECT MaPhong,TenPhong, LoaiPhong, TinhTrang FROM Phong ";
            DataTable kq = dataprovider.ExQuery(query);
            return kq;
        }
        public static List<Phong> Load1p(int MaPhong)
        {
            string query = "SELECT * FROM Phong WHERE MaPhong = '"+MaPhong+"'";
            List<Phong> Plist = new List<Phong>();

            DataTable data = dataprovider.ExQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Phong phong = new Phong(item);
                Plist.Add(phong);
            }

            return Plist;
        }
        public static void UpdateP(int id, string tenp, string thongtin, string tinhtrang, string loaip, int tien)
        {
            
            string query = "UPDATE Phong SET TenPhong = N'" + tenp + "',ThongTin = N'" + thongtin + "', TinhTrang = N'" + tinhtrang + "', LoaiPhong = N'" + loaip + "', GiaPhong = '" + tien + "'WHERE MaPhong = '" + id + "'";
            dataprovider.addconnect(query);
        }
        public static void DeleteP(int id)
        {
            string query = "DELETE FROM Phong WHERE MaPhong = '"+id+"'";
            dataprovider.addconnect(query);
        }
    }
}
