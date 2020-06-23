namespace BRS
{
    partial class AddBus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBus));
            this.AcAvaliableCheckBox = new System.Windows.Forms.CheckBox();
            this.routesComboBox = new System.Windows.Forms.ComboBox();
            this.BusDepDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BusArrivalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fareTextBox = new System.Windows.Forms.TextBox();
            this.add_bus = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_un = new System.Windows.Forms.Label();
            this.cencel = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.add_bus.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AcAvaliableCheckBox
            // 
            this.AcAvaliableCheckBox.AutoSize = true;
            this.AcAvaliableCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.AcAvaliableCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcAvaliableCheckBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AcAvaliableCheckBox.Location = new System.Drawing.Point(436, 453);
            this.AcAvaliableCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.AcAvaliableCheckBox.Name = "AcAvaliableCheckBox";
            this.AcAvaliableCheckBox.Size = new System.Drawing.Size(69, 33);
            this.AcAvaliableCheckBox.TabIndex = 1;
            this.AcAvaliableCheckBox.Text = "AC";
            this.AcAvaliableCheckBox.UseVisualStyleBackColor = false;
            // 
            // routesComboBox
            // 
            this.routesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.routesComboBox.FormattingEnabled = true;
            this.routesComboBox.Location = new System.Drawing.Point(500, 220);
            this.routesComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.routesComboBox.Name = "routesComboBox";
            this.routesComboBox.Size = new System.Drawing.Size(614, 24);
            this.routesComboBox.TabIndex = 2;
            // 
            // BusDepDateTimePicker
            // 
            this.BusDepDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BusDepDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.BusDepDateTimePicker.Location = new System.Drawing.Point(500, 338);
            this.BusDepDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.BusDepDateTimePicker.Name = "BusDepDateTimePicker";
            this.BusDepDateTimePicker.ShowUpDown = true;
            this.BusDepDateTimePicker.Size = new System.Drawing.Size(614, 22);
            this.BusDepDateTimePicker.TabIndex = 5;
            // 
            // BusArrivalDateTimePicker
            // 
            this.BusArrivalDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BusArrivalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.BusArrivalDateTimePicker.Location = new System.Drawing.Point(500, 405);
            this.BusArrivalDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.BusArrivalDateTimePicker.Name = "BusArrivalDateTimePicker";
            this.BusArrivalDateTimePicker.ShowUpDown = true;
            this.BusArrivalDateTimePicker.Size = new System.Drawing.Size(614, 22);
            this.BusArrivalDateTimePicker.TabIndex = 8;
            // 
            // fareTextBox
            // 
            this.fareTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fareTextBox.Location = new System.Drawing.Point(500, 276);
            this.fareTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fareTextBox.Name = "fareTextBox";
            this.fareTextBox.Size = new System.Drawing.Size(614, 22);
            this.fareTextBox.TabIndex = 11;
            // 
            // add_bus
            // 
            this.add_bus.BackgroundImage = global::BRS.Properties.Resources._1;
            this.add_bus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_bus.Controls.Add(this.panel3);
            this.add_bus.Controls.Add(this.label7);
            this.add_bus.Controls.Add(this.label6);
            this.add_bus.Controls.Add(this.label3);
            this.add_bus.Controls.Add(this.label_un);
            this.add_bus.Controls.Add(this.cencel);
            this.add_bus.Controls.Add(this.add);
            this.add_bus.Controls.Add(this.fareTextBox);
            this.add_bus.Controls.Add(this.BusArrivalDateTimePicker);
            this.add_bus.Controls.Add(this.BusDepDateTimePicker);
            this.add_bus.Controls.Add(this.routesComboBox);
            this.add_bus.Controls.Add(this.AcAvaliableCheckBox);
            this.add_bus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_bus.Location = new System.Drawing.Point(67, 62);
            this.add_bus.Margin = new System.Windows.Forms.Padding(4);
            this.add_bus.Name = "add_bus";
            this.add_bus.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.add_bus.Size = new System.Drawing.Size(1210, 714);
            this.add_bus.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.back);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1218, 92);
            this.panel3.TabIndex = 22;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImage = global::BRS.Properties.Resources.back_arrow;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Location = new System.Drawing.Point(4, 7);
            this.back.Margin = new System.Windows.Forms.Padding(4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(117, 85);
            this.back.TabIndex = 18;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(611, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 67);
            this.label1.TabIndex = 13;
            this.label1.Text = "ROUTE MAKER";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(169, 400);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 29);
            this.label7.TabIndex = 21;
            this.label7.Text = "ARRIVAL TIME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(169, 334);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "DEPARTURE TIME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(169, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "FARE";
            // 
            // label_un
            // 
            this.label_un.AutoSize = true;
            this.label_un.BackColor = System.Drawing.Color.Transparent;
            this.label_un.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_un.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_un.Location = new System.Drawing.Point(169, 217);
            this.label_un.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_un.Name = "label_un";
            this.label_un.Size = new System.Drawing.Size(103, 29);
            this.label_un.TabIndex = 13;
            this.label_un.Text = "ROUTE";
            // 
            // cencel
            // 
            this.cencel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cencel.BackColor = System.Drawing.Color.Transparent;
            this.cencel.BackgroundImage = global::BRS.Properties.Resources.cancel1;
            this.cencel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cencel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cencel.FlatAppearance.BorderSize = 0;
            this.cencel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cencel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cencel.Location = new System.Drawing.Point(622, 527);
            this.cencel.Margin = new System.Windows.Forms.Padding(4);
            this.cencel.Name = "cencel";
            this.cencel.Size = new System.Drawing.Size(247, 65);
            this.cencel.TabIndex = 18;
            this.cencel.UseVisualStyleBackColor = false;
            this.cencel.Click += new System.EventHandler(this.button2_Click);
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.add.BackgroundImage = global::BRS.Properties.Resources.add_button_png_md;
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Location = new System.Drawing.Point(182, 527);
            this.add.Margin = new System.Windows.Forms.Padding(4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(247, 65);
            this.add.TabIndex = 17;
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.AddBusButton_Click);
            // 
            // AddBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BRS.Properties.Resources.iwp780281584_bus_wallpapers2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 838);
            this.Controls.Add(this.add_bus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddBus";
            this.Padding = new System.Windows.Forms.Padding(67, 62, 67, 62);
            this.ShowIcon = false;
            this.Text = "AddBus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddBus_Load);
            this.add_bus.ResumeLayout(false);
            this.add_bus.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker BusDepDateTimePicker;
        private System.Windows.Forms.DateTimePicker BusArrivalDateTimePicker;
        private System.Windows.Forms.ComboBox routesComboBox;
        private System.Windows.Forms.CheckBox AcAvaliableCheckBox;
        private System.Windows.Forms.TextBox fareTextBox;
        private System.Windows.Forms.Panel add_bus;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button cencel;
        private System.Windows.Forms.Label label_un;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
    }
}