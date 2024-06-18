using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();

            string[] Nationality = new string[5];
            Nationality[0] = "Bangladesh";
            Nationality[1] = "Pakistan";
            Nationality[2] = "India";
            Nationality[3] = "Afghanistan";
            NationalityBox.DataSource = Nationality;

            string[] BloodGroups = new string[8];
            BloodGroups[0] = "A+";
            BloodGroups[1] = "A-";
            BloodGroups[2] = "B+";
            BloodGroups[3] = "B-";
            BloodGroups[4] = "AB+";
            BloodGroups[5] = "AB-";
            BloodGroups[6] = "O+";
            BloodGroups[7] = "O-";
            CBlodBox.DataSource = BloodGroups;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCityComboBox();
        }
        private void UpdateCityComboBox()
        {
            CityBox.DataSource = null;
            CityBox.Items.Clear();

            string[] state = new string[10];
            string selectedCountry = NationalityBox.SelectedItem.ToString();
            switch (selectedCountry)
            {
                case "Pakistan":
                    state[0] = "Karachi";
                    state[1] = "Lahore";
                    state[2] = "Islamabad";
                    state[3] = "Faisalabad";
                    state[4] = "Rawalpindi";
                    state[5] = "Multan";
                    state[6] = "Ahmedabad";
                    state[7] = "Gujranwala";
                    state[8] = "Peshawar";
                    state[9] = "Sialkot";


                    CityBox.DataSource = state;
                    break;
                case "India":
                    state[0] = "Mumbai";
                    state[1] = "Delhi";
                    state[2] = "Kolkata";
                    state[3] = "Chennai";
                    state[4] = "Tamil Nadu";
                    state[5] = "Hyderabad";
                    state[6] = "Ahmedabad";
                    state[7] = "Pune";
                    state[8] = "Surat";
                    state[9] = "Jaipur";


                    CityBox.DataSource = state;
                    break;
                case "Bangladesh":
                    state[0] = "Dhaka";
                    state[1] = "Tangail";
                    state[2] = "Rangpur";
                    state[3] = "Sylhet";
                    state[4] = "Noakhali";
                    state[5] = "Kuri Gram";
                    state[6] = "Rajshahi";
                    state[7] = "Dhaka Uttor";
                    state[8] = "Dhaka Mahanagr";
                    state[9] = "Gazipur";


                    CityBox.DataSource = state;
                    break;
                case "Afganistan":
                    state[0] = "Kabul";
                    state[1] = "Herat";
                    state[2] = "Kandahar";
                    state[3] = "Mazar-i-Sharif";
                    state[4] = "Jalalabad";
                    state[5] = "Kunduz";
                    state[6] = "Ghazni";
                    state[7] = "Bamyan";
                    state[8] = "Khost";
                    state[9] = "Lashkar Gah";


                    CityBox.DataSource = state;


                    break;


                default:
                    // Handle default case if necessary
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            Hide();
            lg.Show();
        }

        private void SignUpC_Click(object sender, EventArgs e)
        {
            if (CNameBox.Text == "" || CMobileBox.Text == "" || CAgeBox.Text == "" || CBlodBox.Text == ""
                || CUserNameBox.Text == "" || CPasswordBox.Text == "")
            {
                MessageBox.Show("Please fill in all the fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early if any field is empty
            }

            if (NationalityBox.Text == "Select A Country" || CityBox.Text == "Select A City")
            {
                MessageBox.Show("Select Nationality Or City First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early if nationality or city is not selected
            }

            string dbsconnection = DBCon.Instance.ConnectionString;
            string name = CNameBox.Text;
            string age = CAgeBox.Text;
            string dob = CDate.Value.ToString();
            string nat = NationalityBox.Text;
            string state = CityBox.Text;
            string bod = CBlodBox.Text;
            string sex = M.Checked ? "Male" : "Female";
            string username = CUserNameBox.Text;
            string pass = CPasswordBox.Text;

            string checkUserNamequery = "SELECT User_Name FROM CreateAccount WHERE User_Name = @Username";

            using (SqlConnection cx = new SqlConnection(dbsconnection))
            {
                cx.Open();
                using (SqlCommand cm = new SqlCommand(checkUserNamequery, cx))
                {
                    cm.Parameters.AddWithValue("@Username", username);
                    string result = cm.ExecuteScalar() as string;

                    if (result != null)
                    {
                        MessageBox.Show("Username Not Available", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            // Insert the new account into the database
            string query = "INSERT INTO CreateAccount (Name, Age, Sex, Nationality, Blood_Group, User_Name, Password) VALUES (@Name, @Age, @Sex, @Nationality, @BloodGroup, @UserName, @Password)";

            using (SqlConnection conn = new SqlConnection(dbsconnection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Sex", sex);
                    cmd.Parameters.AddWithValue("@Nationality", nat);
                    cmd.Parameters.AddWithValue("@BloodGroup", bod);
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@Password", pass);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account Created");
                        Login lf = new Login();
                        this.Hide();
                        lf.Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed to create account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CAgeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JobApply j = new JobApply();
            this.Hide();
            j.Show();
        }
    }
}
