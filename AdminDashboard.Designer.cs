namespace BRS
{
    partial class ADMIN_DASHBOARD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN_DASHBOARD));
            this.screen = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.dash_panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.make_rides = new System.Windows.Forms.Button();
            this.picture_panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.screen.SuspendLayout();
            this.dash_panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("screen.BackgroundImage")));
            this.screen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.screen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.screen.Controls.Add(this.logout);
            this.screen.Controls.Add(this.dash_panel1);
            this.screen.Controls.Add(this.picture_panel2);
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(50, 50);
            this.screen.Name = "screen";
            this.screen.Padding = new System.Windows.Forms.Padding(100, 50, 100, 0);
            this.screen.Size = new System.Drawing.Size(908, 581);
            this.screen.TabIndex = 0;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout.BackgroundImage")));
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Location = new System.Drawing.Point(1, 1);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(79, 62);
            this.logout.TabIndex = 18;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // dash_panel1
            // 
            this.dash_panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dash_panel1.BackColor = System.Drawing.Color.Transparent;
            this.dash_panel1.Controls.Add(this.button5);
            this.dash_panel1.Controls.Add(this.button4);
            this.dash_panel1.Controls.Add(this.button3);
            this.dash_panel1.Controls.Add(this.button2);
            this.dash_panel1.Controls.Add(this.button1);
            this.dash_panel1.Controls.Add(this.make_rides);
            this.dash_panel1.Location = new System.Drawing.Point(1, 106);
            this.dash_panel1.Name = "dash_panel1";
            this.dash_panel1.Size = new System.Drawing.Size(528, 468);
            this.dash_panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.Location = new System.Drawing.Point(74, 305);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 45);
            this.button4.TabIndex = 7;
            this.button4.Text = "SHOW BUSES";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.Location = new System.Drawing.Point(74, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 45);
            this.button3.TabIndex = 6;
            this.button3.Text = "ADD BUS";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(74, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "ADD ROUTES";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(74, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "SHOW BOOKINGS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // make_rides
            // 
            this.make_rides.AutoSize = true;
            this.make_rides.BackColor = System.Drawing.SystemColors.HotTrack;
            this.make_rides.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.make_rides.Cursor = System.Windows.Forms.Cursors.Hand;
            this.make_rides.FlatAppearance.BorderSize = 0;
            this.make_rides.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.make_rides.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.make_rides.ForeColor = System.Drawing.SystemColors.Desktop;
            this.make_rides.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.make_rides.Location = new System.Drawing.Point(74, 50);
            this.make_rides.Name = "make_rides";
            this.make_rides.Size = new System.Drawing.Size(203, 45);
            this.make_rides.TabIndex = 1;
            this.make_rides.Text = "MAKE RIDES";
            this.make_rides.UseVisualStyleBackColor = false;
            this.make_rides.Click += new System.EventHandler(this.button1_Click);
            // 
            // picture_panel2
            // 
            this.picture_panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_panel2.AutoSize = true;
            this.picture_panel2.BackColor = System.Drawing.Color.Transparent;
            this.picture_panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_panel2.BackgroundImage")));
            this.picture_panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_panel2.Location = new System.Drawing.Point(131, 76);
            this.picture_panel2.Name = "picture_panel2";
            this.picture_panel2.Size = new System.Drawing.Size(729, 418);
            this.picture_panel2.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.Location = new System.Drawing.Point(74, 254);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(203, 45);
            this.button5.TabIndex = 8;
            this.button5.Text = "SHOW ROUTES";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ADMIN_DASHBOARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.screen);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADMIN_DASHBOARD";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN_DASHBOARD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.screen.ResumeLayout(false);
            this.screen.PerformLayout();
            this.dash_panel1.ResumeLayout(false);
            this.dash_panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.Panel dash_panel1;
        private System.Windows.Forms.Panel picture_panel2;
        private System.Windows.Forms.Button make_rides;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}