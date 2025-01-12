namespace Event_Management_System_edp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Uname.Text = "";
            password.Text = "";
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (Uname.Text == "" || password.Text == "") {
                MessageBox.Show("Enter Both Username and Password");

            } else if (Uname.Text == "admin" || password.Text == "admin") {

                ManageEvent Obj = new ManageEvent();
                Obj.Show();
                this.Hide();
            } else {
                MessageBox.Show("Wrong Username or Password");
            }
        }
    }
}
