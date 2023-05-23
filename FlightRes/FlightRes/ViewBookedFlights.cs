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
    public partial class ViewBookedFlights : Form
    {
        public ViewBookedFlights()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form passengerPanel = new PassengerPanel();
            passengerPanel.Show();
            this.Hide();
        }
    }
}
