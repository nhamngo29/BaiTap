using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public class HoverButton:Button
    {
        private Color defaultButtonColor;
        public HoverButton() 
        {
            defaultButtonColor = this.BackColor;
            this.MouseLeave += HoverButton_MouseLeave;
            this.MouseHover += HoverButton_MouseHover;
        }

        private void HoverButton_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void HoverButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = defaultButtonColor;
        }
    }
}
