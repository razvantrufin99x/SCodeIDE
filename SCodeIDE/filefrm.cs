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
    public partial class filefrm : Form
    {

        public filefrm()
        {
            InitializeComponent();
        }

        public void setFont(Font font0)
        {
            this.textBox1.Font = font0;
        }

        public void setBackcolor(Color c)
        {
            this.textBox1.BackColor = c;
        }

        public void setForecolor(Color c)
        {
            this.textBox1.ForeColor = c;
        }

        private void filefrm_Load(object sender, EventArgs e)
        {

        }

        private void filefrm_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
