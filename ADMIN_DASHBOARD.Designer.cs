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
            this.screen = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.picture_panel2 = new System.Windows.Forms.Panel();
            this.picture_panel1 = new System.Windows.Forms.Panel();
            this.dash_panel1 = new System.Windows.Forms.Panel();
            this.dash_panel2 = new System.Windows.Forms.Panel();
            this.show_bookings = new System.Windows.Forms.Button();
            this.make_rides = new System.Windows.Forms.Button();
            this.show_rides = new System.Windows.Forms.Button();
            this.screen.SuspendLayout();
            this.dash_panel1.SuspendLayout();
            this.dash_panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackgroundImage = global::BRS.Properties.Resources.large_22_32fbt7w5v7nbip2g4ad0xs;
            this.screen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.screen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.screen.Controls.Add(this.logout);
            this.screen.Controls.Add(this.picture_panel2);
            this.screen.Controls.Add(this.picture_panel1);
            this.screen.Controls.Add(this.dash_panel1);
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(50, 50);
            this.screen.Name = "screen";
            this.screen.Padding = new System.Windows.Forms.Padding(100, 50, 100, 0);
            this.screen.Size = new System.Drawing.Size(908, 581);
            this.screen.TabIndex = 0;
            this.screen.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.BackgroundImage = global::BRS.Properties.Resources.Login_5121;
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Location = new System.Drawing.Point(-2, 1);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(79, 62);
            this.logout.TabIndex = 18;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // picture_panel2
            // 
            this.picture_panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_panel2.AutoSize = true;
            this.picture_panel2.BackColor = System.Drawing.Color.Transparent;
            this.picture_panel2.BackgroundImage = global::BRS.Properties.Resources.Travel_Bus1;
            this.picture_panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_panel2.Location = new System.Drawing.Point(478, 292);
            this.picture_panel2.Name = "picture_panel2";
            this.picture_panel2.Size = new System.Drawing.Size(370, 265);
            this.picture_panel2.TabIndex = 2;
            this.picture_panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint_1);
            // 
            // picture_panel1
            // 
            this.picture_panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picture_panel1.AutoSize = true;
            this.picture_panel1.BackColor = System.Drawing.Color.Transparent;
            this.picture_panel1.BackgroundImage = global::BRS.Properties.Resources.bus_PNG8611;
            this.picture_panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_panel1.Location = new System.Drawing.Point(1, 292);
            this.picture_panel1.Name = "picture_panel1";
            this.picture_panel1.Size = new System.Drawing.Size(456, 239);
            this.picture_panel1.TabIndex = 1;
            this.picture_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // dash_panel1
            // 
            this.dash_panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dash_panel1.BackColor = System.Drawing.Color.Transparent;
            this.dash_panel1.Controls.Add(this.dash_panel2);
            this.dash_panel1.Location = new System.Drawing.Point(103, 53);
            this.dash_panel1.Name = "dash_panel1";
            this.dash_panel1.Size = new System.Drawing.Size(698, 233);
            this.dash_panel1.TabIndex = 0;
            this.dash_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dash_panel2
            // 
            this.dash_panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dash_panel2.BackgroundImage = global::BRS.Properties.Resources.blur_dock10;
            this.dash_panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dash_panel2.Controls.Add(this.show_bookings);
            this.dash_panel2.Controls.Add(this.make_rides);
            this.dash_panel2.Controls.Add(this.show_rides);
            this.dash_panel2.Location = new System.Drawing.Point(0, 35);
            this.dash_panel2.Name = "dash_panel2";
            this.dash_panel2.Size = new System.Drawing.Size(698, 198);
            this.dash_panel2.TabIndex = 0;
            this.dash_panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // show_bookings
            // 
            this.show_bookings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.show_bookings.AutoSize = true;
            this.show_bookings.BackColor = System.Drawing.Color.Transparent;
            this.show_bookings.BackgroundImage = global::BRS.Properties.Resources.online_appt_booking;
            this.show_bookings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.show_bookings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_bookings.FlatAppearance.BorderSize = 0;
            this.show_bookings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show_bookings.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_bookings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.show_bookings.Location = new System.Drawing.Point(424, 18);
            this.show_bookings.Name = "show_bookings";
            this.show_bookings.Size = new System.Drawing.Size(203, 138);
            this.show_bookings.TabIndex = 3;
            this.show_bookings.Text = "SHOW BOOKINGS";
            this.show_bookings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.show_bookings.UseVisualStyleBackColor = false;
            this.show_bookings.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // make_rides
            // 
            this.make_rides.AutoSize = true;
            this.make_rides.BackColor = System.Drawing.Color.Transparent;
            this.make_rides.BackgroundImage = global::BRS.Properties.Resources.school_bus_icons_546412;
            this.make_rides.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.make_rides.Cursor = System.Windows.Forms.Cursors.Hand;
            this.make_rides.FlatAppearance.BorderSize = 0;
            this.make_rides.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.make_rides.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.make_rides.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.make_rides.Location = new System.Drawing.Point(54, 3);
            this.make_rides.Name = "make_rides";
            this.make_rides.Size = new System.Drawing.Size(183, 153);
            this.make_rides.TabIndex = 1;
            this.make_rides.Text = "MAKE RIDES";
            this.make_rides.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.make_rides.UseVisualStyleBackColor = false;
            this.make_rides.Click += new System.EventHandler(this.button1_Click);
            // 
            // show_rides
            // 
            this.show_rides.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.show_rides.AutoSize = true;
            this.show_rides.BackColor = System.Drawing.Color.Transparent;
            this.show_rides.BackgroundImage = global::BRS.Properties.Resources.archive_icon_200x200;
            this.show_rides.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.show_rides.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_rides.FlatAppearance.BorderSize = 0;
            this.show_rides.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show_rides.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_rides.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.show_rides.Location = new System.Drawing.Point(255, 3);
            this.show_rides.Name = "show_rides";
            this.show_rides.Size = new System.Drawing.Size(153, 153);
            this.show_rides.TabIndex = 2;
            this.show_rides.Text = "SHOW RIDES";
            this.show_rides.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.show_rides.UseVisualStyleBackColor = false;
            this.show_rides.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ADMIN_DASHBOARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BRS.Properties.Resources.gradient_wallpaper_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.screen);
            this.Name = "ADMIN_DASHBOARD";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN_DASHBOARD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ADMIN_DASHBOARD_Load);
            this.screen.ResumeLayout(false);
            this.screen.PerformLayout();
            this.dash_panel1.ResumeLayout(false);
            this.dash_panel2.ResumeLayout(false);
            this.dash_panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.Panel dash_panel1;
        private System.Windows.Forms.Panel dash_panel2;
        private System.Windows.Forms.Panel picture_panel1;
        private System.Windows.Forms.Panel picture_panel2;
        private System.Windows.Forms.Button make_rides;
        private System.Windows.Forms.Button show_bookings;
        private System.Windows.Forms.Button show_rides;
        private System.Windows.Forms.Button logout;
    }
}