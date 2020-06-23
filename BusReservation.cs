using BRS.SupportClasses;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BRS
{
    public partial class BusReservation : Form
    {
        private List<Route> originList;
        bool isAcAvailable = false;
        public BusReservation()
        {
            InitializeComponent();
        }

        private void admin_ridemaker_Load(object sender, EventArgs e)
        {
            originList = Database.GetRoutesList();


            if (originComboBox.Items.Count != 0)
            {
                originComboBox.Items.Clear();
            }

            for (int j = 0; j < originList.Count; j++)
            {
                if (!originComboBox.Items.Contains(originList[j].Origin))
                {
                    originComboBox.Items.Add(originList[j].Origin);
                }
            }
            //  originComboBox.SelectedIndex = 0;
        }

        private void back_Click(object sender, EventArgs e)
        {

            ADMIN_DASHBOARD ad = new ADMIN_DASHBOARD();
            ad.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            ADMIN_DASHBOARD ad = new ADMIN_DASHBOARD();
            ad.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (originComboBox.SelectedIndex == -1 || destinationComboBox.SelectedIndex == -1
                || string.IsNullOrEmpty(passengerNameTextBox.Text)
                || string.IsNullOrEmpty(passengerNicTextBox.Text)
                || string.IsNullOrEmpty(passengerEmailTextBox.Text)
                || busIdComboBox.SelectedIndex == -1
                || string.IsNullOrEmpty(seatNoTextBox.Text))
            {
                MessageBox.Show("Please fill in all the fields!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Reservation reserv = new Reservation(Database.getRID() + 1, passengerNameTextBox.Text, passengerEmailTextBox.Text, passengerNicTextBox.Text, int.Parse(busIdComboBox.SelectedItem.ToString()), reservationDateTimePicker.Text, Convert.ToInt32(seatNoTextBox.Text.ToString()));
                string message = "Reservation Done";

                if (reserv.addRecord())
                {
                    passengerNicTextBox.Text = "";
                    passengerNameTextBox.Text = "";
                    passengerEmailTextBox.Text = "";
                    seatNoTextBox.Text = "";
                    originComboBox.SelectedIndex = -1;
                    destinationComboBox.SelectedIndex = -1;
                    FareLabel.Text = "";
                    MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void busIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int fare = 0;
            if (busIdComboBox.SelectedIndex != -1)
            {
                fare = Database.GetBussesList()[Convert.ToInt32(busIdComboBox.SelectedItem.ToString()) - 1].Fare;
            }
            FareLabel.Text = "" + fare;
        }

        private void originComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            destinationComboBox.SelectedIndex = -1;

            List<Route> destinationList = Database.GetRoutesList();

            if (destinationComboBox.Items.Count != 0)
            {
                destinationComboBox.Items.Clear();
            }

            for (int k = 0; k < destinationList.Count; k++)
            {
                if (destinationList[k].Origin.Equals(originComboBox.SelectedItem))
                {
                    if (!destinationComboBox.Items.Contains(destinationList[k].Destination))
                    {
                        destinationComboBox.Items.Add(destinationList[k].Destination);
                    }
                }
            }
           // destinationComboBox.SelectedItem = 0;
        }
        
        private void acCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (acCheckBox.Checked)
            {
                isAcAvailable = true;
            }
            else { isAcAvailable = false; }

            List<Bus> busList = Database.GetBussesList();
            FareLabel.Text = "";
            busIdComboBox.SelectedIndex = -1;

            if (busIdComboBox.Items.Count != 0)
            {
                busIdComboBox.Items.Clear();
            }

            for (int i = 0; i < busList.Count; i++)
            {
                if (busList[i].AC == isAcAvailable && busList[i].Origin.Equals(originComboBox.SelectedItem)
                    && busList[i].Destination.Equals(destinationComboBox.SelectedItem))
                {
                    busIdComboBox.Items.Add(busList[i].ID);
                }
            }
          //  busIdComboBox.SelectedIndex = 0;
        }

        private void destinationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            acCheckBox.Checked = false;
            busIdComboBox.SelectedIndex = -1;

            List<Bus> busList = Database.GetBussesList();

            for (int i = 0; i < busList.Count; i++)
            {
                if (busList[i].AC == isAcAvailable && busList[i].Origin.Equals(originComboBox.SelectedItem)
                    && busList[i].Destination.Equals(destinationComboBox.SelectedItem))
                {
                    busIdComboBox.Items.Add(busList[i].ID);
                }
            }
        }
    }
}
