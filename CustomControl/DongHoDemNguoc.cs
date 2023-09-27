using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class DongHoDemNguoc : UserControl
    {
        private Timer timer;
        public DongHoDemNguoc()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int hours, minutes, seconds;
            if (int.TryParse(tbHour.Text, out hours) && int.TryParse(tbMinute.Text, out minutes) && int.TryParse(tbSecond.Text, out seconds))
            {
                // Đổi thời gian nhập vào thành giây
                int totalTimeInSeconds = hours * 3600 + minutes * 60 + seconds;

                // Đặt thời gian cho Timer
                timer = new Timer();
                timer.Interval = 1000; // 1 giây
                timer.Tag = totalTimeInSeconds;
                timer.Tick += Timer_Tick;
                timer.Start();
            }
            else
            {
                MessageBox.Show("Nhập số nguyên hợp lệ cho giờ, phút và giây.");
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int remainingTime = (int)timer.Tag;
            if (remainingTime > 0)
            {
                remainingTime--;
                timer.Tag = remainingTime;
                TimeSpan timeSpan = TimeSpan.FromSeconds(remainingTime);
                tbHour.Text = timeSpan.Hours.ToString();
                tbMinute.Text = timeSpan.Minutes.ToString();
                tbSecond.Text = timeSpan.Seconds.ToString();
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Đếm ngược đã kết thúc!");
            }
        }

        private void DongHoDemNguoc_Load(object sender, EventArgs e)
        {

        }
    }
}
