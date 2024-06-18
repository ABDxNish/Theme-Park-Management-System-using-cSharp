using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ViewRideOperator : Form
    {

        private readonly string dbsconnectionx = DBCon.Instance.ConnectionString;

        public ViewRideOperator()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string queryx = "SELECT * FROM  RideOperatorR";
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
            viewRideop.DataSource = dot;
        }

        private void serachb_Click(object sender, EventArgs e)
        {
            string txt = serachBox.Text;
            if (!string.IsNullOrWhiteSpace(txt))
            {
                string q2 = $"SELECT * FROM RideOperatorR WHERE R_UserName LIKE '%{txt}%' ";
                FillDataGridView(q2);
            }
            else
            {
                MessageBox.Show("Not Found! Enter Valid Name", ("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (viewRideop.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = viewRideop.SelectedRows[0];

                string usname = selectedRow.Cells["R_UserName"].Value.ToString();

                using (SqlConnection conn = new SqlConnection(dbsconnectionx))
                {
                    conn.Open();

                    string query = "DELETE FROM RideOperatorR WHERE R_UserName = @UserName";

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

        private void Updateb_Click(object sender, EventArgs e)
        {
            if (viewRideop.SelectedRows.Count > 0)
            {
                if (NameBox.Text == "" || SexBox.Text == "")
                {
                    MessageBox.Show("Please fill all boxes!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataGridViewRow selectedRow = viewRideop.SelectedRows[0];

                string username = selectedRow.Cells["R_UserName"].Value.ToString();

                string nm = NameBox.Text;
                string sex = SexBox.Text;

                if (!string.IsNullOrWhiteSpace(nm) && !string.IsNullOrWhiteSpace(sex))
                {
                    using (SqlConnection conn = new SqlConnection(dbsconnectionx))
                    {
                        conn.Open();

                        string query = "UPDATE RideOperatorR SET R_name = @Name, R_sex = @Sex WHERE R_UserName = @UserName";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", nm);
                            cmd.Parameters.AddWithValue("@Sex", sex);
                            cmd.Parameters.AddWithValue("@UserName", username);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data has been updated successfully.");
                                LoadData();
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
                    MessageBox.Show("Please fill in both name and sex fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            AdminPanel asm = new AdminPanel();
            this.Hide();
            asm.Show();
        }
    }
}
