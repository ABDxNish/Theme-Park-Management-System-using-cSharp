using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RideOperatorRideView : Form
    {
        private readonly string dbsconnectionx = DBCon.Instance.ConnectionString;

        public RideOperatorRideView()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string queryx = "SELECT * FROM  RideTable";
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            datelab.Text = DateTime.Now.ToLongDateString();
        }

        private void RideOperatorFoodView_Load(object sender, EventArgs e)
        {
            datelab.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RideOperatorView view = new RideOperatorView();
            view.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = fsearch.Text;
            if (!string.IsNullOrWhiteSpace(txt))
            {
                string q2 = $"SELECT * FROM RideTable WHERE Rd_name LIKE '%{txt}%' ";
                FillDataGridView(q2);
            }
            else
            {
                MessageBox.Show("Not Found! Enter Valid Name", ("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (rdsts.Text == "" || fpricetext.Text == "")
                {
                    MessageBox.Show("Please fill status/price!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string rideName = Convert.ToString(selectedRow.Cells["Rd_name"].Value);

                string status = rdsts.Text;
                string price = fpricetext.Text;

                SqlConnection conn = new SqlConnection(dbsconnectionx);
                conn.Open();
                string queryu = "UPDATE RideTable SET Rd_status = @Status, Rd_Price = @Price WHERE Rd_name = @RideName";
                SqlCommand cmd = new SqlCommand(queryu, conn);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@RideName", rideName);
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadData();
                rdsts.Clear();
                fpricetext.Clear();

                MessageBox.Show("Data has been updated.");
            }
            else
            {
                MessageBox.Show("Please select a ride from the list.");
            }
        }
    }
}
