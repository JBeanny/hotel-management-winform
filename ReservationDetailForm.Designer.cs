namespace HotelManagement
{
    partial class ReservationDetailForm
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
            payment = new Label();
            label1 = new Label();
            label7 = new Label();
            guestNationalId = new Label();
            groupBox2 = new GroupBox();
            guestSex = new Label();
            guestPhone = new Label();
            guestName = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label9 = new Label();
            chargeFee = new Label();
            roomName = new Label();
            groupBox3 = new GroupBox();
            label2 = new Label();
            reservationIdLabel = new Label();
            groupBox1 = new GroupBox();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // payment
            // 
            payment.Location = new Point(194, 299);
            payment.Name = "payment";
            payment.Size = new Size(100, 23);
            payment.TabIndex = 21;
            payment.Text = "0";
            payment.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Reservation Id:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 303);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 20;
            label7.Text = "Payment:";
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 24);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 1;
            label9.Text = "Name:";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 50);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 2;
            label2.Text = "Charge fee ($/day):";
            // 
            // reservationIdLabel
            // 
            reservationIdLabel.Location = new Point(188, 24);
            reservationIdLabel.Name = "reservationIdLabel";
            reservationIdLabel.Size = new Size(100, 23);
            reservationIdLabel.TabIndex = 11;
            reservationIdLabel.Text = "0";
            reservationIdLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(reservationIdLabel);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 283);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reservation Detail";
            // 
            // ReservationDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 332);
            Controls.Add(payment);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(336, 371);
            MinimizeBox = false;
            MinimumSize = new Size(336, 371);
            Name = "ReservationDetailForm";
            ShowIcon = false;
            Text = "ReservationDetailForm";
            Load += InitialLoad;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label payment;
        private Label label1;
        private Label label7;
        private Label guestNationalId;
        private GroupBox groupBox2;
        private Label guestSex;
        private Label guestPhone;
        private Label guestName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label9;
        private Label chargeFee;
        private Label roomName;
        private GroupBox groupBox3;
        private Label label2;
        private Label reservationIdLabel;
        private GroupBox groupBox1;
    }
}