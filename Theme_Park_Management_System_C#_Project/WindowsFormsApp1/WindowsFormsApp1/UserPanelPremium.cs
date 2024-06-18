using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserPanelPremium : Form
    {
        private SqlConnection conn;
        private readonly string dbsconnectionx = DBCon.Instance.ConnectionString;

        // Global variable to store the total sum
        private decimal totalSum = 0;

        public UserPanelPremium(string UserName)
        {
            GivenName = UserName;
            InitializeComponent();
            Loadname();

            string[] Role = new string[3];
            Role[0] = "Bkash";
            Role[1] = "Nagad";
            Role[2] = "Visa Card";
            RoleBox.DataSource = Role;
            conn = new SqlConnection(dbsconnectionx);
            timer = new Timer();

            timer.Interval = 1000; //mili second
            timer.Tick += timer_Tick;
            timer.Start();
            //timer1
            timer1 = new Timer();
            timer1.Interval = 1000; //mili second
            timer1.Tick += timer1_Tick;
            timer1.Start();
            //timer2
            timer2 = new Timer();
            timer2.Interval = 1000; //mili second
            timer2.Tick += timer2_Tick;
            timer2.Start();
            //timer3
            timer3 = new Timer();
            timer3.Interval = 1000; //mili second
            timer3.Tick += timer3_Tick;
            timer3.Start();
            //time4
            timer4 = new Timer();
            timer4.Interval = 1000; //mili second
            timer4.Tick += timer4_Tick;
            timer4.Start();
            //ride checkboxes
            ride1check.Enabled = true;
            ride2check.Enabled = true;
            ride3check.Enabled = true;
            ride4check.Enabled = true;
            ride5check.Enabled = true;
            //food
            //timer5
            timer5 = new Timer();
            timer5.Interval = 1000; //mili second
            timer5.Tick += timer5_Tick;
            timer5.Start();
            //timer6
            timer6 = new Timer();
            timer6.Interval = 1000; //mili second
            timer6.Tick += timer6_Tick;
            timer6.Start();
            //timer7
            timer7 = new Timer();
            timer7.Interval = 1000; //mili second
            timer7.Tick += timer7_Tick;
            timer7.Start();
            //timer8
            timer8 = new Timer();
            timer8.Interval = 1000; //mili second
            timer8.Tick += timer8_Tick;
            timer8.Start();
            //timer9
            timer9 = new Timer();
            timer9.Interval = 1000; //mili second
            timer9.Tick += timer9_Tick;
            timer9.Start();
            //timer10

            timer10 = new Timer();
            timer10.Interval = 1000; //mili second
            timer10.Tick += timer10_Tick;
            timer10.Start();

            food1check.Enabled = true;
            food2check.Enabled = true;
            food3check.Enabled = true;
            food4check.Enabled = true;
            food5check.Enabled = true;
            food6check.Enabled = true;
        }

        private string GivenName { get; set; }

        private void Loadname()
        {
            UserNameLbs.Text = GivenName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserPanelOne us = new UserPanelOne(GivenName);
            this.Hide();
            us.Show();
        }

        private void UpdateRideLabel()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Rd_name FROM RideTable WHERE Rd_id = @rideID", conn);
                command.Parameters.AddWithValue("@rideID", 111);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string rideName = reader["Rd_name"].ToString();
                    name1.Text = rideName;
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

        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateRideLabel();
            updateprice1();
            updateSTatus1();
            updateCapacity1();
        }

        private void updateprice1()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Rd_price FROM RideTable WHERE Rd_id = @rideID", conn);
                command.Parameters.AddWithValue("@rideID", 111);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string rideName = reader["Rd_price"].ToString();
                    price1.Text = "Bdt: " + rideName + "Tk";
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
        private void updateSTatus1()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Rd_status FROM RideTable WHERE Rd_id = @rideID", conn);
                command.Parameters.AddWithValue("@rideID", 111);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string rideName = reader["Rd_status"].ToString();

                    status1.Text = "Status: " + rideName + "";
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

        private void updateCapacity1()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Rd_capacity FROM RideTable WHERE Rd_id = @rideID", conn);
                command.Parameters.AddWithValue("@rideID", 111);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string rideName = reader["Rd_capacity"].ToString();
                    capacity1.Text = "Capacity: " + rideName + "";
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbsconnectionx);
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT Rd_status, Rd_price FROM RideTable WHERE Rd_id = @rideID", conn);
            command.Parameters.AddWithValue("@rideID", 111);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string status = reader["Rd_status"].ToString(); ;
                string price = reader["Rd_price"].ToString();

                if (status == "Active")
                {
                    if (ride1check.Checked)
                    {
                        totalSum += decimal.Parse(price);
                    }
                    else
                    {
                        totalSum -= decimal.Parse(price);
                    }

                    AmmountLbs.Text = totalSum.ToString();

                    conn.Close();
                }
                else
                {
                    ride1check.Checked = false;
                    MessageBox.Show("This ride is not active. You cannot select it.");
                    conn.Close();
                }
            }
            reader.Close();
            conn.Close();
        }

        private void updateride2name()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Rd_name FROM RideTable WHERE Rd_id = @rideID", conn);
                command.Parameters.AddWithValue("@rideID", 119);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string rideName = reader["Rd_name"].ToString();
                    ride2name.Text = rideName;
                }
                reader.Close();
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

        private void updateride2price()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Rd_price FROM RideTable WHERE Rd_id = @rideID", conn);
                command.Parameters.AddWithValue("@rideID", 119);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string rideName = reader["Rd_price"].ToString();
                    ride2price.Text = "Bdt: " + rideName + "Tk";
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

        private void updateride2status()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Rd_status FROM RideTable WHERE Rd_id = @rideID", conn);
                command.Parameters.AddWithValue("@rideID", 119);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string rideName = reader["Rd_status"].ToString();
                    ride2status.Text = "Status: " + rideName + "";
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
        private void updateride2capacity()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Rd_capacity FROM RideTable WHERE Rd_id = @rideID", conn);
                command.Parameters.AddWithValue("@rideID", 119);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string rideName = reader["Rd_capacity"].ToString();
                    ride2capacity.Text = "Capacity: " + rideName + "";
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateride2name();
            updateride2capacity();
            updateride2price();
            updateride2status();
        }

        private void ride2check_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbsconnectionx);
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT Rd_status, Rd_price FROM RideTable WHERE Rd_id = @rideID", conn);
            command.Parameters.AddWithValue("@rideID", 119);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string status = reader["Rd_status"].ToString();
                string price = reader["Rd_price"].ToString();

                if (status == "Active")
                {
                    if (ride2check.Checked)
                    {
                        totalSum += decimal.Parse(price);
                    }
                    else
                    {
                        totalSum -= decimal.Parse(price);
                    }

                    AmmountLbs.Text = totalSum.ToString();

                    conn.Close();
                }
                else
                {
                    ride2check.Checked = false;
                    MessageBox.Show("This ride is not active. You cannot select it.");
                    conn.Close();
                }
            }
            reader.Close();
            conn.Close();
        }

        private void updateride3name()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Rd_name FROM RideTable WHERE Rd_id = @rideID", conn);
                command.Parameters.AddWithValue("@rideID", 112);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string rideName = reader["Rd_name"].ToString();
                    ride3name.Text = rideName;
                }
                reader.Close();
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

        private void updateride3price()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Rd_price FROM RideTable WHERE Rd_id = @rideID", conn);
                command.Parameters.AddWithValue("@rideID", 112);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string rideName = reader["Rd_price"].ToString();
                    ride3price.Text = "Bdt: " + rideName + "Tk";
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

        private void updateride3status()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Rd_status FROM RideTable WHERE Rd_id = @rideID", conn);
                command.Parameters.AddWithValue("@rideID", 112);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string rideName = reader["Rd_status"].ToString();
                    ride3status.Text = "Status: " + rideName + "";
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

        private void updateride3capacity()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Rd_capacity FROM RideTable WHERE Rd_id = @rideID", conn);
                command.Parameters.AddWithValue("@rideID", 112);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string rideName = reader["Rd_capacity"].ToString();
                    ride3capacity.Text = "Capacity: " + rideName + "";
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            updateride3name();
            updateride3capacity();
            updateride3price();
            updateride3status();
        }

        private void ride3check_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbsconnectionx);
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT Rd_status, Rd_price FROM RideTable WHERE Rd_id = @rideID", conn);
            command.Parameters.AddWithValue("@rideID", 112);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string status = reader["Rd_status"].ToString();
                string price = reader["Rd_price"].ToString();

                if (status == "Active")
                {
                    if (ride3check.Checked)
                    {
                        totalSum += decimal.Parse(price);
                    }
                    else
                    {
                        totalSum -= decimal.Parse(price);
                    }

                    AmmountLbs.Text = totalSum.ToString();

                    conn.Close();
                }
                else
                {
                    ride3check.Checked = false;
                    MessageBox.Show("This ride is not active. You cannot select it.");
                    conn.Close();
                }
            }
            reader.Close();
            conn.Close();
        }

        private void updateride4name()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Rd_name FROM RideTable WHERE Rd_id = @rideID", conn);
                command.Parameters.AddWithValue("@rideID", 115);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string rideName = reader["Rd_name"].ToString();
                    ride4name.Text = rideName;
                }
                reader.Close();

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
        private void updateride4price()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Rd_price FROM RideTable WHERE Rd_id = @rideID", conn);
                command.Parameters.AddWithValue("@rideID", 115);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string rideName = reader["Rd_price"].ToString();
                    ride4price.Text = "Bdt: " + rideName + "Tk";
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

        private void updateride4status()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Rd_status FROM RideTable WHERE Rd_id = @rideID", conn);
                command.Parameters.AddWithValue("@rideID", 115);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string rideName = reader["Rd_status"].ToString();
                    ride4status.Text = "Status: " + rideName + "";
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

        private void updateride4capacity()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Rd_capacity FROM RideTable WHERE Rd_id = @rideID", conn);
                command.Parameters.AddWithValue("@rideID", 115);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string rideName = reader["Rd_capacity"].ToString();
                    ride4capacity.Text = "Capacity: " + rideName + "";
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

        private void timer3_Tick(object sender, EventArgs e)
        {
            updateride4name();
            updateride4capacity();
            updateride4price();
            updateride4status();
        }

        private void ride4check_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbsconnectionx);
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT Rd_status, Rd_price FROM RideTable WHERE Rd_id = @rideID", conn);
            command.Parameters.AddWithValue("@rideID", 115);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string status = reader["Rd_status"].ToString();
                string price = reader["Rd_price"].ToString();

                if (status == "Active")
                {
                    if (ride4check.Checked)
                    {
                        totalSum += decimal.Parse(price);
                    }
                    else
                    {
                        totalSum -= decimal.Parse(price);
                    }

                    AmmountLbs.Text = totalSum.ToString();

                    conn.Close();
                }
                else
                {
                    ride4check.Checked = false;
                    MessageBox.Show("This ride is not active. You cannot select it.");
                    conn.Close();
                }
            }
            reader.Close();
            conn.Close();
        }

        private void updateride5name()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Rd_name FROM RideTable WHERE Rd_id = @rideID", conn);
                command.Parameters.AddWithValue("@rideID", 117);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string rideName = reader["Rd_name"].ToString();
                    ride5name.Text = rideName;
                }
                reader.Close();

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

        private void updateride5price()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Rd_price FROM RideTable WHERE Rd_id = @rideID", conn);
                command.Parameters.AddWithValue("@rideID", 117);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string rideName = reader["Rd_price"].ToString();
                    ride5price.Text = "Bdt: " + rideName + "Tk";
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

        private void updateride5status()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Rd_status FROM RideTable WHERE Rd_id = @rideID", conn);
                command.Parameters.AddWithValue("@rideID", 117);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string rideName = reader["Rd_status"].ToString();
                    ride5status.Text = "Status: " + rideName + "";
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

        private void updateride5capacity()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Rd_capacity FROM RideTable WHERE Rd_id = @rideID", conn);
                command.Parameters.AddWithValue("@rideID", 117);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string rideName = reader["Rd_capacity"].ToString();
                    ride5capacity.Text = "Capacity: " + rideName + "";
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

        private void timer4_Tick(object sender, EventArgs e)
        {
            updateride5name();
            updateride5capacity();
            updateride5price();
            updateride5status();
        }

        private void ride5check_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbsconnectionx);
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT Rd_status, Rd_price FROM RideTable WHERE Rd_id = @rideID", conn);
            command.Parameters.AddWithValue("@rideID", 117);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string status = reader["Rd_status"].ToString();
                string price = reader["Rd_price"].ToString();

                if (status == "Active")
                {

                    if (ride5check.Checked)
                    {
                        totalSum += decimal.Parse(price);
                    }
                    else
                    {
                        totalSum -= decimal.Parse(price);
                    }

                    AmmountLbs.Text = totalSum.ToString();

                    conn.Close();
                }
                else
                {
                    ride5check.Checked = false;
                    MessageBox.Show("This ride is not active. You cannot select it.");
                    conn.Close();
                }
            }
            reader.Close();
            conn.Close();
        }

        private void unselectButton_Click(object sender, EventArgs e)
        {

            ride1check.Checked = false;

        }

        //food1
        private void updatefood1name()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Fd_name FROM FoodTable WHERE Fd_id = @foodID", conn);
                command.Parameters.AddWithValue("@foodID", 101);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string foodName = reader["Fd_name"].ToString();
                    food1name.Text = foodName;
                }
                reader.Close();

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

        private void updatefood1price()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Fd_price FROM FoodTable WHERE Fd_id = @foodID", conn);
                command.Parameters.AddWithValue("@foodID", 101);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string foodName = reader["Fd_price"].ToString();
                    food1price.Text = "Bdt:" + foodName + "Tk";
                }
                reader.Close();

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

        private void updatefood1status()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Fd_status FROM FoodTable WHERE Fd_id = @foodID", conn);
                command.Parameters.AddWithValue("@foodID", 101);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string foodName = reader["Fd_status"].ToString();
                    food1status.Text = foodName;
                }
                reader.Close();

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

        private void timer5_Tick(object sender, EventArgs e)
        {
            updatefood1name();
            updatefood1price();
            updatefood1status();
        }

        private void food1check_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbsconnectionx);
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT Fd_status, Fd_price FROM FoodTable WHERE Fd_id = @foodID", conn);
            command.Parameters.AddWithValue("@foodID", 101);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string status = reader["Fd_status"].ToString();
                string price = reader["Fd_price"].ToString();

                if (status == "Available")
                {

                    if (food1check.Checked)
                    {
                        totalSum += decimal.Parse(price);
                    }
                    else
                    {
                        totalSum -= decimal.Parse(price);
                    }

                    AmmountLbs.Text = totalSum.ToString();

                    conn.Close();
                }
                else
                {
                    food1check.Checked = false;
                    MessageBox.Show("This ride is not active. You cannot select it.");
                    conn.Close();
                }

            }
            reader.Close();
            conn.Close();
        }

        //food2
        private void updatefood2name()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Fd_name FROM FoodTable WHERE Fd_id = @foodID", conn);
                command.Parameters.AddWithValue("@foodID", 102);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string foodName = reader["Fd_name"].ToString();
                    food2name.Text = foodName;
                }
                reader.Close();

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
        private void updatefood2price()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Fd_price FROM FoodTable WHERE Fd_id = @foodID", conn);
                command.Parameters.AddWithValue("@foodID", 102);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string foodName = reader["Fd_price"].ToString();
                    food2price.Text = "Bdt:" + foodName + "Tk";
                }
                reader.Close();

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
        private void updatefood2status()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Fd_status FROM FoodTable WHERE Fd_id = @foodID", conn);
                command.Parameters.AddWithValue("@foodID", 102);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string foodName = reader["Fd_status"].ToString();
                    food2status.Text = foodName;
                }
                reader.Close();

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

        private void timer6_Tick(object sender, EventArgs e)
        {
            updatefood2name();
            updatefood2price();
            updatefood2status();
        }

        private void food2check_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbsconnectionx);
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT Fd_status, Fd_price FROM FoodTable WHERE Fd_id = @foodID", conn);
            command.Parameters.AddWithValue("@foodID", 102);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string status = reader["Fd_status"].ToString();
                string price = reader["Fd_price"].ToString();

                if (status == "Available")
                {
                    if (food2check.Checked)
                    {
                        totalSum += decimal.Parse(price);
                    }
                    else
                    {
                        totalSum -= decimal.Parse(price);
                    }

                    AmmountLbs.Text = totalSum.ToString();

                    conn.Close();
                }
                else
                {
                    food2check.Checked = false;
                    MessageBox.Show("This ride is not active. You cannot select it.");
                    conn.Close();
                }

            }
            reader.Close();
            conn.Close();
        }

        //food3
        private void updatefood3name()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Fd_name FROM FoodTable WHERE Fd_id = @foodID", conn);
                command.Parameters.AddWithValue("@foodID", 104);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string foodName = reader["Fd_name"].ToString();
                    food3name.Text = foodName;
                }
                reader.Close();

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
        private void updatefood3price()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Fd_price FROM FoodTable WHERE Fd_id = @foodID", conn);
                command.Parameters.AddWithValue("@foodID", 104);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string foodName = reader["Fd_price"].ToString();
                    food3price.Text = "Bdt:" + foodName + "Tk";
                }
                reader.Close();

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
        private void updatefood3status()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Fd_status FROM FoodTable WHERE Fd_id = @foodID", conn);
                command.Parameters.AddWithValue("@foodID", 104);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string foodName = reader["Fd_status"].ToString();
                    food3status.Text = foodName;
                }
                reader.Close();

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

        private void timer7_Tick(object sender, EventArgs e)
        {
            updatefood3name();
            updatefood3price();
            updatefood3status();
        }

        private void food3check_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbsconnectionx);
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT Fd_status, Fd_price FROM FoodTable WHERE Fd_id = @foodID", conn);
            command.Parameters.AddWithValue("@foodID", 104);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string status = reader["Fd_status"].ToString();
                string price = reader["Fd_price"].ToString();

                if (status == "Available")
                {
                    if (food3check.Checked)
                    {
                        totalSum += decimal.Parse(price);
                    }
                    else
                    {
                        totalSum -= decimal.Parse(price);
                    }

                    AmmountLbs.Text = totalSum.ToString();

                    conn.Close();
                }
                else
                {
                    food3check.Checked = false;
                    MessageBox.Show("This ride is not active. You cannot select it.");
                    conn.Close();
                }

            }
            reader.Close();
            conn.Close();
        }

        //food4
        private void updatefood4name()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Fd_name FROM FoodTable WHERE Fd_id = @foodID", conn);
                command.Parameters.AddWithValue("@foodID", 103);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string foodName = reader["Fd_name"].ToString();
                    food4name.Text = foodName;
                }
                reader.Close();

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

        private void updatefood4price()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Fd_price FROM FoodTable WHERE Fd_id = @foodID", conn);
                command.Parameters.AddWithValue("@foodID", 103);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string foodName = reader["Fd_price"].ToString();
                    food4price.Text = "Bdt:" + foodName + "Tk";
                }
                reader.Close();

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

        private void updatefood4status()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Fd_status FROM FoodTable WHERE Fd_id = @foodID", conn);
                command.Parameters.AddWithValue("@foodID", 103);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string foodName = reader["Fd_status"].ToString();
                    food4status.Text = foodName;
                }
                reader.Close();

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

        private void timer8_Tick(object sender, EventArgs e)
        {
            updatefood4name();
            updatefood4price();
            updatefood4status();
        }

        private void food4check_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbsconnectionx);
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT Fd_status, Fd_price FROM FoodTable WHERE Fd_id = @foodID", conn);
            command.Parameters.AddWithValue("@foodID", 103);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string status = reader["Fd_status"].ToString();
                string price = reader["Fd_price"].ToString();

                if (status == "Available")
                {
                    if (food4check.Checked)
                    {
                        totalSum += decimal.Parse(price);
                    }
                    else
                    {
                        totalSum -= decimal.Parse(price);
                    }

                    AmmountLbs.Text = totalSum.ToString();

                    conn.Close();
                }
                else
                {
                    food4check.Checked = false;
                    MessageBox.Show("This ride is not active. You cannot select it.");
                    conn.Close();
                }

            }
            reader.Close();
            conn.Close();
        }

        //food5
        private void updatefood5name()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Fd_name FROM FoodTable WHERE Fd_id = @foodID", conn);
                command.Parameters.AddWithValue("@foodID", 107);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string foodName = reader["Fd_name"].ToString();
                    food5name.Text = foodName;
                }
                reader.Close();

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
        private void updatefood5price()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Fd_price FROM FoodTable WHERE Fd_id = @foodID", conn);
                command.Parameters.AddWithValue("@foodID", 107);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string foodName = reader["Fd_price"].ToString();
                    food5price.Text = "Bdt:" + foodName + "Tk";
                }
                reader.Close();

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
        private void updatefood5status()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Fd_status FROM FoodTable WHERE Fd_id = @foodID", conn);
                command.Parameters.AddWithValue("@foodID", 107);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string foodName = reader["Fd_status"].ToString();
                    food5status.Text = foodName;
                }
                reader.Close();

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

        private void timer9_Tick(object sender, EventArgs e)
        {
            updatefood5name();
            updatefood5price();
            updatefood5status();
        }

        //food6
        private void updatefood6name()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Fd_name FROM FoodTable WHERE Fd_id = @foodID", conn);
                command.Parameters.AddWithValue("@foodID", 108);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string foodName = reader["Fd_name"].ToString();
                    food6name.Text = foodName;
                }
                reader.Close();

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
        private void updatefood6price()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Fd_price FROM FoodTable WHERE Fd_id = @foodID", conn);
                command.Parameters.AddWithValue("@foodID", 108);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string foodName = reader["Fd_price"].ToString();
                    food6price.Text = "Bdt:" + foodName + "Tk";
                }
                reader.Close();

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
        private void updatefood6status()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Fd_status FROM FoodTable WHERE Fd_id = @foodID", conn);
                command.Parameters.AddWithValue("@foodID", 108);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string foodName = reader["Fd_status"].ToString();
                    food6status.Text = foodName;
                }
                reader.Close();

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

        private void timer10_Tick(object sender, EventArgs e)
        {
            updatefood6name();
            updatefood6price();
            updatefood6status();
        }

        private void food6check_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbsconnectionx);
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT Fd_status, Fd_price FROM FoodTable WHERE Fd_id = @foodID", conn);
            command.Parameters.AddWithValue("@foodID", 108);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string status = reader["Fd_status"].ToString();
                string price = reader["Fd_price"].ToString();

                if (status == "Available")
                {
                    if (food6check.Checked)
                    {
                        totalSum += decimal.Parse(price);
                    }
                    else
                    {
                        totalSum -= decimal.Parse(price);
                    }

                    AmmountLbs.Text = totalSum.ToString();

                    conn.Close();
                }
                else
                {
                    food6check.Checked = false;
                    MessageBox.Show("This food is not available. You cannot select it.");
                    conn.Close();
                }

            }
            reader.Close();
            conn.Close();
        }

        private void food5check_CheckedChanged_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbsconnectionx);
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT Fd_status, Fd_price FROM FoodTable WHERE Fd_id = @foodID", conn);
            command.Parameters.AddWithValue("@foodID", 107);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string status = reader["Fd_status"].ToString();
                string price = reader["Fd_price"].ToString();

                string st = "Available";
                if (status == st)
                {
                    if (food5check.Checked)
                    {
                        totalSum += decimal.Parse(price);
                    }
                    else
                    {
                        totalSum -= decimal.Parse(price);
                    }

                    AmmountLbs.Text = totalSum.ToString();

                    conn.Close();
                }
                else
                {
                    food5check.Checked = false;
                    MessageBox.Show("This food is not available. You cannot select it.");
                    conn.Close();
                }
            }
            reader.Close();
            conn.Close();
        }

        private void UserPanelPremium_Load(object sender, EventArgs e)
        {
            Datelb.Text = DateTime.Now.ToLongDateString();
            timer11.Start();
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            Datelb.Text = DateTime.Now.ToLongDateString();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (Caccno.Text == "")
            {
                MessageBox.Show("Please fill phone number!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ride1check.Checked && !ride2check.Checked && !ride3check.Checked && !ride4check.Checked && !ride5check.Checked
                && !food1check.Checked && !food2check.Checked && !food3check.Checked && !food4check.Checked && !food5check.Checked && !food6check.Checked)
            {
                MessageBox.Show("Please select a ticket!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string role = RoleBox.Text;
            if (role == "Bkash" || role == "Nagad")
            {
                SqlConnection conn = new SqlConnection(dbsconnectionx);
                conn.Open();
                try
                {
                    string username = UserNameLbs.Text;
                    string query = "SELECT * FROM CreateAccount WHERE User_Name = '" + UserNameLbs.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        username = UserNameLbs.Text;

                        string ammount = Convert.ToString(totalSum);
                        string MobileNum = Caccno.Text;

                        string queryu = "INSERT INTO PremiumTable(C_UserName, C_MobileNum, C_PayRoll, C_Price) VALUES(@Username, @Type, @Role, @Amount)";
                        SqlCommand cmd = new SqlCommand(queryu, conn);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Type", MobileNum);
                        cmd.Parameters.AddWithValue("@Role", role);
                        cmd.Parameters.AddWithValue("@Amount", ammount);
                        cmd.ExecuteNonQuery();

                        string outPut = "User Name:" + username + "\n MobileNum:" + MobileNum + "\nAmmount Paid:" + ammount + "\nPremium Package Holder";
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
            else if (role == "Visa Card" && UserNameLbs.Text != "")
            {

                SqlConnection conn = new SqlConnection(dbsconnectionx);
                conn.Open();
                try
                {
                    string username = UserNameLbs.Text;
                    string query = "SELECT * FROM CreateAccount WHERE User_Name = '" + UserNameLbs.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        username = UserNameLbs.Text;

                        string ammount = Convert.ToString(totalSum);
                        string MobileNum = Caccno.Text;

                        string queryu = "INSERT INTO PremiumTable(C_UserName, C_MobileNum, C_PayRoll, C_Price) VALUES(@Username, @Type, @Role, @Amount)";
                        SqlCommand cmd = new SqlCommand(queryu, conn);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Type", MobileNum);
                        cmd.Parameters.AddWithValue("@Role", role);
                        cmd.Parameters.AddWithValue("@Amount", ammount);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Paid Successfully");

                        string outPut = "User Name:" + username + "\n MobileNum:" + MobileNum + "\nAmmount Paid:" + ammount + "\nPremium Package Holder";
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

        private void UserNameLbs_Click(object sender, EventArgs e)
        {

        }
    }
}
