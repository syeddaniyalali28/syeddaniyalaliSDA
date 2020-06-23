using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;
using BRS.SupportClasses;

namespace BRS
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
            Database.ReadBussesData();
            Database.ReadReservationData();
            Database.ReadRoutesData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ADMIN_LOGIN l2 = new ADMIN_LOGIN();
            l2.Show();
            this.Hide();

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will close down the whole application. Do you want to continue ?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                Activate();
            }
        }
    }
}
