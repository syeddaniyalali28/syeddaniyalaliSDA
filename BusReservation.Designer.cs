namespace BRS
{
    partial class BusReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusReservation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.acCheckBox = new System.Windows.Forms.CheckBox();
            this.destinationComboBox = new System.Windows.Forms.ComboBox();
            this.originComboBox = new System.Windows.Forms.ComboBox();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.originLabel = new System.Windows.Forms.Label();
            this.FareLabel = new System.Windows.Forms.Label();
            this.FareTitleLabel = new System.Windows.Forms.Label();
            this.seatNoTextBox = new System.Windows.Forms.TextBox();
            this.SeatNoLabel = new System.Windows.Forms.Label();
            this.reservationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reservationDateLabel = new System.Windows.Forms.Label();
            this.busIdComboBox = new System.Windows.Forms.ComboBox();
            this.BusIDLabel = new System.Windows.Forms.Label();
            this.passengerNicTextBox = new System.Windows.Forms.TextBox();
            this.PassengerNicLabel = new System.Windows.Forms.Label();
            this.passengerEmailTextBox = new System.Windows.Forms.TextBox();
            this.passengerNameTextBox = new System.Windows.Forms.TextBox();
            this.passengerEmailLabel = new System.Windows.Forms.Label();
            this.passengerNameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(67, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panel1.Size = new System.Drawing.Size(1210, 714);
            this.panel1.TabIndex = 0;
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
            this.panel3.Size = new System.Drawing.Size(1210, 92);
            this.panel3.TabIndex = 16;
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
            this.label1.Size = new System.Drawing.Size(419, 67);
            this.label1.TabIndex = 13;
            this.label1.Text = "RIDE MAKER";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.acCheckBox);
            this.panel2.Controls.Add(this.destinationComboBox);
            this.panel2.Controls.Add(this.originComboBox);
            this.panel2.Controls.Add(this.destinationLabel);
            this.panel2.Controls.Add(this.originLabel);
            this.panel2.Controls.Add(this.FareLabel);
            this.panel2.Controls.Add(this.FareTitleLabel);
            this.panel2.Controls.Add(this.seatNoTextBox);
            this.panel2.Controls.Add(this.SeatNoLabel);
            this.panel2.Controls.Add(this.reservationDateTimePicker);
            this.panel2.Controls.Add(this.reservationDateLabel);
            this.panel2.Controls.Add(this.busIdComboBox);
            this.panel2.Controls.Add(this.BusIDLabel);
            this.panel2.Controls.Add(this.passengerNicTextBox);
            this.panel2.Controls.Add(this.PassengerNicLabel);
            this.panel2.Controls.Add(this.passengerEmailTextBox);
            this.panel2.Controls.Add(this.passengerNameTextBox);
            this.panel2.Controls.Add(this.passengerEmailLabel);
            this.panel2.Controls.Add(this.passengerNameLabel);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(39, 146);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 539);
            this.panel2.TabIndex = 15;
            // 
            // acCheckBox
            // 
            this.acCheckBox.AutoSize = true;
            this.acCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acCheckBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.acCheckBox.Location = new System.Drawing.Point(260, 270);
            this.acCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.acCheckBox.Name = "acCheckBox";
            this.acCheckBox.Size = new System.Drawing.Size(69, 33);
            this.acCheckBox.TabIndex = 37;
            this.acCheckBox.Text = "AC";
            this.acCheckBox.UseVisualStyleBackColor = true;
            this.acCheckBox.CheckedChanged += new System.EventHandler(this.acCheckBox_CheckedChanged);
            // 
            // destinationComboBox
            // 
            this.destinationComboBox.FormattingEnabled = true;
            this.destinationComboBox.Location = new System.Drawing.Point(584, 69);
            this.destinationComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.destinationComboBox.Name = "destinationComboBox";
            this.destinationComboBox.Size = new System.Drawing.Size(308, 24);
            this.destinationComboBox.TabIndex = 35;
            this.destinationComboBox.SelectedIndexChanged += new System.EventHandler(this.destinationComboBox_SelectedIndexChanged);
            // 
            // originComboBox
            // 
            this.originComboBox.FormattingEnabled = true;
            this.originComboBox.Location = new System.Drawing.Point(584, 25);
            this.originComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.originComboBox.Name = "originComboBox";
            this.originComboBox.Size = new System.Drawing.Size(308, 24);
            this.originComboBox.TabIndex = 34;
            this.originComboBox.SelectedIndexChanged += new System.EventHandler(this.originComboBox_SelectedIndexChanged);
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.destinationLabel.Location = new System.Drawing.Point(256, 73);
            this.destinationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(144, 29);
            this.destinationLabel.TabIndex = 33;
            this.destinationLabel.Text = "Destination";
            // 
            // originLabel
            // 
            this.originLabel.AutoSize = true;
            this.originLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.originLabel.Location = new System.Drawing.Point(256, 25);
            this.originLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(85, 29);
            this.originLabel.TabIndex = 32;
            this.originLabel.Text = "Origin";
            // 
            // FareLabel
            // 
            this.FareLabel.AutoSize = true;
            this.FareLabel.Location = new System.Drawing.Point(580, 420);
            this.FareLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FareLabel.Name = "FareLabel";
            this.FareLabel.Size = new System.Drawing.Size(0, 17);
            this.FareLabel.TabIndex = 31;
            // 
            // FareTitleLabel
            // 
            this.FareTitleLabel.AutoSize = true;
            this.FareTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FareTitleLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FareTitleLabel.Location = new System.Drawing.Point(256, 420);
            this.FareTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FareTitleLabel.Name = "FareTitleLabel";
            this.FareTitleLabel.Size = new System.Drawing.Size(80, 29);
            this.FareTitleLabel.TabIndex = 30;
            this.FareTitleLabel.Text = "FARE";
            // 
            // seatNoTextBox
            // 
            this.seatNoTextBox.Location = new System.Drawing.Point(584, 374);
            this.seatNoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.seatNoTextBox.Name = "seatNoTextBox";
            this.seatNoTextBox.Size = new System.Drawing.Size(308, 22);
            this.seatNoTextBox.TabIndex = 29;
            // 
            // SeatNoLabel
            // 
            this.SeatNoLabel.AutoSize = true;
            this.SeatNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatNoLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SeatNoLabel.Location = new System.Drawing.Point(256, 378);
            this.SeatNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SeatNoLabel.Name = "SeatNoLabel";
            this.SeatNoLabel.Size = new System.Drawing.Size(126, 29);
            this.SeatNoLabel.TabIndex = 28;
            this.SeatNoLabel.Text = "SEAT NO";
            // 
            // reservationDateTimePicker
            // 
            this.reservationDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reservationDateTimePicker.Location = new System.Drawing.Point(584, 320);
            this.reservationDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.reservationDateTimePicker.Name = "reservationDateTimePicker";
            this.reservationDateTimePicker.Size = new System.Drawing.Size(308, 22);
            this.reservationDateTimePicker.TabIndex = 27;
            // 
            // reservationDateLabel
            // 
            this.reservationDateLabel.AutoSize = true;
            this.reservationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationDateLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.reservationDateLabel.Location = new System.Drawing.Point(256, 327);
            this.reservationDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reservationDateLabel.Name = "reservationDateLabel";
            this.reservationDateLabel.Size = new System.Drawing.Size(213, 29);
            this.reservationDateLabel.TabIndex = 26;
            this.reservationDateLabel.Text = "Reservation Date";
            // 
            // busIdComboBox
            // 
            this.busIdComboBox.FormattingEnabled = true;
            this.busIdComboBox.Location = new System.Drawing.Point(773, 265);
            this.busIdComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.busIdComboBox.Name = "busIdComboBox";
            this.busIdComboBox.Size = new System.Drawing.Size(119, 24);
            this.busIdComboBox.TabIndex = 25;
            this.busIdComboBox.SelectedIndexChanged += new System.EventHandler(this.busIdComboBox_SelectedIndexChanged);
            // 
            // BusIDLabel
            // 
            this.BusIDLabel.AutoSize = true;
            this.BusIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusIDLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BusIDLabel.Location = new System.Drawing.Point(580, 268);
            this.BusIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BusIDLabel.Name = "BusIDLabel";
            this.BusIDLabel.Size = new System.Drawing.Size(89, 29);
            this.BusIDLabel.TabIndex = 24;
            this.BusIDLabel.Text = "Bus ID";
            // 
            // passengerNicTextBox
            // 
            this.passengerNicTextBox.Location = new System.Drawing.Point(584, 210);
            this.passengerNicTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passengerNicTextBox.Name = "passengerNicTextBox";
            this.passengerNicTextBox.Size = new System.Drawing.Size(308, 22);
            this.passengerNicTextBox.TabIndex = 23;
            // 
            // PassengerNicLabel
            // 
            this.PassengerNicLabel.AutoSize = true;
            this.PassengerNicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerNicLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PassengerNicLabel.Location = new System.Drawing.Point(256, 214);
            this.PassengerNicLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PassengerNicLabel.Name = "PassengerNicLabel";
            this.PassengerNicLabel.Size = new System.Drawing.Size(189, 29);
            this.PassengerNicLabel.TabIndex = 22;
            this.PassengerNicLabel.Text = "Passenger NIC";
            // 
            // passengerEmailTextBox
            // 
            this.passengerEmailTextBox.Location = new System.Drawing.Point(584, 161);
            this.passengerEmailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passengerEmailTextBox.Name = "passengerEmailTextBox";
            this.passengerEmailTextBox.Size = new System.Drawing.Size(308, 22);
            this.passengerEmailTextBox.TabIndex = 21;
            // 
            // passengerNameTextBox
            // 
            this.passengerNameTextBox.Location = new System.Drawing.Point(584, 111);
            this.passengerNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passengerNameTextBox.Name = "passengerNameTextBox";
            this.passengerNameTextBox.Size = new System.Drawing.Size(308, 22);
            this.passengerNameTextBox.TabIndex = 20;
            // 
            // passengerEmailLabel
            // 
            this.passengerEmailLabel.AutoSize = true;
            this.passengerEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerEmailLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.passengerEmailLabel.Location = new System.Drawing.Point(256, 165);
            this.passengerEmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passengerEmailLabel.Name = "passengerEmailLabel";
            this.passengerEmailLabel.Size = new System.Drawing.Size(211, 29);
            this.passengerEmailLabel.TabIndex = 19;
            this.passengerEmailLabel.Text = "Passenger Email";
            // 
            // passengerNameLabel
            // 
            this.passengerNameLabel.AutoSize = true;
            this.passengerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.passengerNameLabel.Location = new System.Drawing.Point(256, 114);
            this.passengerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passengerNameLabel.Name = "passengerNameLabel";
            this.passengerNameLabel.Size = new System.Drawing.Size(214, 29);
            this.passengerNameLabel.TabIndex = 18;
            this.passengerNameLabel.Text = "Passenger Name";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::BRS.Properties.Resources.Confirm_Button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(616, 462);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 62);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::BRS.Properties.Resources.cancel1;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(191, 462);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(304, 62);
            this.button3.TabIndex = 17;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BusReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BRS.Properties.Resources.iwp780281584_bus_wallpapers2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 838);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BusReservation";
            this.Padding = new System.Windows.Forms.Padding(67, 62, 67, 62);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_ridemaker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.admin_ridemaker_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label passengerEmailLabel;
        private System.Windows.Forms.Label passengerNameLabel;
        private System.Windows.Forms.ComboBox busIdComboBox;
        private System.Windows.Forms.Label BusIDLabel;
        private System.Windows.Forms.TextBox passengerNicTextBox;
        private System.Windows.Forms.Label PassengerNicLabel;
        private System.Windows.Forms.TextBox passengerEmailTextBox;
        private System.Windows.Forms.TextBox passengerNameTextBox;
        private System.Windows.Forms.DateTimePicker reservationDateTimePicker;
        private System.Windows.Forms.Label reservationDateLabel;
        private System.Windows.Forms.Label SeatNoLabel;
        private System.Windows.Forms.Label FareLabel;
        private System.Windows.Forms.Label FareTitleLabel;
        private System.Windows.Forms.ComboBox destinationComboBox;
        private System.Windows.Forms.ComboBox originComboBox;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label originLabel;
        private System.Windows.Forms.CheckBox acCheckBox;
        private System.Windows.Forms.TextBox seatNoTextBox;
    }
}