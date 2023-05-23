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
    public partial class EditSeat : Form
    {
        public EditSeat()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(Program.connectionString);
            con.Open();
            // get email
            String PEmail = "";
            SqlCommand getEmail = new SqlCommand("select P_EMAIL from passenger where status = 1", con);
            SqlDataReader email = getEmail.ExecuteReader();
            if (email.Read())
            {
                String Email = email.GetValue(0).ToString();
                email.Close();
                PEmail = Email;
            }
            SqlCommand myCommand = new SqlCommand("select Flight.Flight_Number, Flight.Flight_Date, FLIGHT.Source_PLACE, FLIGHT.DESTINATION_PLACE, Flight.Arrival_Time, FLIGHT.Launching_Time, BOOKING.SEA_SEAT_NUMBER as Seat_Number, SEAT.CLASS from Booking INNER JOIN Flight ON BOOKING.FLI_FLIGHT_NUMBER = FLIGHT.FLIGHT_NUMBER INNER JOIN SEAT ON FLIGHT.FLIGHT_NUMBER = SEAT.FLIGHT_NUMBER WHERE BOOKING.PAS_P_EMAIL = @Email AND BOOKING.SEA_SEAT_NUMBER = SEAT.SEAT_NUMBER", con);
            myCommand.Parameters.AddWithValue("@Email", PEmail);
            myCommand.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(myCommand);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void EditSeat_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form view = new ViewBookedFlights();
            view.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form view = new ViewBookedFlights();
            view.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            con.Open();
            // get email
            String PEmail = "";
            SqlCommand getEmail = new SqlCommand("select P_EMAIL from passenger where status = 1", con);
            SqlDataReader email = getEmail.ExecuteReader();
            if (email.Read())
            {
                String Email = email.GetValue(0).ToString();
                email.Close();
                PEmail = Email;
            }

            //Edting Booking
            SqlCommand myCommand = new SqlCommand("update booking set SEA_SEAT_NUMBER = @NewSeat where PAS_P_EMAIL = @Email and FLI_FLIGHT_NUMBER = @FlightNumber and SEA_SEAT_NUMBER = @CurrentSeat", con);
            myCommand.Parameters.AddWithValue("@NewSeat", textBox4.Text);
            myCommand.Parameters.AddWithValue("@Email", PEmail);
            myCommand.Parameters.AddWithValue("@FlightNumber", textBox2.Text);
            myCommand.Parameters.AddWithValue("@CurrentSeat", textBox3.Text);
            myCommand.ExecuteNonQuery();

            //Editing Old Seat
            SqlCommand EditOldSeat = new SqlCommand("update SEAT set STATUS = 'available' where FLIGHT_NUMBER = @FlightNumber AND SEAT_NUMBER = @CurrentSeat", con);
            EditOldSeat.Parameters.AddWithValue("@FlightNumber", textBox2.Text);
            EditOldSeat.Parameters.AddWithValue("@CurrentSeat", textBox3.Text);
            EditOldSeat.ExecuteNonQuery();

            //Editing New Seat
            SqlCommand EditNewSeat = new SqlCommand("update SEAT set STATUS = 'unavailable' where FLIGHT_NUMBER = @FlightNumber AND SEAT_NUMBER = @NewSeat", con);
            EditNewSeat.Parameters.AddWithValue("@FlightNumber", textBox2.Text);
            EditNewSeat.Parameters.AddWithValue("@NewSeat", textBox4.Text);
            EditNewSeat.ExecuteNonQuery();

            MessageBox.Show("Seat Updated!");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.connectionString);
                con.Open();
                // get email
                String PEmail = "";
                SqlCommand getEmail = new SqlCommand("select P_EMAIL from passenger where status = 1", con);
                SqlDataReader email = getEmail.ExecuteReader();
                if (email.Read())
                {
                    String Email = email.GetValue(0).ToString();
                    email.Close();
                    PEmail = Email;
                }
                SqlCommand myCommand = new SqlCommand("select FLIGHT.FLIGHT_NUMBER, SEAT.SEAT_NUMBER as Seat_Number, SEAT.CLASS,SEAT.STATUS,SEAT.PRICE from Booking INNER JOIN Flight ON BOOKING.FLI_FLIGHT_NUMBER = FLIGHT.FLIGHT_NUMBER INNER JOIN SEAT ON FLIGHT.FLIGHT_NUMBER = SEAT.FLIGHT_NUMBER WHERE BOOKING.PAS_P_EMAIL = @Email AND FLIGHT.FLIGHT_NUMBER = '" + textBox2.Text + "' AND SEAT.STATUS = 'available'", con);
                myCommand.Parameters.AddWithValue("@Email", PEmail);
                myCommand.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(myCommand);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
