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
    public partial class ViewFlightsAdmin : Form
    {
        public ViewFlightsAdmin()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(Program.connectionString);
            con.Open();
            SqlCommand myCommand = new SqlCommand("SELECT * FROM FLIGHT", con);
            SqlDataAdapter sda = new SqlDataAdapter(myCommand);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            comboBox1.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewFlightsAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form add_flight = new AddFlight();
            add_flight.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form admin = new AdminPanel();
            admin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form delete = new DeleteFlight();
            delete.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form edit = new EditFlight();
            edit.Show();
            this.Hide();
        }
    }
}
