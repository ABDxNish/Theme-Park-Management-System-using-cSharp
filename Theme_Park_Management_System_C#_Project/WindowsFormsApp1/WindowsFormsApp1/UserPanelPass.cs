using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserPanelPass : Form
    {
        private readonly string dbsconnection1 = DBCon.Instance.ConnectionString;

        public UserPanelPass(string UserName)
        {
            GivenName = UserName;
            InitializeComponent();
            Loadname();
        }

        private string GivenName { get; set; }

        private void Loadname()
        {
            UserNameLbs.Text = GivenName;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            UserPanelOne userPanelOne = new UserPanelOne(GivenName);
            this.Hide();
            userPanelOne.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbsconnection1);
            conn.Open();

            try
            {
                string query = "SELECT * FROM CreateAccount WHERE User_Name = '" + GivenName + "' And Password='" + OldPass.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string newpass = NewPass.Text;
                    SqlConnection con = new SqlConnection(dbsconnection1);
                    con.Open();
                    string queryu = "UPDATE CreateAccount set Password='" + newpass + "' WHERE User_Name='" + GivenName + "'";
                    SqlCommand cmd = new SqlCommand(queryu, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Password Succefully Changed");
                    Login lg = new Login();
                    this.Hide();
                    lg.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Password", ("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OldPass.Clear();
                    NewPass.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Sorry An Unknown Error Has Been Occured", ("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void UserPanelPass_Load(object sender, EventArgs e)
        {

        }
    }
}
