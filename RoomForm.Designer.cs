namespace HotelManagement
{
    partial class RoomForm
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
            groupBox1 = new GroupBox();
            chargeFeeInput = new NumericUpDown();
            addButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            nameInput = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            charge = new DataGridViewTextBoxColumn();
            searchTextBox = new TextBox();
            searchButton = new Button();
            groupBox2 = new GroupBox();
            deleteButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chargeFeeInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chargeFeeInput);
            groupBox1.Controls.Add(addButton);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(nameInput);
            groupBox1.Location = new Point(527, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(261, 142);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Room";
            // 
            // chargeFeeInput
            // 
            chargeFeeInput.Location = new Point(111, 61);
            chargeFeeInput.Name = "chargeFeeInput";
            chargeFeeInput.Size = new Size(144, 23);
            chargeFeeInput.TabIndex = 6;
            // 
            // addButton
            // 
            addButton.BackColor = Color.White;
            addButton.FlatAppearance.BorderColor = Color.DimGray;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.ForeColor = Color.Black;
            addButton.Location = new Point(180, 113);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 5;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(128, 87);
            label3.Name = "label3";
            label3.Size = new Size(127, 13);
            label3.TabIndex = 4;
            label3.Text = "* price per day in dollar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 65);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Charge fee";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 25);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // nameInput
            // 
            nameInput.Location = new Point(111, 22);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(144, 23);
            nameInput.TabIndex = 0;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, name, charge });
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.Size = new Size(493, 397);
            dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // charge
            // 
            charge.HeaderText = "Charge Price ( $ / day )";
            charge.Name = "charge";
            charge.ReadOnly = true;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(12, 12);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(412, 23);
            searchTextBox.TabIndex = 7;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.White;
            searchButton.FlatAppearance.BorderColor = Color.DimGray;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.ForeColor = Color.Black;
            searchButton.Location = new Point(430, 12);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 7;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(deleteButton);
            groupBox2.Location = new Point(527, 372);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(261, 66);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Manage";
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(239, 68, 68);
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.ForeColor = Color.FromArgb(245, 243, 255);
            deleteButton.Location = new Point(8, 22);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(247, 32);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimizeBox = false;
            MinimumSize = new Size(816, 489);
            Name = "RoomForm";
            ShowIcon = false;
            Text = "Room Form";
            Load += InitialLoad;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chargeFeeInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox nameInput;
        private Button addButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown chargeFeeInput;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn charge;
        private TextBox searchTextBox;
        private Button searchButton;
        private GroupBox groupBox2;
        private Button deleteButton;
    }
}