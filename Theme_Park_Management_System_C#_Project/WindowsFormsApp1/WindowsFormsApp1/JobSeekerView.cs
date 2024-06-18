using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class JobSeekerView : Form
    {
        private readonly string dbsconnectionx = DBCon.Instance.ConnectionString;

        public JobSeekerView()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string queryx = "SELECT * FROM  AppliedJobP";
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

        private void viewjobseeker_Load(object sender, EventArgs e)
        {
            string[] Role = new string[2];
            Role[0] = "Ride Operator";
            Role[1] = "Ticket Seller";

            RoleBox.DataSource = Role;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminPanel adp = new AdminPanel();
            this.Hide();
            adp.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string txt = JobSearch.Text;
            if (!string.IsNullOrWhiteSpace(txt))
            {
                string q2 = $"SELECT * FROM AppliedJobP WHERE UserName LIKE '%{txt}%' ";
                FillDataGridView(q2);
            }
            else
            {
                MessageBox.Show("Not Found! Enter Valid Name", ("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string q2 = $"SELECT * FROM AppliedJobP WHERE Experience>0 ";
            FillDataGridView(q2);
        }

        private void MaleBox_Click(object sender, EventArgs e)
        {
            string txt = "Male";
            string q2 = $"SELECT * FROM AppliedJobP WHERE Sex='" + txt + "' ";
            FillDataGridView(q2);
        }

        private void FemaleButton_Click(object sender, EventArgs e)
        {
            string txt = "Female";
            string q2 = $"SELECT * FROM AppliedJobP WHERE Sex Like'%{txt}%' ";
            FillDataGridView(q2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string username = dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString();
                string role = RoleBox.Text;

                if (!string.IsNullOrWhiteSpace(username))
                {
                    SqlConnection ss = new SqlConnection(dbsconnectionx);
                    ss.Open();

                    if (role == "Ticket Seller")
                    {
                        string querygp = "INSERT INTO TicketSellerT (T_photo, T_name, T_age, T_sex, T_education, T_city, T_UserName, T_Password) " +
                                         "SELECT Photo, Name, Age, Sex, Education, City, UserName, Password " +
                                         "FROM AppliedJobP " +
                                         "WHERE UserName = @username";

                        SqlCommand cm = new SqlCommand(querygp, ss);
                        cm.Parameters.AddWithValue("@username", username);
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Added Successfully");

                        string queryDelete = "DELETE FROM AppliedJobP WHERE UserName = @username";
                        SqlCommand deleteCmd = new SqlCommand(queryDelete, ss);
                        deleteCmd.Parameters.AddWithValue("@username", username);
                        deleteCmd.ExecuteNonQuery();
                        ss.Close();

                        LoadData();
                    }
                    else if (role == "Ride Operator")
                    {
                        string querygp = "INSERT INTO RideOperatorR (R_photo, R_name, R_age, R_sex, R_education, R_city, R_UserName, R_Password) " +
                                         "SELECT Photo, Name, Age, Sex, Education, City, UserName, Password " +
                                         "FROM AppliedJobP " +
                                         "WHERE UserName = @username";

                        SqlCommand cm = new SqlCommand(querygp, ss);
                        cm.Parameters.AddWithValue("@username", username);
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Added Successfully");

                        string queryDelete = "DELETE FROM AppliedJobP WHERE UserName = @username";
                        SqlCommand deleteCmd = new SqlCommand(queryDelete, ss);
                        deleteCmd.Parameters.AddWithValue("@username", username);
                        deleteCmd.ExecuteNonQuery();
                        ss.Close();

                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Please Select A Role", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Select a user from the list first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No user selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
