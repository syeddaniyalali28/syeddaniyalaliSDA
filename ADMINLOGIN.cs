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
    public partial class ADMINLOGIN : Form
    {


        public ADMINLOGIN()
        {
            InitializeComponent();
        }


        private void ADMINLOGIN_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MAIN f2 = new MAIN();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if ((admin_un.Text == "ADMIN") && (admin_pass.Text == "ADMIN"))
            {
                this.Hide();
                ADMIN_DASHBOARD ad = new ADMIN_DASHBOARD();
                ad.Show();

            }
            else
            {
                MessageBox.Show("  YOU ENTERED INVALID USERNAME OR PASSWORD...! \n  TRY AGAIN...!", "INVALID CREDENTIALS...!", MessageBoxButtons.OK);

            }

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MAIN f2 = new MAIN();
            f2.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            admin_pass.PasswordChar = '*';
            admin_pass.MaxLength = 8;
            string passs = admin_pass.Text;



        }

        private void admin_un_TextChanged(object sender, EventArgs e)
        {
            string un = admin_un.Text;
        }
    }
}
