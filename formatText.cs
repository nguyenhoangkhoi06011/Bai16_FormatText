using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai16_FormatText
{
    public partial class FormatText: Form
    {
        public FormatText()
        {
            InitializeComponent();
        }



        private void FormatText_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
            txtNhapten.Focus();
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtNhapten_TextChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Text = txtNhapten.Text;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = Color.Red;
            txtNhapten.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = Color.Green;
            txtNhapten.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = Color.Blue;
            txtNhapten.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = Color.Black;
            txtNhapten.ForeColor = Color.Black;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Font = new Font(lblLaptrinh.Font.Name, lblLaptrinh.Font.Size, lblLaptrinh.Font.Style ^ FontStyle.Bold);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Font = new Font(lblLaptrinh.Font.Name, lblLaptrinh.Font.Size, lblLaptrinh.Font.Style ^ FontStyle.Italic);
        }

        private void chkGachchan_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Font = new Font(lblLaptrinh.Font.Name, lblLaptrinh.Font.Size, lblLaptrinh.Font.Style ^ FontStyle.Underline);
        }
    }
}
