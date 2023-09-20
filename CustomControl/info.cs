using CustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class info : UserControl
    {
        listSinhVien _lsv = new listSinhVien();
        public info()
        {
            InitializeComponent();
            _lsv.load();

        }

        private void txtMssv_Leave(object sender, EventArgs e)
        {
            if(_lsv.findByName(txtMssv.Text.ToString())!=null)
            {
                SinhVien a = _lsv.findByName(txtMssv.Text.ToString());
                lbHoten.Text = a.HoTen;
                lbMalop.Text = a.MaLop;
                lbNgaysinh.Text = a.NamSinh;
                lbGT.Text = a.GioiTinh;
                lbCMND.Text = a.CCCD;
            }    
            else
            {
                Console.WriteLine("ko tìm thấy");
            }    
        }

        private void txtMssv_TextChanged(object sender, EventArgs e)
        {

        }

        private void info_Load(object sender, EventArgs e)
        {

        }
    }
}
