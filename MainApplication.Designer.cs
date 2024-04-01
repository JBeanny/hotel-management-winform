namespace HotelManagement
{
    partial class MainApplication
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            reservationLabel = new Label();
            label1 = new Label();
            panel2 = new Panel();
            availableRoomLabel = new Label();
            label3 = new Label();
            panel3 = new Panel();
            roomLabel = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            selectedDatePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(55, 65, 81);
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 108);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(reservationLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(56, 172);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4);
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 1;
            // 
            // reservationLabel
            // 
            reservationLabel.Dock = DockStyle.Fill;
            reservationLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            reservationLabel.Location = new Point(4, 25);
            reservationLabel.Name = "reservationLabel";
            reservationLabel.Size = new Size(192, 71);
            reservationLabel.TabIndex = 1;
            reservationLabel.Text = "0";
            reservationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(4, 4);
            label1.Name = "label1";
            label1.Size = new Size(192, 21);
            label1.TabIndex = 0;
            label1.Text = "Reservation";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(availableRoomLabel);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(296, 172);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(4);
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 2;
            // 
            // availableRoomLabel
            // 
            availableRoomLabel.Dock = DockStyle.Fill;
            availableRoomLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            availableRoomLabel.Location = new Point(4, 25);
            availableRoomLabel.Name = "availableRoomLabel";
            availableRoomLabel.Size = new Size(192, 71);
            availableRoomLabel.TabIndex = 1;
            availableRoomLabel.Text = "0";
            availableRoomLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(4, 4);
            label3.Name = "label3";
            label3.Size = new Size(192, 21);
            label3.TabIndex = 0;
            label3.Text = "Available Rooms";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(roomLabel);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(534, 172);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(4);
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 3;
            // 
            // roomLabel
            // 
            roomLabel.Dock = DockStyle.Fill;
            roomLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            roomLabel.Location = new Point(4, 25);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new Size(192, 71);
            roomLabel.TabIndex = 1;
            roomLabel.Text = "0";
            roomLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(4, 4);
            label5.Name = "label5";
            label5.Size = new Size(192, 21);
            label5.TabIndex = 0;
            label5.Text = "Rooms";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(56, 36);
            button1.Name = "button1";
            button1.Size = new Size(200, 33);
            button1.TabIndex = 4;
            button1.Text = "Reserve";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(296, 36);
            button2.Name = "button2";
            button2.Size = new Size(200, 33);
            button2.TabIndex = 5;
            button2.Text = "Check-in/Check-out";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(534, 36);
            button3.Name = "button3";
            button3.Size = new Size(200, 33);
            button3.TabIndex = 6;
            button3.Text = "Rooms";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // selectedDatePicker
            // 
            selectedDatePicker.Location = new Point(56, 126);
            selectedDatePicker.Name = "selectedDatePicker";
            selectedDatePicker.Size = new Size(200, 23);
            selectedDatePicker.TabIndex = 7;
            selectedDatePicker.ValueChanged += selectedDatePicker_ValueChanged;
            // 
            // MainApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(selectedDatePicker);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimizeBox = false;
            MinimumSize = new Size(816, 489);
            Name = "MainApplication";
            Text = "MainApplication";
            FormClosed += MainApplication_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label reservationLabel;
        private Panel panel2;
        private Label availableRoomLabel;
        private Label label3;
        private Panel panel3;
        private Label roomLabel;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private DateTimePicker selectedDatePicker;
    }
}