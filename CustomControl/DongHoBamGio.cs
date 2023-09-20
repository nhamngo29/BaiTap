using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class DongHoBamGio : UserControl
    {
        Timer timer; 
        DateTime timeStart;
        static int i = 1;
        public DongHoBamGio()
        {
            InitializeComponent();
            timer = new Timer();


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            timer.Enabled = !timer.Enabled;
            btnStart.Text = timer.Enabled ? "Stop" : "Start";
            timeStart = DateTime.Now;
            timer.Start();
            timer.Tick += Timer_Tick;
            if (btnStart.Text.Equals("Start"))
                timer.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - timeStart;
            lbTime.Text = elapsed.ToString(@"hh\:mm\:ss\:fff");
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            File.AppendAllText("file.txt", $"Lần {i} {lbTime.Text} \n");
            i++;
        }
    }
}
