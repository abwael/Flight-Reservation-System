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

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form start = new Start();
            start.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = FlightSystem; Integrated Security = True");
            con.Open();
            try
            {
                if (radioButton1.Checked)
                {
                    SqlCommand myCommand = new SqlCommand("SELECT * FROM ADMIN WHERE A_EMAIL = '" + textBox1.Text + "' AND A_PASSWORD = '" + textBox2.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(myCommand);
                    DataTable dataTable = new DataTable();
                    sda.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        String Email = textBox1.Text;
                        String password = textBox2.Text;
                        Form adminPanel = new AdminPanel();
                        adminPanel.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Data");
                    }
                }
                else
                {
                    SqlCommand myCommand = new SqlCommand("SELECT * FROM PASSENGER WHERE P_EMAIL = '" + textBox1.Text + "' AND P_PASSWORD = '" + textBox2.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(myCommand);
                    DataTable dataTable = new DataTable();
                    sda.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        String Email = textBox1.Text;
                        String password = textBox2.Text;
                        Form passengerPanel = new PassengerPanel();
                        passengerPanel.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Data");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                con.Close();
            } 
        }
    }
}
