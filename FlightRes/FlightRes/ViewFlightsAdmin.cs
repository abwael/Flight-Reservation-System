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

            //Hide the two Options
            dateTimePicker1.Visible = false;
            textBox1.Visible = false;
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.connectionString);
                con.Open();

                if (comboBox1.SelectedIndex == 0)
                {
                    SqlCommand myCommand = new SqlCommand("SELECT * FROM FLIGHT", con);
                    SqlDataAdapter sda = new SqlDataAdapter(myCommand);
                    DataTable dataTable = new DataTable();
                    sda.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    SqlCommand myCommand = new SqlCommand("SELECT * FROM FLIGHT where FLIGHT_NUMBER = '" + textBox1.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(myCommand);
                    DataTable dataTable = new DataTable();
                    sda.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    SqlCommand myCommand = new SqlCommand("SELECT * FROM FLIGHT where AIRCRAFT_ID = '" + textBox1.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(myCommand);
                    DataTable dataTable = new DataTable();
                    sda.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    SqlCommand myCommand = new SqlCommand("SELECT * FROM FLIGHT where FLIGHT_DATE = @flightDate", con);
                    myCommand.Parameters.AddWithValue("@flightDate", dateTimePicker1.Value);
                    SqlDataAdapter sda = new SqlDataAdapter(myCommand);
                    DataTable dataTable = new DataTable();
                    sda.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    SqlCommand myCommand = new SqlCommand("SELECT * FROM FLIGHT where ARRIVAL_TIME = @arrivalTime", con);
                    myCommand.Parameters.AddWithValue("@arrivalTime", dateTimePicker1.Value);
                    SqlDataAdapter sda = new SqlDataAdapter(myCommand);
                    DataTable dataTable = new DataTable();
                    sda.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                else if (comboBox1.SelectedIndex == 5)
                {
                    SqlCommand myCommand = new SqlCommand("SELECT * FROM FLIGHT where LAUNCHING_TIME = @launchingTime", con);
                    myCommand.Parameters.AddWithValue("@launchingTime", dateTimePicker1.Value);
                    SqlDataAdapter sda = new SqlDataAdapter(myCommand);
                    DataTable dataTable = new DataTable();
                    sda.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                else if (comboBox1.SelectedIndex == 6)
                {
                    SqlCommand myCommand = new SqlCommand("SELECT * FROM FLIGHT where SOURCE_PLACE = '" + textBox1.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(myCommand);
                    DataTable dataTable = new DataTable();
                    sda.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                else if (comboBox1.SelectedIndex == 7)
                {
                    SqlCommand myCommand = new SqlCommand("SELECT * FROM FLIGHT where DESTINATION_PLACE = '" + textBox1.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(myCommand);
                    DataTable dataTable = new DataTable();
                    sda.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                else if (comboBox1.SelectedIndex == 8)
                {
                    SqlCommand myCommand = new SqlCommand("SELECT * FROM FLIGHT where SEATS_AVAILABLE = '" + textBox1.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(myCommand);
                    DataTable dataTable = new DataTable();
                    sda.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                dateTimePicker1.Visible = false;
                textBox1.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                dateTimePicker1.Visible = false;
                textBox1.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                dateTimePicker1.Visible = false;
                textBox1.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                dateTimePicker1.Visible = true;
                textBox1.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                dateTimePicker1.Visible = true;
                textBox1.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                dateTimePicker1.Visible = true;
                textBox1.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                dateTimePicker1.Visible = false;
                textBox1.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                dateTimePicker1.Visible = false;
                textBox1.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                dateTimePicker1.Visible = false;
                textBox1.Visible = true;
            }
        }
    }
}
