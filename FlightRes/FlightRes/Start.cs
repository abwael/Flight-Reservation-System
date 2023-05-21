namespace FlightRes
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form login = new Login();
            login.Show();
            this.Hide();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form signup = new Signup();
            signup.Show();
            this.Hide();
        }
    }
}