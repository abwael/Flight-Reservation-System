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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FlightRes
{
    public partial class PassengerPanel : Form
    {
        public PassengerPanel()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = FlightSystem; Integrated Security = True");
            con.Open();
            SqlCommand getEmail = new SqlCommand("select P_EMAIL from passenger where status = 1", con);
            SqlDataReader email = getEmail.ExecuteReader();
            if (email.Read())
            {
                String Email = email.GetValue(0).ToString();
                email.Close();
                SqlCommand updateStatus = new SqlCommand("UPDATE PASSENGER SET STATUS = 0 WHERE P_EMAIL = '" + Email + "'", con);
                updateStatus.ExecuteNonQuery();
            }
            con.Close();
            Form start = new Start();
            start.Show();
            this.Hide();

        }
    }
}
