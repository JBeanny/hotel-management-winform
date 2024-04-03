namespace HotelManagement
{
    partial class ReservationForm
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
            startDatePicker = new DateTimePicker();
            endDatePicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            guestIdInput = new TextBox();
            label5 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label4 = new Label();
            guestPhoneInput = new TextBox();
            label3 = new Label();
            guestNameInput = new TextBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            charge = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // startDatePicker
            // 
            startDatePicker.Location = new Point(12, 35);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(200, 23);
            startDatePicker.TabIndex = 0;
            startDatePicker.ValueChanged += startDateValueChanged;
            // 
            // endDatePicker
            // 
            endDatePicker.Location = new Point(321, 35);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(200, 23);
            endDatePicker.TabIndex = 1;
            endDatePicker.ValueChanged += endDateValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "Start Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 9);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "End Date";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(guestIdInput);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(guestPhoneInput);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(guestNameInput);
            groupBox1.Location = new Point(541, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 183);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Guest Form";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 141);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 8;
            label6.Text = "ID";
            // 
            // guestIdInput
            // 
            guestIdInput.Location = new Point(67, 138);
            guestIdInput.Name = "guestIdInput";
            guestIdInput.Size = new Size(173, 23);
            guestIdInput.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 94);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 6;
            label5.Text = "Sex";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(154, 106);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(89, 106);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 64);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // guestPhoneInput
            // 
            guestPhoneInput.Location = new Point(67, 61);
            guestPhoneInput.Name = "guestPhoneInput";
            guestPhoneInput.Size = new Size(173, 23);
            guestPhoneInput.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 32);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 1;
            label3.Text = "Name";
            // 
            // guestNameInput
            // 
            guestNameInput.Location = new Point(68, 29);
            guestNameInput.Name = "guestNameInput";
            guestNameInput.Size = new Size(173, 23);
            guestNameInput.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(541, 377);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(247, 61);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Reserve";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(124, 58, 237);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(245, 243, 255);
            button1.Location = new Point(8, 19);
            button1.Name = "button1";
            button1.Size = new Size(232, 32);
            button1.TabIndex = 0;
            button1.Text = "Reserve";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, name, charge });
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(12, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(509, 365);
            dataGridView1.TabIndex = 7;
            // 
            // id
            // 
            id.HeaderText = "Room ID";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "Room Name";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // charge
            // 
            charge.HeaderText = "Charge Fee ( $ /day )";
            charge.MinimumWidth = 8;
            charge.Name = "charge";
            charge.ReadOnly = true;
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 443);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(endDatePicker);
            Controls.Add(startDatePicker);
            MaximizeBox = false;
            MaximumSize = new Size(814, 482);
            MinimizeBox = false;
            MinimumSize = new Size(814, 482);
            Name = "ReservationForm";
            ShowIcon = false;
            Text = "Reservation Form";
            Load += InitialLoad;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker startDatePicker;
        private DateTimePicker endDatePicker;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox guestPhoneInput;
        private Label label3;
        private TextBox guestNameInput;
        private Label label5;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label6;
        private TextBox guestIdInput;
        private GroupBox groupBox2;
        private Button button1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn charge;
        public DataGridView dataGridView1;
    }
}