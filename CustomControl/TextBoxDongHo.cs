using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public class TextBoxDongHo:TextBox
    {
        public TextBoxDongHo()
        {
            this.KeyPress += TextBoxDongHo_KeyPress;
        }

        private void TextBoxDongHo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Giới hạn độ dài của chuỗi thành 2 ký tự (hh)
            if (Text.Length >= 2 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
