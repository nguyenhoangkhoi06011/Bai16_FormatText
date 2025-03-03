using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai16_FormatText
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formatTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formatText formatText = new formatText();
            formatText.MdiParent = this;
            formatText.Show();
        }

        private void tiệnÍchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            string ten = "Nguyễn Hoàng Khôi";
            lblinfor.Text = "Họ và tên thí sinh:" + ten + Environment.NewLine;
            lblinfor.Text += "Ngày Viết Chương Trình:" + System.DateTime.Now;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
