namespace FlightRes
{
    public partial class Start : Form
    {
        public Start()
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}