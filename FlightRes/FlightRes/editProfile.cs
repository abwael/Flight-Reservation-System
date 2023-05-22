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
    public partial class editProfile : Form
    {
        public editProfile()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(Program.connectionString);
            con.Open();
            SqlCommand getName = new SqlCommand("select * from admin where status = 1", con);
            SqlDataReader data = getName.ExecuteReader();
            while (data.Read())
            {
                String Email = data.GetValue(0).ToString();
                String Fname = data.GetValue(1).ToString();
                String Lname = data.GetValue(2).ToString();
                String phoneNum = data.GetValue(4).ToString();

                textBox1.Text = Fname;
                textBox2.Text = Lname;
                textBox3.Text = phoneNum;
                textBox4.Text = Email;
            }
            data.Close();
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void editProfile_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            con.Open();
            SqlCommand getName = new SqlCommand("select A_EMAIL from admin where status = 1", con);
            SqlDataReader data = getName.ExecuteReader();
            String Email;
            if (data.Read())
            {
                Email = data.GetValue(0).ToString();
                data.Close();

                SqlCommand updateEmail = new SqlCommand("UPDATE ADMIN SET A_EMAIL = '" + textBox4.Text + "' WHERE A_EMAIL = '" + Email + "'", con);
                updateEmail.ExecuteNonQuery();

                SqlCommand updateFname = new SqlCommand("UPDATE ADMIN SET A_FNAME = '" + textBox1.Text + "' WHERE A_EMAIL = '" + Email + "'", con);
                updateFname.ExecuteNonQuery();

                SqlCommand updateLname = new SqlCommand("UPDATE ADMIN SET A_LNAME = '" + textBox2.Text + "' WHERE A_EMAIL = '" + Email + "'", con);
                updateLname.ExecuteNonQuery();

                SqlCommand updatePhoneNum = new SqlCommand("UPDATE ADMIN SET A_PHONE_NUMBER = '" + textBox3.Text + "' WHERE A_EMAIL = '" + Email + "'", con);
                updatePhoneNum.ExecuteNonQuery();

                MessageBox.Show("Data Updated Successfully");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form view = new viewProfile();
            view.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form editpassword = new editpassword();
            editpassword.Show();
            this.Hide();
        }
    }
}
