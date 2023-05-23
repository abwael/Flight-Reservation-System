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
    public partial class ViewAircraftAdmin : Form
    {
        public ViewAircraftAdmin()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(Program.connectionString);
            con.Open();
            SqlCommand myCommand = new SqlCommand("SELECT * FROM AIRCRAFT", con);
            SqlDataAdapter sda = new SqlDataAdapter(myCommand);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            comboBox1.SelectedIndex = 0;

            //Hide textbox
            textBox1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form admin = new AdminPanel();
            admin.Show();
            this.Hide();
        }

        private void ViewAircraftAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form aircraft = new AddAircraft();
            aircraft.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form delete = new DeleteAircraft();
            delete.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.connectionString);
                con.Open();

                if (comboBox1.SelectedIndex == 0)
                {
                    SqlCommand myCommand = new SqlCommand("SELECT * FROM AIRCRAFT", con);
                    SqlDataAdapter sda = new SqlDataAdapter(myCommand);
                    DataTable dataTable = new DataTable();
                    sda.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    SqlCommand myCommand = new SqlCommand("SELECT * FROM AIRCRAFT where ID = '" + textBox1.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(myCommand);
                    DataTable dataTable = new DataTable();
                    sda.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    SqlCommand myCommand = new SqlCommand("SELECT * FROM AIRCRAFT where TOTAL_SEATS = '" + textBox1.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(myCommand);
                    DataTable dataTable = new DataTable();
                    sda.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                textBox1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form edit = new EditAircraft();
            edit.Show();
            this.Hide();
        }
    }
}
