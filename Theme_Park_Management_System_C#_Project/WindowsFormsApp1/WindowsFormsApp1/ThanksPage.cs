using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ThanksPage : Form
    {
        public ThanksPage(string UserName)
        {
            GivenName = UserName;
            InitializeComponent();
        }

        public ThanksPage(string UserName, string Details)
        {
            GivenName = UserName;
            InitializeComponent();
            TicketBox.Text = Details;
        }

        private string GivenName { get; set; }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            UserPanelOne usp = new UserPanelOne(GivenName);
            this.Hide();
            usp.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ThanksPage_Load(object sender, EventArgs e)
        {

        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(TicketBox.Width, TicketBox.Height);
            TicketBox.DrawToBitmap(bitmap, new Rectangle(0, 0, TicketBox.Width, TicketBox.Height));


            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PNG Image|*.png",
                DefaultExt = "png"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(saveFileDialog.FileName);
                MessageBox.Show("Ticket Saved");
            }
        }

    }
}
