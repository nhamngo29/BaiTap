using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomControl
{
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public string NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string MaLop { get; set; }
        public string CCCD { get; set; }
        public SinhVien() { }
        public SinhVien(string MSSV, string HoTen, string NamSinh, string GioiTinh, string MaLop, string CCCD) 
        {
            this.MSSV = MSSV;
            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
            this.GioiTinh = GioiTinh;
            this.MaLop = MaLop;
            this.CCCD = CCCD;
        }
    }
}
