using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai16_FormatText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formatTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatText formatText = new FormatText();
            formatText.MdiParent = this;
            formatText.Show();

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainChinh_Load(object sender, EventArgs e)
        {
            string ten = "Nguyễn Hoàng Khôi";
            lblinfo.Text = "Họ và tên thí sinh: " + ten + Environment.NewLine;
            lblinfo.Text += "Ngày tháng viết chương trình: " + System.DateTime.Now;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}