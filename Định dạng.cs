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
    public partial class Định_dạng : Form
    {
        public Định_dạng()
        {
            InitializeComponent();
        }

        private void Định_dạng_Load(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Blue;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Bold);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Italic);
        }

        private void chkGachchan_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Underline);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
