using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ViewTicketOne : Form
    {
        private readonly string dbsconnectionx = DBCon.Instance.ConnectionString;

        public ViewTicketOne()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string queryx = "SELECT * FROM  RegTicketTable";
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

        private void button2_Click(object sender, EventArgs e)
        {
            string txt = serachBox.Text;
            if (!string.IsNullOrWhiteSpace(txt))
            {
                string q2 = $"SELECT * FROM RegTicketTable WHERE T_id LIKE '%{txt}%' ";
                FillDataGridView(q2);
            }
            else
            {
                MessageBox.Show("Not Found! Enter Valid Name", ("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (UpdateBox.Text == "")
                {
                    MessageBox.Show("Please fill price!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string ticketId = selectedRow.Cells["T_id"].Value.ToString();

                if (!int.TryParse(ticketId, out int parsedTicketId))
                {
                    MessageBox.Show("Invalid ticket ID. Please select a valid row.");
                    return;
                }

                string price = UpdateBox.Text;

                string query = "UPDATE RegTicketTable SET T_price = @Price WHERE T_id = @TicketId";

                using (SqlConnection conn = new SqlConnection(dbsconnectionx))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@TicketId", parsedTicketId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data has been updated.");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("No rows were updated. Please check the ticket ID.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TicketSellerView ticketSellerView = new TicketSellerView();
            ticketSellerView.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
