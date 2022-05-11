using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKSpj.DAO
{
    public class Phong
    {
        private int id;
        private string ten;
        private string tinhTrang;
        private string loai;
        private string thongTin;
        private int tien;

        public Phong(int id, string ten, string tinhTrang, string loai, string thongTin, int tien)
        {
            this.id = id;
            this.ten = ten;
            this.tinhTrang = tinhTrang;
            this.loai = loai;
            this.ThongTin = thongTin;
            this.Tien = tien;
            
        }

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string Loai { get => loai; set => loai = value; }
        public string ThongTin { get => thongTin; set => thongTin = value; }
        public int Tien { get => tien; set => tien = value; }

        public Phong(DataRow row)
        {
            this.id = (int)row["MaPhong"];
            this.ten = row["TenPhong"].ToString();
            this.loai = row["LoaiPhong"].ToString();
            this.tinhTrang = row["TinhTrang"].ToString();
            this.thongTin = row["ThongTin"].ToString();
            this.tien = (int)row["GiaPhong"];
        }
    }
    
}
