using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ViewTicketSeller : Form
    {
        private readonly string dbsconnectionx = DBCon.Instance.ConnectionString;
        public ViewTicketSeller()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string queryx = "SELECT * FROM  TicketSellerT";
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
            TSellerDataView.DataSource = dot;
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            string txt = TserchBox.Text;
            if (!string.IsNullOrWhiteSpace(txt))
            {
                string q2 = $"SELECT * FROM TicketSellerT WHERE T_UserName LIKE '%{txt}%' ";
                FillDataGridView(q2);
            }
            else
            {
                MessageBox.Show("Not Found! Enter Valid Name", ("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            if (TSellerDataView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = TSellerDataView.SelectedRows[0];

                string usname = selectedRow.Cells["T_UserName"].Value.ToString();

                using (SqlConnection conn = new SqlConnection(dbsconnectionx))
                {
                    conn.Open();

                    string query = "DELETE FROM TicketSellerT WHERE T_UserName = @UserName";

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

        private void RefreshB_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void UpdateB_Click(object sender, EventArgs e)
        {
            if (TSellerDataView.SelectedRows.Count > 0)
            {
                if (NameBox.Text == "" || SexBox.Text == "")
                {
                    MessageBox.Show("Please fill all boxes!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataGridViewRow selectedRow = TSellerDataView.SelectedRows[0];

                string username = selectedRow.Cells["T_UserName"].Value.ToString();

                string nm = NameBox.Text;
                string sex = SexBox.Text;

                using (SqlConnection conn = new SqlConnection(dbsconnectionx))
                {
                    conn.Open();

                    string query = "UPDATE TicketSellerT SET T_name = @Name, T_sex = @Sex WHERE T_UserName = @UserName";

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
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            this.Hide();
            adminPanel.Show();
        }
    }
}
