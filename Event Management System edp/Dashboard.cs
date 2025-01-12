using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Management_System_edp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            CountEvents();
            CountVenues();
            CountCustomers();
            CountExcellent();
            CountGood();
            CountOkay();
            CountBad();

        }
        SqlConnection Con = new SqlConnection(@"Data Source=HAMAJIS-PIXEL\SQLEXPRESS;Initial Catalog=EventDb;Integrated Security=True;Trust Server Certificate=True");

        private void CountEvents() { 
           Con.Open();
           SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from EventTb",Con);
           DataTable dt = new DataTable();
           sda.Fill(dt);
           EventLb.Text = dt.Rows[0][0].ToString();
           Con.Close();
        
        }
        private void CountVenues()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from VenueTb", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            VenueLb.Text = dt.Rows[0][0].ToString();
            Con.Close();

        }
        private void CountCustomers()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from CustomerTb", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CustLb.Text = dt.Rows[0][0].ToString();
            Con.Close();

        }

        private void CountExcellent()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from FeedbackTb where OverALl = " +4+"", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ExcelLb.Text = dt.Rows[0][0].ToString();
            Con.Close();

        }
        private void CountGood()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from FeedbackTb where OverALl = " + 3+ "", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
             GoodTb.Text = dt.Rows[0][0].ToString();
            Con.Close();

        }
        private void CountOkay()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from FeedbackTb where OverALl = " + 2 + "", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            OkayLb.Text = dt.Rows[0][0].ToString();
            Con.Close();

        }
        private void CountBad()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from FeedbackTb where OverALl = " + 1 + "", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BadTb.Text = dt.Rows[0][0].ToString();
            Con.Close();

        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ManageCustomer Obj = new ManageCustomer();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ManageVenue Obj = new ManageVenue();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ManageFeedback Obj = new ManageFeedback();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ManageEvent Obj = new ManageEvent();
            Obj.Show();
            this.Hide();
        }
    }
}
