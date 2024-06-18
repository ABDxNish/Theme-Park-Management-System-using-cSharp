using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class JobApply : Form
    {
        private readonly string dbsconnectionz = DBCon.Instance.ConnectionString;
        public JobApply()
        {
            InitializeComponent();
            ProfilePictureBox.Image = Properties.Resources.DefaultProfileImage;
            string[] sex = new string[2];
            sex[0] = "Male";
            sex[1] = "Female";
            JSexBox.DataSource = sex;
            string[] state = new string[12];
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
            state[10] = "Shewra Para";
            state[11] = "Mirpur-1";
            JCityBox.DataSource = state;
            string[] Role = new string[2];
            Role[0] = "Ticket Seller";
            Role[1] = "Ride Operator";
            JRoleBox.DataSource = Role;
            string[] experiecnce = new string[2];
            experiecnce[0] = "Yes";
            experiecnce[1] = "No";
            JExpBox.DataSource = experiecnce;
            string[] education = new string[4];
            education[0] = "Hsc Passed";
            education[1] = "Jsc Passed";
            education[2] = "Undegraduate";
            education[3] = "Graduated";
            JEducationalBox.DataSource = education;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Choose(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ProfilePictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = JNameBox.Text;
            string age = JAgeBox.Text;
            string sex = JSexBox.Text;
            string edu = JEducationalBox.Text;
            string city = JCityBox.Text;
            string Role = JRoleBox.Text;
            string username = JUserName.Text;
            string password = JPass.Text;
            string phone = JPhone.Text;
            string cgpa = JCgpaBox.Text;
            string experince = JExpBox.Text;
            string exptime = JExpTimeBox.Text;
            if (name == " " || age == "" || sex == "" || edu == "" || city == "" || Role == "" || username == "" || password == "" || phone == "" || cgpa == "" || experince == "" || exptime == "")
            {
                MessageBox.Show("Please Fillup All The Component", ("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (experince == "Yes" && exptime == "0")
                {

                    MessageBox.Show("Please Provide Experience Time", ("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    string checkUserNamequery = "SELECT UserName FROM AppliedJobP WHERE UserName='" + username + "'";
                    SqlConnection cx = new SqlConnection(dbsconnectionz);
                    cx.Open();

                    SqlCommand cm = new SqlCommand(checkUserNamequery, cx);
                    cm.ExecuteNonQuery();
                    string result = (string)cm.ExecuteScalar();
                    if (result != null && result.Equals(username))
                    {
                        MessageBox.Show("UserName Not Availaible", ("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cx.Close();
                    }
                    else if (result == null)
                    {
                        SqlConnection conn = new SqlConnection(dbsconnectionz);

                        conn.Open();
                        MemoryStream mst = new MemoryStream();
                        ProfilePictureBox.Image.Save(mst, ProfilePictureBox.Image.RawFormat);
                        string query = "INSERT INTO AppliedJobP(Photo,Name,Age,Sex,Education,Cgpa,Experience,Role,City,Phone,UserName,Password) VALUES(@Photo,'" + name + "','" + age + "','" + sex + "','" + edu + "','" + cgpa + "','" + exptime + "','" + Role + "',  '" + city + "'  ,  '" + phone + "'   ,'" + username + "','" + password + "')";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("Photo", mst.ToArray());
                        cmd.ExecuteNonQuery();


                        conn.Close();
                        cx.Close();
                        MessageBox.Show("Submitted");
                        JobSubmitThanks jmb = new JobSubmitThanks();
                        this.Hide();
                        jmb.Show();
                    }
                    else
                    {
                        SqlConnection conn = new SqlConnection(dbsconnectionz);

                        conn.Open();
                        MemoryStream mst = new MemoryStream();
                        ProfilePictureBox.Image.Save(mst, ProfilePictureBox.Image.RawFormat);
                        string query = "INSERT INTO AppliedJobP(Photo,Name,Age,Sex,Education,Cgpa,Experience,Role,City,Phone,UserName,Password) VALUES(@Photo,'" + age + "','" + sex + "','" + edu + "','" + cgpa + "','" + exptime + "','" + Role + "',  '" + city + "'  ,  '" + phone + "'   ,'" + username + "','" + password + "')";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("Photo", mst.ToArray());
                        cmd.ExecuteNonQuery();


                        conn.Close();
                        cx.Close();
                        MessageBox.Show("Submitted");

                        JobSubmitThanks jmb = new JobSubmitThanks();
                        this.Hide();
                        jmb.Show();
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signup frm = new Signup();
            this.Hide();
            frm.Show();
        }
    }
}
