namespace BRS
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.admin = new System.Windows.Forms.Button();
            this.screen = new System.Windows.Forms.Panel();
            this.picture_panel = new System.Windows.Forms.Panel();
            this.picture_panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.screen.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.BackColor = System.Drawing.Color.Teal;
            this.admin.BackgroundImage = global::BRS.Properties.Resources.blue_background_314534_960_7204;
            this.admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin.FlatAppearance.BorderSize = 0;
            this.admin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admin.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.ForeColor = System.Drawing.Color.Black;
            this.admin.Location = new System.Drawing.Point(6, 89);
            this.admin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.admin.Name = "admin";
            this.admin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.admin.Size = new System.Drawing.Size(313, 80);
            this.admin.TabIndex = 0;
            this.admin.Text = "ADMIN";
            this.admin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.admin.UseVisualStyleBackColor = false;
            this.admin.Click += new System.EventHandler(this.button1_Click);
            // 
            // screen
            // 
            this.screen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.screen.BackColor = System.Drawing.SystemColors.WindowText;
            this.screen.BackgroundImage = global::BRS.Properties.Resources._1__1_3;
            this.screen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.screen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.screen.Controls.Add(this.button1);
            this.screen.Controls.Add(this.label1);
            this.screen.Controls.Add(this.picture_panel);
            this.screen.Controls.Add(this.picture_panel1);
            this.screen.Controls.Add(this.panel2);
            this.screen.Location = new System.Drawing.Point(50, 50);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(904, 577);
            this.screen.TabIndex = 4;
            // 
            // picture_panel
            // 
            this.picture_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_panel.BackColor = System.Drawing.Color.Transparent;
            this.picture_panel.BackgroundImage = global::BRS.Properties.Resources.img_tourbus;
            this.picture_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_panel.Location = new System.Drawing.Point(480, 100);
            this.picture_panel.Name = "picture_panel";
            this.picture_panel.Size = new System.Drawing.Size(422, 415);
            this.picture_panel.TabIndex = 3;
            // 
            // picture_panel1
            // 
            this.picture_panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picture_panel1.AutoSize = true;
            this.picture_panel1.BackColor = System.Drawing.Color.Transparent;
            this.picture_panel1.BackgroundImage = global::BRS.Properties.Resources.Admin12;
            this.picture_panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_panel1.Location = new System.Drawing.Point(334, 233);
            this.picture_panel1.Name = "picture_panel1";
            this.picture_panel1.Size = new System.Drawing.Size(140, 120);
            this.picture_panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.admin);
            this.panel2.Location = new System.Drawing.Point(3, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 246);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 53);
            this.label1.TabIndex = 13;
            this.label1.Text = "WELCOME TO BRS";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoEllipsis = true;
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::BRS.Properties.Resources.exit_button_svg_0;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(826, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(68, 62);
            this.button1.TabIndex = 1;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::BRS.Properties.Resources.iwp780281584_bus_wallpapers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 677);
            this.Controls.Add(this.screen);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WELCOME TO BRS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.screen.ResumeLayout(false);
            this.screen.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel picture_panel1;
        private System.Windows.Forms.Panel picture_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

