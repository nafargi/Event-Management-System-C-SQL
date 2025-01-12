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
using System.Xml.Linq;

namespace Event_Management_System_edp
{
    public partial class ManageEvent : Form
    {
        public ManageEvent()
        {
            InitializeComponent();
            EventDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ShowEvent();
            GetVenue();
            GetCustomer();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void CustNameTb_TextChanged(object sender, EventArgs e)
        {

        }
        int Key = 0;
        private void ShowEvent()
        {
            Con.Open();
            string Query = "Select *from EventTb";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EventDGV.DataSource = ds.Tables[0];
            EventDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Con.Close();
        }

        private void Clear()
        {
            EvNameTb.Text = "";
            CustNameTb.Text = "";
            EvDuration.Text = "";
            StatusCb.SelectedIndex = -1;
            VenueNameTb.Text = "";
        }
        SqlConnection Con = new SqlConnection(@"Data Source=HAMAJIS-PIXEL\SQLEXPRESS;Initial Catalog=EventDb;Integrated Security=True;Trust Server Certificate=True");

        private void GetVenue()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select VId from VenueTb", Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("VId", typeof(int));
            dt.Load(reader);
            EVIdCb.ValueMember = "VId";
            EVIdCb.DataSource = dt;
            Con.Close();
        }

        private void GetVenueName()
        {
            Con.Open();
            string Query = "Select * from VenueTb Where VId=" + EVIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                VenueNameTb.Text = dr["VName"].ToString();
            }

            Con.Close();
        }

        private void GetCustomer()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select CustId from CustomerTb", Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustId", typeof(int));
            dt.Load(reader);
            CustIdCb.ValueMember = "CustId";
            CustIdCb.DataSource = dt;
            Con.Close();
        }

        private void GetCustomerName()
        {
            Con.Open();
            string Query = "Select * from CustomerTb Where CustId=" + CustIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CustNameTb.Text = dr["CustName"].ToString();
            }

            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)

        {
            if (EvNameTb.Text == "" || CustNameTb.Text == "" || EvDuration.Text == "" || VenueNameTb.Text == "" || StatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into EventTb(EvName,EvDate,EvVenue,VenueID,EvDuration,EvCustName,EvCusId,EvStatus)values(@EN,@ED,@EV,@VI,@EDU,@ECN,@ECI,@ES)", Con);
                    cmd.Parameters.AddWithValue("@EN", EvNameTb.Text);
                    cmd.Parameters.AddWithValue("@ED", EvDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EV", VenueNameTb.Text);
                    cmd.Parameters.AddWithValue("@VI", EVIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@EDU", EvDuration.Text);
                    cmd.Parameters.AddWithValue("@ECN", CustNameTb.Text);
                    cmd.Parameters.AddWithValue("@ECI", CustIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@ES", StatusCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event Added Successfully");
                    Con.Close();
                    ShowEvent();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EVIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetVenueName();
        }

        private void CustIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetCustomerName();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (EvNameTb.Text == "" || CustNameTb.Text == "" || EvDuration.Text == "" || VenueNameTb.Text == "" || StatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update EventTb  Set EvName=@EN,EvDate=@ED,EvVenue=@EV,VenueID=@VI,EvDuratione=@EDU,EvCustName=@ECN,EvCusId=@ECI,EvStatus=@ES Where EvId=@EKey", Con);
                    cmd.Parameters.AddWithValue("@EN", EvNameTb.Text);
                    cmd.Parameters.AddWithValue("@ED", EvDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EV", VenueNameTb.Text);
                    cmd.Parameters.AddWithValue("@VI", EVIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@EDU", EvDuration.Text);
                    cmd.Parameters.AddWithValue("@ECN", CustNameTb.Text);
                    cmd.Parameters.AddWithValue("@ECI", CustIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@ES", StatusCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event Updated Successfully");
                    Con.Close();
                    ShowEvent();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EventDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = EventDGV.Rows[e.RowIndex];

                EvNameTb.Text = EventDGV.SelectedRows[0].Cells[0].Value?.ToString();
                EvDateLb.Text = EventDGV.SelectedRows[0].Cells[1].Value?.ToString();
                EVIdCb.SelectedValue = EventDGV.SelectedRows[0].Cells[2].Value?.ToString();
                VenueNameTb.Text = EventDGV.SelectedRows[0].Cells[3].Value?.ToString();
                EvDuration.Text = EventDGV.SelectedRows[0].Cells[4].Value?.ToString();
                CustIdCb.SelectedValue = EventDGV.SelectedRows[0].Cells[5].Value?.ToString();
                CustNameTb.Text = EventDGV.SelectedRows[0].Cells[6].Value?.ToString();
                StatusCb.SelectedItem = EventDGV.SelectedRows[0].Cells[7].Value?.ToString();
                if (EvNameTb.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(EventDGV.SelectedRows[0].Cells[0].Value);
                }
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select The Event");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from  EventTb Where EvId=@EKey ", Con);
                    cmd.Parameters.AddWithValue("@EKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event Deleted");
                    Con.Close();
                    ShowEvent();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
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

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ManageVenue Obj = new ManageVenue();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ManageFeedback Obj = new ManageFeedback();
            Obj.Show();
            this.Hide();
        }
    }
}
