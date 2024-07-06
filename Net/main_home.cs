using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Net
{
    public partial class main_home : Form
    {
        public main_home()
        {
            InitializeComponent();
        }

        private void main_home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            home1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            about1.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            booking1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            room1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void home1_Load(object sender, EventArgs e)
        {

        }
    }
}
