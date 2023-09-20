using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLConections;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Fill(this.qLDSV_TCDataSet.GIANGVIEN);

        }

        private void hoverButton1_Click(object sender, EventArgs e)
        {
            SQL a = new SQL(@"DESKTOP-0PQ4U60\SERVER01", "CoffeeManagement");
            if(a.TestConnection())
            {
                MessageBox.Show("Kết nối thàng công", "Thông báo");
            }    
            else
            {
                MessageBox.Show("Kết nối không thàng công", "Thông báo");
            }    
        }

        private void hoverButton1_Click_1(object sender, EventArgs e)
        {

            File.AppendAllText("out.txt", $"{infoSV.txtMssv.Text},{infoSV.lbHoten.Text},{infoSV.lbNgaysinh.Text},{infoSV.lbGT.Text},{infoSV.lbMalop.Text},{infoSV.lbCMND.Text}\n");
        }
    }
}
