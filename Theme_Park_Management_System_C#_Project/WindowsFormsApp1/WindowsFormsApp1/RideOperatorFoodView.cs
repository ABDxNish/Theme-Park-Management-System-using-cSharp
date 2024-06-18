using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RideOperatorFoodView : Form
    {
        private readonly string dbsconnectionx = DBCon.Instance.ConnectionString;

        public RideOperatorFoodView()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string queryx = "SELECT * FROM  FoodTable";
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

        private void RideOperatorRideView_Load(object sender, EventArgs e)
        {
            dlabe.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RideOperatorView adm = new RideOperatorView();
            adm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            RideOperatorView adm = new RideOperatorView();
            adm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dlabe.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = fsearch.Text;
            if (!string.IsNullOrWhiteSpace(txt))
            {
                string q2 = $"SELECT * FROM FoodTable WHERE Fd_name LIKE '%{txt}%' ";
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
                if (!Actv.Checked && !Nat.Checked)
                {
                    MessageBox.Show("Please select a status!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (fpricetext.Text == "")
                {
                    MessageBox.Show("Please fill price!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string foodName = Convert.ToString(selectedRow.Cells["Fd_name"].Value);

                string status = Actv.Checked ? "Available" : "Not Available";
                string price = fpricetext.Text;

                SqlConnection conn = new SqlConnection(dbsconnectionx);
                conn.Open();
                string queryu = "UPDATE FoodTable SET Fd_status = @Status, Fd_Price = @Price WHERE Fd_name = @FoodName";
                SqlCommand cmd = new SqlCommand(queryu, conn);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@FoodName", foodName);
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadData();
                fpricetext.Clear();

                MessageBox.Show("Data has been updated.");
            }
            else
            {
                MessageBox.Show("Please select a food item from the list.");
            }
        }
    }
}
