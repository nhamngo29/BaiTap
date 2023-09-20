using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CustomControl
{
    public class MailTextBox:TextBox
    {
        ErrorProvider error = new ErrorProvider();
        public MailTextBox() 
        {
            
            this.Leave += MailTextBox_Leave;
        }

        private void MailTextBox_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(this.Text.ToString());
            if (!match.Success)
            {
                error.SetError(this, "Email không hợp lệ");
            }
            else
                error.Clear();
        }
    }
}
