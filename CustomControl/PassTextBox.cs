using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public class PassTextBox:TextBox
    {
        ErrorProvider error = new ErrorProvider();
        public PassTextBox()
        {
            this.Leave += PassTextBox_Leave;
        }

        private void PassTextBox_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[^a-zA-Z0-9\s]");
            if (regex.IsMatch(this.Text.ToString()) && this.Text.ToString().Length >= 6)
            {
                error.Clear();
            }
            else
                error.SetError(this, "Chuỗi bắt buộc chứa kỳ tự đặt biệt và độ dài phải trên 6");
            
        }
    }
}
