namespace Multibanco
{
    partial class LoginForm
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
            ExitButton = new Button();
            UsernameTxtBox = new TextBox();
            label1 = new Label();
            PasswordTxtBox = new TextBox();
            LoginButton = new Button();
            NewUserButton = new Button();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 13F);
            ExitButton.Location = new Point(675, 389);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(113, 49);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // UsernameTxtBox
            // 
            UsernameTxtBox.Font = new Font("Segoe UI", 18F);
            UsernameTxtBox.Location = new Point(271, 113);
            UsernameTxtBox.Name = "UsernameTxtBox";
            UsernameTxtBox.PlaceholderText = "Username";
            UsernameTxtBox.Size = new Size(211, 39);
            UsernameTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(310, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 72);
            label1.TabIndex = 2;
            label1.Text = "ATM";
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Font = new Font("Segoe UI", 18F);
            PasswordTxtBox.Location = new Point(271, 158);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.PlaceholderText = "Password";
            PasswordTxtBox.Size = new Size(211, 39);
            PasswordTxtBox.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Segoe UI", 13F);
            LoginButton.Location = new Point(412, 233);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(113, 49);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // NewUserButton
            // 
            NewUserButton.Font = new Font("Segoe UI", 13F);
            NewUserButton.Location = new Point(228, 233);
            NewUserButton.Name = "NewUserButton";
            NewUserButton.Size = new Size(113, 49);
            NewUserButton.TabIndex = 5;
            NewUserButton.Text = "New User";
            NewUserButton.UseVisualStyleBackColor = true;
            NewUserButton.Click += NewUserButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NewUserButton);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTxtBox);
            Controls.Add(label1);
            Controls.Add(UsernameTxtBox);
            Controls.Add(ExitButton);
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton;
        private TextBox UsernameTxtBox;
        private Label label1;
        private TextBox PasswordTxtBox;
        private Button LoginButton;
        private Button NewUserButton;
    }
}
