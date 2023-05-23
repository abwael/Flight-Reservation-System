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
    public partial class ChooseSeat : Form
    {
        String Global_Flight_Number;
        String SeatsAvailable;
        public ChooseSeat(String Flight_Number, String MaxSeatsAvailable)
        {
            InitializeComponent();
            this.Global_Flight_Number = Flight_Number;
            this.SeatsAvailable = MaxSeatsAvailable;
            SqlConnection con = new SqlConnection(Program.connectionString);
            con.Open();
            SqlCommand myCommand = new SqlCommand("SELECT * FROM SEAT WHERE FLIGHT_NUMBER = '" + Flight_Number + "' AND STATUS = 'AVAILABLE'", con);
            SqlDataAdapter sda = new SqlDataAdapter(myCommand);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            con.Open();
            String PEmail = "";
            DialogResult confirm = MessageBox.Show("Are you sure you want to book this flight ? ", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                //GET ACTIVE EMAIL
                SqlCommand getEmail = new SqlCommand("select P_EMAIL from passenger where status = 1", con);
                SqlDataReader email = getEmail.ExecuteReader();
                if (email.Read())
                {
                    String Email = email.GetValue(0).ToString();
                    email.Close();
                    PEmail = Email;
                }
                try
                {
                    //add the book information to the database
                    SqlCommand myCommand = new SqlCommand("insert into BOOKING (FLI_FLIGHT_NUMBER,PAS_P_EMAIL,SEA_SEAT_NUMBER) " +
                                                          "values (@NUMBER, @PEMAIL, @SEATNUM)", con);
                    myCommand.Parameters.AddWithValue("@NUMBER", Global_Flight_Number);
                    myCommand.Parameters.AddWithValue("@PEMAIL", PEmail);
                    myCommand.Parameters.AddWithValue("@SEATNUM", textBox1.Text);
                    myCommand.ExecuteNonQuery();

                    //decrease the seats available by the amount number entered
                    SqlCommand updateAvailableSeats = new SqlCommand("UPDATE Flight SET SEATS_AVAILABLE = '" + (Convert.ToInt32(SeatsAvailable) - 1) + "' where FLIGHT_NUMBER = '" + Global_Flight_Number + "'", con);
                    updateAvailableSeats.ExecuteNonQuery();

                    SqlCommand updateSeatStatus = new SqlCommand("UPDATE SEAT SET STATUS = @status where FLIGHT_NUMBER = @FlightNumber AND SEAT_NUMBER = @SeatNumber", con);

                    updateSeatStatus.Parameters.AddWithValue("@status", "unavailable");
                    updateSeatStatus.Parameters.AddWithValue("@FlightNumber", Global_Flight_Number);
                    updateSeatStatus.Parameters.AddWithValue("@SeatNumber", textBox1.Text);
                    updateSeatStatus.ExecuteNonQuery();

                    Form BookedFlightsPage = new ViewBookedFlights();
                    BookedFlightsPage.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    con.Close();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ViewAvailableFlights = new ViewFlightsPassenger();
            ViewAvailableFlights.Show();
            this.Hide();
        }
    }
}
