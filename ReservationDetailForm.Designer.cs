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
            reservationId = new Label();
            groupBox1 = new GroupBox();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // payment
            // 
            payment.Location = new Point(277, 498);
            payment.Margin = new Padding(4, 0, 4, 0);
            payment.Name = "payment";
            payment.Size = new Size(143, 38);
            payment.TabIndex = 21;
            payment.Text = "0";
            payment.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 0;
            label1.Text = "Reservation Id:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(17, 505);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(92, 25);
            label7.TabIndex = 20;
            label7.Text = "Payment:";
            // 
            // guestNationalId
            // 
            guestNationalId.Location = new Point(251, 173);
            guestNationalId.Margin = new Padding(4, 0, 4, 0);
            guestNationalId.Name = "guestNationalId";
            guestNationalId.Size = new Size(143, 38);
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
            groupBox2.Location = new Point(9, 88);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(403, 223);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Guest Information";
            // 
            // guestSex
            // 
            guestSex.Location = new Point(251, 127);
            guestSex.Margin = new Padding(4, 0, 4, 0);
            guestSex.Name = "guestSex";
            guestSex.Size = new Size(143, 38);
            guestSex.TabIndex = 14;
            guestSex.Text = "0";
            guestSex.TextAlign = ContentAlignment.MiddleRight;
            // 
            // guestPhone
            // 
            guestPhone.Location = new Point(251, 78);
            guestPhone.Margin = new Padding(4, 0, 4, 0);
            guestPhone.Name = "guestPhone";
            guestPhone.Size = new Size(143, 38);
            guestPhone.TabIndex = 13;
            guestPhone.Text = "0";
            guestPhone.TextAlign = ContentAlignment.MiddleRight;
            // 
            // guestName
            // 
            guestName.Location = new Point(251, 27);
            guestName.Margin = new Padding(4, 0, 4, 0);
            guestName.Name = "guestName";
            guestName.Size = new Size(143, 38);
            guestName.TabIndex = 12;
            guestName.Text = "0";
            guestName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 180);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(34, 25);
            label6.TabIndex = 8;
            label6.Text = "ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 133);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(43, 25);
            label5.TabIndex = 6;
            label5.Text = "Sex:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 85);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 3;
            label4.Text = "Phone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 40);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 1;
            label3.Text = "Name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 40);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(63, 25);
            label9.TabIndex = 1;
            label9.Text = "Name:";
            // 
            // chargeFee
            // 
            chargeFee.Location = new Point(251, 77);
            chargeFee.Margin = new Padding(4, 0, 4, 0);
            chargeFee.Name = "chargeFee";
            chargeFee.Size = new Size(143, 38);
            chargeFee.TabIndex = 17;
            chargeFee.Text = "0";
            chargeFee.TextAlign = ContentAlignment.MiddleRight;
            // 
            // roomName
            // 
            roomName.Location = new Point(251, 33);
            roomName.Margin = new Padding(4, 0, 4, 0);
            roomName.Name = "roomName";
            roomName.Size = new Size(143, 38);
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
            groupBox3.Location = new Point(9, 325);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(403, 137);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Room Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 83);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(162, 25);
            label2.TabIndex = 2;
            label2.Text = "Charge fee ($/day):";
            // 
            // reservationId
            // 
            reservationId.Location = new Point(269, 40);
            reservationId.Margin = new Padding(4, 0, 4, 0);
            reservationId.Name = "reservationId";
            reservationId.Size = new Size(143, 38);
            reservationId.TabIndex = 11;
            reservationId.Text = "0";
            reservationId.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(reservationId);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(17, 20);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(420, 472);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reservation Detail";
            // 
            // ReservationDetailForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 537);
            Controls.Add(payment);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(473, 593);
            MinimizeBox = false;
            MinimumSize = new Size(473, 593);
            Name = "ReservationDetailForm";
            ShowIcon = false;
            Text = "ReservationDetailForm";
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
        private Label reservationId;
        private GroupBox groupBox1;
    }
}