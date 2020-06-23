using System;
using System.Windows.Forms;

namespace BRS
{
    public partial class ADMIN_DASHBOARD : Form
    {
        public ADMIN_DASHBOARD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            BusReservation adrm = new BusReservation();
            adrm.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to logout ?", "LOGING OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ADMIN_LOGIN al = new ADMIN_LOGIN();
                al.Show();
                this.Hide();

            }
            else
            {
                this.Activate();
            }
            
        }

        private void addBusButton_Click(object sender, EventArgs e)
        {
            AddBus busForm = new AddBus();
            busForm.Show();
            this.Hide();

        }
        
        private void button1_Click_2(object sender, EventArgs e)
        {
            ShowRecords bookingForm = new ShowRecords("Reservation");
            bookingForm.Show();
            this.Hide();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            AddRoute routeForm = new AddRoute();
            routeForm.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            AddBus addBusForm = new AddBus();
            addBusForm.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowRecords records = new ShowRecords("Bus");
            records.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowRecords records = new ShowRecords("Route");
            records.Show();
            this.Hide();
        }
    }
}
