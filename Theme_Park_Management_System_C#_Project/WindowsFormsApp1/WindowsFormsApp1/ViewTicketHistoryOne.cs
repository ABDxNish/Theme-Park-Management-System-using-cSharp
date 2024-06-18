using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ViewTicketHistoryOne : Form
    {
        private readonly string dbsconnectionx = DBCon.Instance.ConnectionString;
        private SqlConnection conn;

        public ViewTicketHistoryOne()
        {
            InitializeComponent();
            LoadData();
            conn = new SqlConnection(dbsconnectionx);

        }

        private void TicketSold()
        {
            try
            {
                string dbsconnectionx = DBCon.Instance.ConnectionString;

                using (SqlConnection con = new SqlConnection(dbsconnectionx))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM CustomerRegBuysT", con);

                    int rowCount = (int)command.ExecuteScalar();


                    ticketshow.Text = rowCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TotalProfit()
        {
            try
            {
                string dbsconnectionx = DBCon.Instance.ConnectionString;

                using (SqlConnection con = new SqlConnection(dbsconnectionx))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT SUM(C_Price) FROM CustomerRegBuysT", con);

                    object result = command.ExecuteScalar();

                    decimal totalProfit = (result != DBNull.Value) ? Convert.ToDecimal(result) : 0;

                    profit.Text = totalProfit.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadData()
        {
            string queryx = "SELECT * FROM  CustomerRegBuysT";
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

        private void ViewTicketHistoryOne_Load(object sender, EventArgs e)
        {
            TotalProfit();
            TicketSold();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string x = "Family Ticket";
            string queryx = "SELECT * FROM  CustomerRegBuysT WHERE C_TicketType='" + x + "'";
            FillDataGridView(queryx);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = "Regular Ticket";
            string queryx = "SELECT * FROM  CustomerRegBuysT WHERE C_TicketType='" + x + "'";
            FillDataGridView(queryx);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TicketSellerView ticketSellerView = new TicketSellerView();
            ticketSellerView.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
