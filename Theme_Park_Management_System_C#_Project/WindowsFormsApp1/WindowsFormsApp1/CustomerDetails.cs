using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CustomerDetails : Form
    {
        private readonly string dbsconnectionx = DBCon.Instance.ConnectionString;
        public CustomerDetails()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string queryx = "SELECT * FROM  CreateAccount";
            FillDataGridView(queryx);
        }

        private void FillDataGridView(string query1)

        {
            SqlConnection conn = new SqlConnection(dbsconnectionx);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query1, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dot = new DataTable();
            dot.Load(reader);
            dataGridView1.DataSource = dot;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string txt = searchBox.Text;
            if (!string.IsNullOrWhiteSpace(txt))
            {
                string q2 = $"SELECT * FROM CreateAccount WHERE User_Name LIKE '%{txt}%' ";
                FillDataGridView(q2);
            }
            else
            {
                MessageBox.Show("Not Found! Enter Valid Name", ("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (bloodUpdateBox.Text == "" || NatUpdateBox.Text == "" || AgeUpDateBox.Text == "")
                {
                    MessageBox.Show("Please fill all boxes!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string usname = selectedRow.Cells["User_Name"].Value.ToString();

                string bod = bloodUpdateBox.Text;
                string st = NatUpdateBox.Text;
                string age = AgeUpDateBox.Text;

                using (SqlConnection conn = new SqlConnection(dbsconnectionx))
                {
                    conn.Open();

                    string query = "UPDATE CreateAccount SET Blood_Group = @BloodGroup, Nationality = @Nationality, Age = @Age WHERE User_Name = @UserName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BloodGroup", bod);
                        cmd.Parameters.AddWithValue("@Nationality", st);
                        cmd.Parameters.AddWithValue("@Age", age);
                        cmd.Parameters.AddWithValue("@UserName", usname);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            LoadData();
                            bloodUpdateBox.Clear();
                            NatUpdateBox.Clear();
                            AgeUpDateBox.Clear();

                            MessageBox.Show("Data has been updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            admin.Show();
            Hide();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string usname = selectedRow.Cells["User_Name"].Value.ToString();

                using (SqlConnection conn = new SqlConnection(dbsconnectionx))
                {
                    conn.Open();

                    string query = "DELETE FROM CreateAccount WHERE User_Name = @UserName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", usname);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data has been deleted successfully.");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
