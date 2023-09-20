using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public class UserTextBox:TextBox
    {
        ErrorProvider error = new ErrorProvider();
        public UserTextBox()
        {
            this.Leave += UserTextBox_Leave;
        }

        private void UserTextBox_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[^a-zA-Z0-9\s]");
            if (regex.IsMatch(this.Text.ToString()))
            {
                error.SetError(this, "Chuỗi chứa kỳ tự đặt biệt");
            }
            else
                error.Clear(); 
        }
    }
}
