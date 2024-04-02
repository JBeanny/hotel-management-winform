namespace HotelManagement
{
    partial class GuestCheckInCheckOutForm
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
            searchTextBox = new TextBox();
            label1 = new Label();
            detailPanel = new Panel();
            label11 = new Label();
            status = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            reservationId = new Label();
            groupBox3 = new GroupBox();
            chargeFee = new Label();
            roomName = new Label();
            label2 = new Label();
            label9 = new Label();
            groupBox2 = new GroupBox();
            guestNationalId = new Label();
            guestSex = new Label();
            guestPhone = new Label();
            guestName = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            payment = new Label();
            switchButton = new Button();
            detailPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(12, 27);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(221, 23);
            searchTextBox.TabIndex = 0;
            searchTextBox.KeyUp += searchTextBox_KeyUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 1;
            label1.Text = "Reservation Id";
            // 
            // detailPanel
            // 
            detailPanel.BackColor = Color.Transparent;
            detailPanel.Controls.Add(label11);
            detailPanel.Controls.Add(status);
            detailPanel.Controls.Add(button1);
            detailPanel.Controls.Add(groupBox1);
            detailPanel.Controls.Add(label8);
            detailPanel.Controls.Add(payment);
            detailPanel.Location = new Point(12, 56);
            detailPanel.Name = "detailPanel";
            detailPanel.Size = new Size(294, 405);
            detailPanel.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(225, 29, 72);
            label11.Location = new Point(0, 327);
            label11.Name = "label11";
            label11.Size = new Size(61, 21);
            label11.TabIndex = 33;
            label11.Text = "Status:";
            // 
            // status
            // 
            status.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            status.ForeColor = Color.FromArgb(22, 163, 74);
            status.Location = new Point(192, 326);
            status.Name = "status";
            status.Size = new Size(100, 23);
            status.TabIndex = 32;
            status.Text = "CHECK-IN";
            status.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(124, 58, 237);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(245, 243, 255);
            button1.Location = new Point(158, 365);
            button1.Name = "button1";
            button1.Size = new Size(136, 33);
            button1.TabIndex = 31;
            button1.Text = "Check In/Check Out";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(reservationId);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(0, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 283);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reservation Detail";
            // 
            // reservationId
            // 
            reservationId.Location = new Point(188, 24);
            reservationId.Name = "reservationId";
            reservationId.Size = new Size(100, 23);
            reservationId.TabIndex = 11;
            reservationId.Text = "0";
            reservationId.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chargeFee);
            groupBox3.Controls.Add(roomName);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(6, 195);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(282, 82);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Room Information";
            // 
            // chargeFee
            // 
            chargeFee.Location = new Point(176, 46);
            chargeFee.Name = "chargeFee";
            chargeFee.Size = new Size(100, 23);
            chargeFee.TabIndex = 17;
            chargeFee.Text = "0";
            chargeFee.TextAlign = ContentAlignment.MiddleRight;
            // 
            // roomName
            // 
            roomName.Location = new Point(176, 20);
            roomName.Name = "roomName";
            roomName.Size = new Size(100, 23);
            roomName.TabIndex = 16;
            roomName.Text = "0";
            roomName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 50);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 2;
            label2.Text = "Charge fee ($/day):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 24);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 1;
            label9.Text = "Name:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(guestNationalId);
            groupBox2.Controls.Add(guestSex);
            groupBox2.Controls.Add(guestPhone);
            groupBox2.Controls.Add(guestName);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(6, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(282, 134);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Guest Information";
            // 
            // guestNationalId
            // 
            guestNationalId.Location = new Point(176, 104);
            guestNationalId.Name = "guestNationalId";
            guestNationalId.Size = new Size(100, 23);
            guestNationalId.TabIndex = 15;
            guestNationalId.Text = "0";
            guestNationalId.TextAlign = ContentAlignment.MiddleRight;
            // 
            // guestSex
            // 
            guestSex.Location = new Point(176, 76);
            guestSex.Name = "guestSex";
            guestSex.Size = new Size(100, 23);
            guestSex.TabIndex = 14;
            guestSex.Text = "0";
            guestSex.TextAlign = ContentAlignment.MiddleRight;
            // 
            // guestPhone
            // 
            guestPhone.Location = new Point(176, 47);
            guestPhone.Name = "guestPhone";
            guestPhone.Size = new Size(100, 23);
            guestPhone.TabIndex = 13;
            guestPhone.Text = "0";
            guestPhone.TextAlign = ContentAlignment.MiddleRight;
            // 
            // guestName
            // 
            guestName.Location = new Point(176, 16);
            guestName.Name = "guestName";
            guestName.Size = new Size(100, 23);
            guestName.TabIndex = 12;
            guestName.Text = "0";
            guestName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 108);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 8;
            label6.Text = "ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 80);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 6;
            label5.Text = "Sex:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 51);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 24);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 1;
            label3.Text = "Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(6, 28);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 0;
            label7.Text = "Reservation Id:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(0, 298);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 29;
            label8.Text = "Payment:";
            // 
            // payment
            // 
            payment.Location = new Point(190, 294);
            payment.Name = "payment";
            payment.Size = new Size(100, 23);
            payment.TabIndex = 30;
            payment.Text = "0";
            payment.TextAlign = ContentAlignment.MiddleRight;
            // 
            // switchButton
            // 
            switchButton.Location = new Point(239, 26);
            switchButton.Name = "switchButton";
            switchButton.Size = new Size(67, 24);
            switchButton.TabIndex = 3;
            switchButton.Text = "Switch";
            switchButton.UseVisualStyleBackColor = true;
            switchButton.MouseClick += switchSearchType;
            // 
            // GuestCheckInCheckOutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 473);
            Controls.Add(switchButton);
            Controls.Add(detailPanel);
            Controls.Add(label1);
            Controls.Add(searchTextBox);
            MaximizeBox = false;
            MaximumSize = new Size(332, 512);
            MinimizeBox = false;
            MinimumSize = new Size(332, 512);
            Name = "GuestCheckInCheckOutForm";
            Text = "GuestCheckInCheckOut";
            detailPanel.ResumeLayout(false);
            detailPanel.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchTextBox;
        private Label label1;
        private Panel detailPanel;
        private Label label11;
        private Label status;
        private Button button1;
        private GroupBox groupBox1;
        private Label reservationId;
        private GroupBox groupBox3;
        private Label chargeFee;
        private Label roomName;
        private Label label2;
        private Label label9;
        private GroupBox groupBox2;
        private Label guestNationalId;
        private Label guestSex;
        private Label guestPhone;
        private Label guestName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label8;
        private Label payment;
        private Button switchButton;
    }
}