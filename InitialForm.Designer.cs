namespace HotelManagement
{
    partial class InitialForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            registerButton = new Button();
            loginButton = new Button();
            label2 = new Label();
            label1 = new Label();
            passwordInput = new TextBox();
            usernameInput = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(registerButton);
            groupBox1.Controls.Add(loginButton);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(passwordInput);
            groupBox1.Controls.Add(usernameInput);
            groupBox1.Location = new Point(173, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(456, 199);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Authentication Form";
            // 
            // registerButton
            // 
            registerButton.FlatAppearance.BorderColor = Color.FromArgb(161, 161, 170);
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Location = new Point(259, 153);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(99, 25);
            registerButton.TabIndex = 5;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Transparent;
            loginButton.FlatAppearance.BorderColor = Color.FromArgb(161, 161, 170);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Location = new Point(139, 153);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(99, 25);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 91);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 43);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(122, 88);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(310, 23);
            passwordInput.TabIndex = 1;
            passwordInput.UseSystemPasswordChar = true;
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(122, 40);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(310, 23);
            usernameInput.TabIndex = 0;
            // 
            // InitialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "InitialForm";
            Text = "Hotel Management";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox passwordInput;
        private TextBox usernameInput;
        private Label label2;
        private Label label1;
        private Button registerButton;
        private Button loginButton;
    }
}