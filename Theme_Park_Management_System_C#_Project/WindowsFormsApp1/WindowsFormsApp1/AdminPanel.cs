using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewTicketSeller tdg = new ViewTicketSeller();
            this.Hide();
            tdg.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure To LogOut?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                Login fm = new Login();
                fm.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerDetails cw = new CustomerDetails();
            this.Hide();
            cw.Show();
        }

        private void jobseekerButton_Click(object sender, EventArgs e)
        {
            JobSeekerView viewjobseeker = new JobSeekerView();
            this.Hide();
            viewjobseeker.Show();
        }

        private void RdOpViewButton_Click(object sender, EventArgs e)
        {
            ViewRideOperator vw = new ViewRideOperator();
            this.Hide();
            vw.Show();
        }
    }
}
