namespace Multibanco.View
{
    partial class NewUserForm
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
            ExitButton = new Button();
            PasswordTxtBox = new TextBox();
            UsernameTxtBox = new TextBox();
            label1 = new Label();
            CreateNewUserButton = new Button();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 13F);
            ExitButton.Location = new Point(675, 389);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(113, 49);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Font = new Font("Segoe UI", 18F);
            PasswordTxtBox.Location = new Point(268, 180);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.PlaceholderText = "Password";
            PasswordTxtBox.Size = new Size(211, 39);
            PasswordTxtBox.TabIndex = 5;
            // 
            // UsernameTxtBox
            // 
            UsernameTxtBox.Font = new Font("Segoe UI", 18F);
            UsernameTxtBox.Location = new Point(268, 135);
            UsernameTxtBox.Name = "UsernameTxtBox";
            UsernameTxtBox.PlaceholderText = "Username";
            UsernameTxtBox.Size = new Size(211, 39);
            UsernameTxtBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(245, 9);
            label1.Name = "label1";
            label1.Size = new Size(259, 72);
            label1.TabIndex = 6;
            label1.Text = "New User";
            // 
            // CreateNewUserButton
            // 
            CreateNewUserButton.Font = new Font("Segoe UI", 10F);
            CreateNewUserButton.Location = new Point(319, 250);
            CreateNewUserButton.Name = "CreateNewUserButton";
            CreateNewUserButton.Size = new Size(113, 49);
            CreateNewUserButton.TabIndex = 7;
            CreateNewUserButton.Text = "Create New User";
            CreateNewUserButton.UseVisualStyleBackColor = true;
            // 
            // NewUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateNewUserButton);
            Controls.Add(label1);
            Controls.Add(PasswordTxtBox);
            Controls.Add(UsernameTxtBox);
            Controls.Add(ExitButton);
            Name = "NewUserForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton;
        private TextBox PasswordTxtBox;
        private TextBox UsernameTxtBox;
        private Label label1;
        private Button CreateNewUserButton;
    }
}