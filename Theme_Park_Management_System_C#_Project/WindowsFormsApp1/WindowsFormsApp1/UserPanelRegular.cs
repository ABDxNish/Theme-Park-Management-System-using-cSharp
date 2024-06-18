using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserPanelRegular : Form
    {
        private readonly string dbsconnection1 = DBCon.Instance.ConnectionString;
        private SqlConnection conn;

        string fampr_price;
        string regpr_price;

        public UserPanelRegular(string UserName)
        {
            GivenName = UserName;
            InitializeComponent();
            Loadname();

            conn = new SqlConnection(dbsconnection1);
            string[] Role = new string[3];
            Role[0] = "Bkash";
            Role[1] = "Nagad";
            Role[2] = "Visa Card";
            RoleBox.DataSource = Role;
            timer1 = new Timer();
            timer1.Interval = 1000; //mili second
            timer1.Tick += timer1_Tick;
            timer1.Start();
            //timer1
            timer2 = new Timer();
            timer2.Interval = 1000; //mili second
            timer2.Tick += timer2_Tick;
            timer2.Start();
        }

        private string GivenName { get; set; }

        private void Loadname()
        {
            UserNameLbs.Text = GivenName;
        }

        private void pricereg()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT T_price FROM RegTicketTable WHERE T_id = @TicID", conn);
                command.Parameters.AddWithValue("@TicID", 502);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    regpr_price = reader["T_price"].ToString();
                    regpr.Text = "Price: " + regpr_price + " Bdt";
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void priceprem()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT T_price FROM RegTicketTable WHERE T_id = @TicID", conn);
                command.Parameters.AddWithValue("@TicID", 501);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    fampr_price = reader["T_price"].ToString();
                    fampr.Text = "Price: " + fampr_price + "Bdt";
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserPanelOne userPanelOne = new UserPanelOne(GivenName);
            this.Hide();
            userPanelOne.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CaacBox.Text == "")
            {
                MessageBox.Show("Please fill phone number!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!fam.Checked && !reg.Checked)
            {
                MessageBox.Show("Please select a ticket!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string role = RoleBox.Text;
            if (role == "Bkash" || role == "Nagad")
            {
                SqlConnection conn = new SqlConnection(dbsconnection1);
                conn.Open();
                try
                {
                    string username = GivenName;
                    string query = "SELECT * FROM CreateAccount WHERE User_Name = '" + GivenName + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        username = GivenName;

                        // Check which radio button is checked
                        string type = fam.Checked ? "Family Ticket" : "Regular Ticket";
                        string ammount;

                        // Set the appropriate price based on the radio button selection
                        if (type == "Family Ticket")
                        {
                            ammount = fampr_price;
                        }
                        else
                        {
                            ammount = regpr_price;
                        }

                        string queryu = "INSERT INTO CustomerRegBuysT(C_UserName, C_TicketType, C_PayRoll, C_Price) VALUES(@Username, @Type, @Role, @Amount)";
                        SqlCommand cmd = new SqlCommand(queryu, conn);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Type", type);
                        cmd.Parameters.AddWithValue("@Role", role);
                        cmd.Parameters.AddWithValue("@Amount", ammount);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Paid Successfully");
                        string mb = CaacBox.Text;
                        string outPut = "User Name:" + username + "\n Ticket Type:" + type + "\nAmmount Paid:" + ammount + "\nAccount No:" + mb;
                        ThanksPage tkp = new ThanksPage(GivenName, outPut);
                        tkp.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong User Name Or Password", ("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else if (role == "Visa Card" && GivenName != "")
            {

                SqlConnection conn = new SqlConnection(dbsconnection1);
                conn.Open();
                try
                {
                    string username = GivenName;
                    string query = "SELECT * FROM CreateAccount WHERE User_Name = '" + GivenName + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        username = GivenName;

                        // Check which radio button is checked
                        string type = fam.Checked ? "Family Ticket" : "Regular Ticket";
                        string ammount;

                        // Set the appropriate price based on the radio button selection
                        if (type == "Family Ticket")
                        {
                            ammount = fampr_price;
                        }
                        else
                        {
                            ammount = regpr_price;
                        }

                        string queryu = "INSERT INTO CustomerRegBuysT(C_UserName, C_TicketType, C_PayRoll, C_Price) VALUES(@Username, @Type, @Role, @Amount)";
                        SqlCommand cmd = new SqlCommand(queryu, conn);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Type", type);
                        cmd.Parameters.AddWithValue("@Role", role);
                        cmd.Parameters.AddWithValue("@Amount", ammount);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Paid Successfully");
                        string mb = CaacBox.Text;
                        string outPut = "User Name:" + username + "\n Ticket Type:" + type + "\nAmmount Paid:" + ammount + "\nAccount No:" + mb;
                        ThanksPage tkp = new ThanksPage(GivenName, outPut);
                        tkp.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong User Name Or Password", ("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                MessageBox.Show("An Unknown Error Has been Occured", ("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pricereg();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            priceprem();
        }

        private void fam_CheckedChanged(object sender, EventArgs e)
        {
            if (fam.Checked)
            {
                AmmountLbs.Text = fampr_price;
            }
        }

        private void reg_CheckedChanged(object sender, EventArgs e)
        {
            if (reg.Checked)
            {
                AmmountLbs.Text = regpr_price;
            }
        }
    }
}
