namespace Multibanco.View
{
    partial class MainForm
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
            welcomeTxtBox = new TextBox();
            balanceTxtBox = new TextBox();
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
            // welcomeTxtBox
            // 
            welcomeTxtBox.Font = new Font("Segoe UI", 14F);
            welcomeTxtBox.Location = new Point(57, 61);
            welcomeTxtBox.Name = "welcomeTxtBox";
            welcomeTxtBox.Size = new Size(199, 32);
            welcomeTxtBox.TabIndex = 2;
            // 
            // balanceTxtBox
            // 
            balanceTxtBox.Font = new Font("Segoe UI", 20F);
            balanceTxtBox.Location = new Point(583, 61);
            balanceTxtBox.Name = "balanceTxtBox";
            balanceTxtBox.Size = new Size(147, 43);
            balanceTxtBox.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(balanceTxtBox);
            Controls.Add(welcomeTxtBox);
            Controls.Add(ExitButton);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton;
        private TextBox welcomeTxtBox;
        private TextBox balanceTxtBox;
    }
}