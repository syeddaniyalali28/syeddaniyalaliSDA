using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRS
{
    public partial class ADMIN_DASHBOARD : Form
    {
        public ADMIN_DASHBOARD()
        {
            InitializeComponent();
        }

        private void ADMIN_DASHBOARD_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_ridemaker adrm = new admin_ridemaker();
            adrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to logout ?", "LOGING OUT", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                ADMINLOGIN al = new ADMINLOGIN();
                al.Show();
            }
            else
            {
                this.Activate();
            }
            
        }
    }
}
