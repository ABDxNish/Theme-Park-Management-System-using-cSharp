using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TicketSellerView : Form
    {
        public TicketSellerView()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewTicketOne vb = new ViewTicketOne();
            this.Hide();
            vb.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewTicketHistoryOne op = new ViewTicketHistoryOne();
            this.Hide();
            op.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewPremiumTicket viewPremiumTicket = new ViewPremiumTicket();
            viewPremiumTicket.Show();
            this.Hide();
        }
    }
}
