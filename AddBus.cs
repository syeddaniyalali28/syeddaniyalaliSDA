using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BRS.SupportClasses;

namespace BRS
{
    public partial class AddBus : Form
    {
        private List<Route> routes;

        public AddBus()
        {
            InitializeComponent();
        }

        private void AddBus_Load(object sender, EventArgs e)
        {
           routes = Database.GetRoutesList();
            for (int i = 0; i < routes.Count; i++)
            {
                routesComboBox.Items.Add(routes[i]);
            }
            routesComboBox.SelectedIndex = 0;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_DASHBOARD dashboard = new ADMIN_DASHBOARD();
            dashboard.Show();
        }

        private void AddBusButton_Click(object sender, EventArgs e)
        {
            if (routesComboBox.SelectedIndex == -1
                || string.IsNullOrEmpty(fareTextBox.Text))
            {
                MessageBox.Show("Please fill in all the fields!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool isAc = false;
                if (AcAvaliableCheckBox.Checked)
                {
                    isAc = true;
                }
                else
                {
                    isAc = false;
                }

                Route route = routes[routesComboBox.SelectedIndex];

                Bus bus = new Bus(Database.getBID()+1, isAc, Convert.ToInt32(fareTextBox.Text.ToString()), BusDepDateTimePicker.Text, BusArrivalDateTimePicker.Text, route.Origin, route.Destination);

                string message = "Bus added Successfully";

                bool isAdded = bus.addRecord();

                if (isAdded)
                {
                    routesComboBox.SelectedIndex = -1;
                    BusDepDateTimePicker.ResetText();
                    BusArrivalDateTimePicker.ResetText();
                    fareTextBox.Text = "";
                    AcAvaliableCheckBox.Checked = false;
                    MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_DASHBOARD dashboard = new ADMIN_DASHBOARD();
            dashboard.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_DASHBOARD ad=new ADMIN_DASHBOARD();
            ad.Show();
        }
    }
}
