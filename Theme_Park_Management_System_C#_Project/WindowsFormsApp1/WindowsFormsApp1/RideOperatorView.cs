using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RideOperatorView : Form
    {
        public RideOperatorView()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RideLbs_Click(object sender, EventArgs e)
        {
            RideOperatorRideView adm = new RideOperatorRideView();
            this.Hide(); adm.Show();
        }

        private void FoodLbs_Click(object sender, EventArgs e)
        {
            RideOperatorFoodView adm = new RideOperatorFoodView();
            this.Hide(); adm.Show();
        }

        private void LogoutLbs_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }
    }
}
