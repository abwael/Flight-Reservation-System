using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FlightRes
{
    public partial class DeleteFlight : Form
    {
        public DeleteFlight()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form view = new ViewFlightsAdmin();
            view.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.connectionString);
                con.Open();
                SqlCommand myCommand = new SqlCommand("delete from FLIGHT where FLIGHT_NUMBER = '" + textBox1.Text + "'", con);
                myCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Flight Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
