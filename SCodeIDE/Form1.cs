using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SCodeIDE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<filefrm> subformeditor = new List<filefrm>();
        public filefrm f1;
       

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1 = new filefrm();
            subformeditor.Add(f1);
            f1.MdiParent = this;
            f1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            try
            {
                f1.setBackcolor(colorDialog1.Color);
            }
            catch { }
        }

        private void foregroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            try
            {
                f1.setForecolor(colorDialog1.Color);
            }
            catch { }
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            try
            {
                f1.setFont(fontDialog1.Font);
            }
            catch { }
        }

        
    }
}
