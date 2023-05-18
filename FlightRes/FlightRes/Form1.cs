namespace FlightRes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form admin = new AdminPanel();
            admin.Show();
            this.Hide();
        }

        private void PassengerKey_Click(object sender, EventArgs e)
        {
            Form passenger = new PassengerPanel();
            passenger.Show();
            this.Hide();
        }
    }
}