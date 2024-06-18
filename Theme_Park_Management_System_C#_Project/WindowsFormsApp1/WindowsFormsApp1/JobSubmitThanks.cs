using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class JobSubmitThanks : Form
    {
        public JobSubmitThanks()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            this.Hide();
            frm.Show();
        }
    }
}
