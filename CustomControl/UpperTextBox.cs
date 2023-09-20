using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public class UpperTextBox:TextBox
    {
        public UpperTextBox() 
        {
            this.KeyPress += UpperTextBox_KeyPress;
        }

        private void UpperTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar>=65&&e.KeyChar<=90)
            {
                e.Handled= true;
            }    
            
        }
    }
}
