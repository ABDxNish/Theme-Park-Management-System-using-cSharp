using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoalingPage : Form
    {
        public LoalingPage()
        {
            InitializeComponent();
            pbar.Value = 0;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            pbar.Value += 10;
            pbar.Text = pbar.Value.ToString() + " %";

            if (pbar.Value >= 100)
            {
                timer1.Enabled = false;
                Login lg = new Login();
                this.Hide();
                lg.Show();
            }
        }

        private void pbar_Click(object sender, EventArgs e)
        {

        }
    }
}
