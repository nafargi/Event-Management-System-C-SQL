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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Event_Management_System_edp
{
    public partial class ManageFeedback : Form
    {
        public ManageFeedback()
        {
            InitializeComponent();
            FeedbackDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ShowFeedback();
            GetEvent();
            PopulateCombox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShowFeedback()
        {
            Con.Open();
            string Query = "Select *from FeedbackTb";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FeedbackDGV.DataSource = ds.Tables[0];
            FeedbackDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Con.Close();
        }

        private void Clear()
        {
            EvNameTb.Text = "";
            VenueCb.SelectedIndex = -1;
            HospitalityCb.SelectedIndex = -1;
            PunctualityCb.SelectedIndex = -1;
        }
        SqlConnection Con = new SqlConnection(@"Data Source=HAMAJIS-PIXEL\SQLEXPRESS;Initial Catalog=EventDb;Integrated Security=True;Trust Server Certificate=True");

        private void GetEvent()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select EvId from EventTb", Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("EvId", typeof(int));
            dt.Load(reader);
            EvIdCb.ValueMember = "EvId";
            EvIdCb.DataSource = dt;
            Con.Close();
        }

        private void GetEventName()
        {
            Con.Open();
            string Query = "Select * from EventTb Where EvId=" + EvIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EvNameTb.Text = dr["EvName"].ToString();
            }

            Con.Close();
        }

        private void PopulateCombox()
        {
            VenueCb.Items.AddRange(new object[] {
             "Excellent","Good","Bad"
            });
            PunctualityCb.Items.AddRange(new object[] {
             "Excellent","Good","Bad"
            });
            HospitalityCb.Items.AddRange(new object[] {
             "Excellent","Good","Bad"
            });
        }
        private void EvIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetEventName();
        }

        private void SaveBtn_Click(object sender, EventArgs e)

        {
            if (EvNameTb.Text == "" || VenueCb.SelectedIndex == -1 || HospitalityCb.SelectedIndex == -1 || PunctualityCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    int OverAll = (HospitalityCb.SelectedIndex + PunctualityCb.SelectedIndex + VenueCb.SelectedIndex + 3) / 3;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into FeedbackTb(EvId,EVName,Venue,Ponctuality,Hospitality,OverAll)values(@EI,@EN,@V,@P,@H,@O)", Con);
                    cmd.Parameters.AddWithValue("@EI", EvIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@EN", EvNameTb.Text);
                    cmd.Parameters.AddWithValue("@V", VenueCb.SelectedIndex + 1);
                    cmd.Parameters.AddWithValue("@P", PunctualityCb.SelectedIndex + 1);
                    cmd.Parameters.AddWithValue("@H", HospitalityCb.SelectedIndex + 1);
                    cmd.Parameters.AddWithValue("@O", OverAll);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Feedback Submitted Successfully");
                    Con.Close();
                    ShowFeedback();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ManageCustomer Obj = new ManageCustomer();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ManageEvent Obj = new ManageEvent();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ManageVenue Obj = new ManageVenue();
            Obj.Show();
            this.Hide();
        }
    }
}
