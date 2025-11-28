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
            depositBtn = new Button();
            withdrawBtn = new Button();
            amountTxtBox = new TextBox();
            listBox1 = new ListBox();
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
            welcomeTxtBox.Location = new Point(12, 12);
            welcomeTxtBox.Name = "welcomeTxtBox";
            welcomeTxtBox.Size = new Size(199, 32);
            welcomeTxtBox.TabIndex = 2;
            // 
            // balanceTxtBox
            // 
            balanceTxtBox.Font = new Font("Segoe UI", 20F);
            balanceTxtBox.Location = new Point(613, 50);
            balanceTxtBox.Name = "balanceTxtBox";
            balanceTxtBox.Size = new Size(147, 43);
            balanceTxtBox.TabIndex = 3;
            // 
            // depositBtn
            // 
            depositBtn.Font = new Font("Segoe UI", 13F);
            depositBtn.Location = new Point(57, 280);
            depositBtn.Name = "depositBtn";
            depositBtn.Size = new Size(101, 48);
            depositBtn.TabIndex = 4;
            depositBtn.Text = "Deposit";
            depositBtn.UseVisualStyleBackColor = true;
            depositBtn.Click += depositBtn_Click;
            // 
            // withdrawBtn
            // 
            withdrawBtn.Font = new Font("Segoe UI", 13F);
            withdrawBtn.Location = new Point(195, 280);
            withdrawBtn.Name = "withdrawBtn";
            withdrawBtn.Size = new Size(101, 48);
            withdrawBtn.TabIndex = 5;
            withdrawBtn.Text = "Withdraw";
            withdrawBtn.UseVisualStyleBackColor = true;
            withdrawBtn.Click += withdrawBtn_Click;
            // 
            // amountTxtBox
            // 
            amountTxtBox.Font = new Font("Segoe UI", 20F);
            amountTxtBox.Location = new Point(57, 109);
            amountTxtBox.Name = "amountTxtBox";
            amountTxtBox.PlaceholderText = "Amount";
            amountTxtBox.Size = new Size(147, 43);
            amountTxtBox.TabIndex = 6;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(366, 129);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(406, 199);
            listBox1.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(amountTxtBox);
            Controls.Add(withdrawBtn);
            Controls.Add(depositBtn);
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
        private Button depositBtn;
        private Button withdrawBtn;
        private TextBox amountTxtBox;
        private ListBox listBox1;
    }
}