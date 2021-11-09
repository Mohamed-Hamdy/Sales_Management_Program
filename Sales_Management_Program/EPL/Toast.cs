using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Management_Program.EPL
{
    public partial class Toast : Form
    {
        public Toast()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_caption_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void txt_caption_Click_1(object sender, EventArgs e)
        {
           this.Close();
        }   
    }
}
