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

namespace FlightRes
{
    public partial class DeleteAircraft : Form
    {
        public DeleteAircraft()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form view = new ViewAircraftAdmin();
            view.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.connectionString);
                con.Open();
                SqlCommand myCommand = new SqlCommand("delete from AIRCRAFT where ID = '" + textBox1.Text + "'", con);
                myCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Aircraft Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteAircraft_Load(object sender, EventArgs e)
        {

        }
    }
}
