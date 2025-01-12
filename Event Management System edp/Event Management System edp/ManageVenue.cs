using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Event_Management_System_edp
{
    public partial class ManageVenue : Form
    {
        public ManageVenue()
        {
            InitializeComponent();
            VenueDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ShowVenue();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ShowVenue()
        {
            Con.Open();
            string Query = "Select *from VenueTb";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            VenueDGV.DataSource = ds.Tables[0];
            VenueDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Con.Close();
        }

        private void Clear()
        {
            VNameTb.Text = "";
            VManagerTb.Text = "";
            VPhoneTb.Text = "";
            VCapacityTb.Text = "";
            VAddressTb.Text = "";
        }
        SqlConnection Con = new SqlConnection(@"Data Source=HAMAJIS-PIXEL\SQLEXPRESS;Initial Catalog=EventDb;Integrated Security=True;Trust Server Certificate=True");
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (VAddressTb.Text == "" || VNameTb.Text == "" || VPhoneTb.Text == "" || VCapacityTb.Text == "" || VManagerTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into VenueTb(VName,VManager,VCapacity,VAddress,VPhone)values(@VN,@VM,@VC,@VA,@VP)", Con);
                    cmd.Parameters.AddWithValue("@VN", VNameTb.Text);
                    cmd.Parameters.AddWithValue("@VM", VManagerTb.Text);
                    cmd.Parameters.AddWithValue("@VC", VCapacityTb.Text);
                    cmd.Parameters.AddWithValue("@VA", VAddressTb.Text);
                    cmd.Parameters.AddWithValue("@VP", VPhoneTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Saved Successfully");
                    Con.Close();
                    ShowVenue();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int Key = 0;
        private void VenueDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = VenueDGV.Rows[e.RowIndex];

                VNameTb.Text = row.Cells[1].Value?.ToString();
                VManagerTb.Text = row.Cells[2].Value?.ToString();
                VCapacityTb.Text = row.Cells[3].Value?.ToString();
                VAddressTb.Text = row.Cells[4].Value?.ToString();
                VPhoneTb.Text = row.Cells[5].Value?.ToString();

                if (VNameTb.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(row.Cells[0].Value);
                }
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select The Venue");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from  VenueTb Where VId=@VKey ", Con);
                    cmd.Parameters.AddWithValue("@VKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Venue Deleted");
                    Con.Close();
                    ShowVenue();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (VAddressTb.Text == "" || VNameTb.Text == "" || VPhoneTb.Text == "" || VCapacityTb.Text == "" || VManagerTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update VenueTb  Set VName=@VN,VManager=@VM,VCapacity=@VC,VAddress=@VA,VPhone=@VP Where VId=@VKey", Con);
                    cmd.Parameters.AddWithValue("@VN", VNameTb.Text);
                    cmd.Parameters.AddWithValue("@VM", VManagerTb.Text);
                    cmd.Parameters.AddWithValue("@VC", VCapacityTb.Text);
                    cmd.Parameters.AddWithValue("@VA", VAddressTb.Text);
                    cmd.Parameters.AddWithValue("@VP", VPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@VKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Venue Updated");
                    Con.Close();
                    ShowVenue();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
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
            ManageFeedback Obj = new ManageFeedback();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
