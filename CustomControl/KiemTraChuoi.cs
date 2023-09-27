using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public class KiemTraChuoi:TextBox
    {
        public bool ChuoiChua { get; set; } = false;
        public KiemTraChuoi() {
            this.Leave += KiemTraChuoi_Leave;
        }

        private void KiemTraChuoi_Leave(object sender, EventArgs e)
        {
            if(Text.Any(char.IsUpper)&& Text.Any(char.IsNumber)&&Text.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)))
            {
                Console.WriteLine("có chưa chữ và số và kí tự đặc biệt");
                ChuoiChua=true;
            }    
            else
            {
                Console.WriteLine("Ko có chưa chữ và số 123");
                ChuoiChua=false;
            }    
        }
    }
}
