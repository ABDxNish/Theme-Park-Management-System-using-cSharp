using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            LgUserName.Select();

        }

        private readonly string dbsconnection1 = DBCon.Instance.ConnectionString;

        private void loginform_Load(object sender, EventArgs e)
        {

            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            string[] Role = new string[5];
            Role[0] = "Admin";
            Role[1] = "Ticket Seller";
            Role[2] = "Customer";
            Role[3] = "Ride Operator";
            RoleBox.DataSource = Role;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbsconnection1);
            conn.Open();
            string role = RoleBox.Text;
            if (role == "Admin")
            {
                string UserName = LgUserName.Text;
                string pass = LGPassBox.Text;
                try
                {
                    string query = "SELECT * FROM AdminAccount WHERE AdminUser_Name = '" + LgUserName.Text + "' And AdminPass='" + LGPassBox.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        UserName = LgUserName.Text;
                        pass = LGPassBox.Text;
                        MessageBox.Show("LogIn Succeed");
                        AdminPanel adm = new AdminPanel();
                        adm.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong User Name Or Password", ("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LgUserName.Clear();
                        LGPassBox.Clear();
                        LgUserName.Focus();
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
            else if (role == "Customer")
            {
                string username = LgUserName.Text;
                string pass = LGPassBox.Text;
                try
                {
                    string query = "SELECT * FROM CreateAccount WHERE User_Name = '" + LgUserName.Text + "' And Password='" + LGPassBox.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        username = LgUserName.Text;
                        pass = LGPassBox.Text;
                        MessageBox.Show("LogIn Succeed");
                        UserPanelOne adm = new UserPanelOne(username);
                        adm.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong User Name Or Password", ("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LgUserName.Clear();
                        LGPassBox.Clear();
                        LgUserName.Focus();
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
            else if (role == "Ride Operator")
            {
                string username = LgUserName.Text;
                string pass = LGPassBox.Text;
                try
                {
                    string query = "SELECT * FROM RideOperatorR WHERE R_UserName = '" + LgUserName.Text + "' And R_Password='" + LGPassBox.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        username = LgUserName.Text;
                        pass = LGPassBox.Text;
                        MessageBox.Show("LogIn Succeed");
                        RideOperatorView adm = new RideOperatorView();
                        adm.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong User Name Or Password", ("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LgUserName.Clear();
                        LGPassBox.Clear();
                        LgUserName.Focus();
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
            else if (role == "Ticket Seller")
            {
                string username = LgUserName.Text;
                string pass = LGPassBox.Text;
                try
                {
                    string query = "SELECT * FROM TicketSellerT WHERE T_UserName = '" + LgUserName.Text + "' And T_Password='" + LGPassBox.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        username = LgUserName.Text;
                        pass = LGPassBox.Text;
                        MessageBox.Show("LogIn Succeed");
                        TicketSellerView ticketSellerView = new TicketSellerView();
                        ticketSellerView.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong User Name Or Password", ("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LgUserName.Clear();
                        LGPassBox.Clear();
                        LgUserName.Focus();
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
            else
            {
                MessageBox.Show("Please Select A Valid Role", ("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signup fm = new Signup();
            Hide();
            fm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Signup fm = new Signup();
            Hide();
            fm.Show();

        }

        private void LgUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LGPassBox.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void LGPassBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void eye_btn_Click(object sender, EventArgs e)
        {
            LGPassBox.PasswordChar = (LGPassBox.PasswordChar == '\0') ? '*' : '\0';
        }
    }
}
