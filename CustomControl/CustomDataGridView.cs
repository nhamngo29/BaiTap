using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public class CustomDataGridView : DataGridView
    {
        public CustomDataGridView()
        {
            this.CellFormatting += CustomDataGridView_CellFormatting;
        }

        private void CustomDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
                e.CellStyle.BackColor = Color.LightGray;
            else
                e.CellStyle.BackColor = Color.White;
        }
    }
}
