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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FlightRes
{
    public partial class BookFlight : Form
    {
        public BookFlight()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get available flights that source = From, destination = To, and seats available is >= Amount
            // select * from Flight where ....
            SqlConnection con = new SqlConnection(Program.connectionString);
            con.Open(); //flight_number,Flight_Date,Launching_Time,Arrival_Time
            SqlCommand Data = new SqlCommand("select * from Flight " +
                "where source_place = @FROM" +
                " AND destination_place = @TO" +
                " AND Seats_Available >= @AMOUNT", con);
            Data.Parameters.AddWithValue("@FROM", textBox1.Text);
            Data.Parameters.AddWithValue("@TO", textBox2.Text);
            Data.Parameters.AddWithValue("@AMOUNT", textBox3.Text);
            SqlDataAdapter sda = new SqlDataAdapter(Data);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            String PEmail = "";
            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DialogResult result = MessageBox.Show("Flight number : " + dataTable.Rows[i][0].ToString() + "\n" +
                        "Flight date : " + dataTable.Rows[i][3].ToString() + "\n" +
                        "Launching time : " + dataTable.Rows[i][5].ToString() + "\n" +
                        "Arrival time : " + dataTable.Rows[i][4].ToString() + "\n"
                        , "Flight" + " " + (i + 1), MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {

                        // confirm the book
                        Form ChooseSeat = new ChooseSeat(dataTable.Rows[i][0].ToString(), dataTable.Rows[i][8].ToString());
                        ChooseSeat.Show();
                        this.Hide();
                        break;
                    }

                }
            }
            else
            {
                MessageBox.Show("Sorry ! There are no available flights right now");
            }
            con.Close();
        }

        private void BookFlight_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form passengerPanel = new PassengerPanel();
            passengerPanel.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form passengerPanel = new PassengerPanel();
            passengerPanel.Show();
            this.Hide();
        }
    }
}
