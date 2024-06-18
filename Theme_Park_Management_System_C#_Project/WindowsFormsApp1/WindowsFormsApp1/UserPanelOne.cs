using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserPanelOne : Form
    {
        public UserPanelOne(string UserName)
        {
            GivenName = UserName;
            InitializeComponent();
            Loadname();
        }

        private string GivenName { get; set; }

        private void Loadname()
        {
            label1.Text = "Wellcome " + GivenName + "," + " To Our Fantasy Park!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserPanelPremium upp = new UserPanelPremium(GivenName);
            this.Hide();
            upp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserPanelPass ups = new UserPanelPass(GivenName);
            this.Hide();
            ups.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserPanelRegular urg = new UserPanelRegular(GivenName);
            this.Hide();
            urg.Show();
        }

        private void UserPanelOne_Load(object sender, EventArgs e)
        {

        }
    }
}
