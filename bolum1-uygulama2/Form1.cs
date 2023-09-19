using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bolum1_uygulama2
{
    public partial class grpArkaplanrengi : Form
    {
        public grpArkaplanrengi()
        {
            InitializeComponent();
        }

        private void btnrenk_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }
    }
}
