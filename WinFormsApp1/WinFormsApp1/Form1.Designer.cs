namespace WinFormsApp1
{
    partial class Form1
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
        ///  Required method for Designer support
        /// </summary>
        private void InitializeComponent()
        {
            User_Button = new Button();
            Employee_Button = new Button();
            Manager_Button = new Button();
            SuspendLayout();
            // 
            // User_Button
            // 
            User_Button.BackColor = Color.FromArgb(52, 152, 219);
            User_Button.Font = new Font("Segoe UI", 10F);
            User_Button.ForeColor = SystemColors.Control;
            User_Button.Location = new Point(322, 68);
            User_Button.Margin = new Padding(0);
            User_Button.Name = "User_Button";
            User_Button.Size = new Size(115, 58);
            User_Button.TabIndex = 0;
            User_Button.Text = "Kullanıcı Girişi";
            User_Button.UseVisualStyleBackColor = false;
            // 
            // Employee_Button
            // 
            Employee_Button.BackColor = Color.FromArgb(70, 160, 141);
            Employee_Button.Font = new Font("Segoe UI", 10F);
            Employee_Button.ForeColor = SystemColors.Control;
            Employee_Button.Location = new Point(322, 170);
            Employee_Button.Margin = new Padding(0);
            Employee_Button.Name = "Employee_Button";
            Employee_Button.Size = new Size(115, 58);
            Employee_Button.TabIndex = 1;
            Employee_Button.Text = "Personel Girişi";
            Employee_Button.UseVisualStyleBackColor = false;
            // 
            // Manager_Button
            // 
            Manager_Button.BackColor = Color.FromArgb(80, 80, 80);
            Manager_Button.Font = new Font("Segoe UI", 10F);
            Manager_Button.ForeColor = SystemColors.Control;
            Manager_Button.Location = new Point(322, 261);
            Manager_Button.Margin = new Padding(0);
            Manager_Button.Name = "Manager_Button";
            Manager_Button.Size = new Size(115, 58);
            Manager_Button.TabIndex = 2;
            Manager_Button.Text = "Yönetici Girişi";
            Manager_Button.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 239, 248);
            ClientSize = new Size(800, 477);
            Controls.Add(Manager_Button);
            Controls.Add(Employee_Button);
            Controls.Add(User_Button);
            Name = "Form1";
            Text = "Kullanıcı Seçim Ekranı";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button User_Button;
        private System.Windows.Forms.Button Employee_Button;
        private System.Windows.Forms.Button Manager_Button;
    }
}
