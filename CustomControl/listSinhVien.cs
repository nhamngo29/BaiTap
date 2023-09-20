using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomControl
{
    public class listSinhVien
    {

        public static List<SinhVien> LSinhVien { get; set; }
        public void load()
        {
            LSinhVien = new List<SinhVien>();
            using (StreamReader reader = new StreamReader(@"D:\\Learn\\PhanTrienPhanMemUngDungThongMinh\\BaiTap\\BaiTap\\CustomControl\\DSSV.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 6)
                    {
                        SinhVien sv = new SinhVien
                        {
                            MSSV = parts[0],
                            HoTen = parts[1],
                            NamSinh = parts[2],
                            GioiTinh = parts[3],
                            MaLop = parts[4],
                            CCCD = parts[5]
                        };
                        LSinhVien.Add(sv);
                    }
                }
            }
        }
        public SinhVien findByName(string name)
        {
            return LSinhVien.SingleOrDefault(t => t.MSSV.Replace(" ", "") == name);
        }
    }
}
