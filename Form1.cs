using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenHoangAnh_29_ThiCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string hovaten = "Nguyen Hoang Anh";
            string mssv = "1223360240";
            string monthi = "Lap trinh Window 2 - c#";

            lblInfo.Text = " ho va ten: " + hovaten;
            lblInfo.Text += "\n mssv: " + mssv;
            lblInfo.Text += "\n ngay thi: " + System.DateTime.Now.ToString();
            lblInfo.Text += "\n mon thi: " + monthi;
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Định_dạng dd = new Định_dạng();
            dd.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
