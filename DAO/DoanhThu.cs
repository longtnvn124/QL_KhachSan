using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKSpj.DAO
{
    public class DoanhThu
    {
        private int id;
        private string tenPhieu;
        private string stime;
        private string etime;
        private string type;
        private int soLuongDon;
        private int tongTien;
        private string nguoiTK;
        
        public DoanhThu(DataRow row)
        {
            this.id = (int)row["MaTK"];
            this.tenPhieu = row["TenPhieu"].ToString();
            this.stime = row["ThoiGianBD"].ToString();
            this.etime = row["ThoiGianKT"].ToString();
            this.type = row["KieuThongKe"].ToString();
            this.SoLuongDon = (int)row["SoLuongDon"];
            this.tongTien = (int)row["TongTien"];
            this.nguoiTK = row["NguoiTK"].ToString();
        }
        public DoanhThu(int id, string tenPhieu, string stime, string etime, string type, int soLuongDon, int tongTien, string nguoiTK)
        {
            this.id = id;
            this.tenPhieu = tenPhieu;
            this.stime = stime;
            this.etime = etime;
            this.type = type;
            this.soLuongDon = soLuongDon;
            this.tongTien = tongTien;
            this.nguoiTK = nguoiTK;
        }

        public int Id { get => id; set => id = value; }
        public string TenPhieu { get => tenPhieu; set => tenPhieu = value; }
        public string Stime { get => stime; set => stime = value; }
        public string Etime { get => etime; set => etime = value; }
        public string Type { get => type; set => type = value; }
        public int SoLuongDon { get => soLuongDon; set => soLuongDon = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public string NguoiTK { get => nguoiTK; set => nguoiTK = value; }
    }
}
