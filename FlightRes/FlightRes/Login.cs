using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightRes
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Welcome_text_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_text_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form start = new Start();
            start.Show();
            this.Close();
        }
    }
}
