using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Input
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            email_textBox = new TextBox();
            back_button = new Button();
            password_textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            input_button = new Button();
            register_button = new Button();
            SuspendLayout();
            // 
            // email_textBox
            // 
            email_textBox.Location = new Point(337, 94);
            email_textBox.Name = "email_textBox";
            email_textBox.Size = new Size(310, 27);
            email_textBox.TabIndex = 0;
            // 
            // back_button
            // 
            back_button.BackColor = Color.FromArgb(229, 231, 235);
            back_button.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            back_button.Location = new Point(534, 263);
            back_button.Name = "back_button";
            back_button.Size = new Size(113, 47);
            back_button.TabIndex = 1;
            back_button.Text = "Geri";
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += Back_Button_Click;
            // 
            // password_textBox
            // 
            password_textBox.Location = new Point(337, 166);
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(310, 27);
            password_textBox.TabIndex = 3;
            password_textBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(235, 94);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 4;
            label1.Text = "E-posta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(235, 169);
            label2.Name = "label2";
            label2.Size = new Size(53, 23);
            label2.TabIndex = 5;
            label2.Text = "Şifre:";
            // 
            // input_button
            // 
            input_button.BackColor = Color.FromArgb(37, 99, 235);
            input_button.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            input_button.ForeColor = SystemColors.Control;
            input_button.Location = new Point(235, 263);
            input_button.Name = "input_button";
            input_button.Size = new Size(113, 47);
            input_button.TabIndex = 6;
            input_button.Text = "Giriş Yap";
            input_button.UseVisualStyleBackColor = false;
            input_button.Click += Input_Button_Click;
            // 
            // register_button
            // 
            register_button.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            register_button.ForeColor = Color.FromArgb(37, 99, 235);
            register_button.Location = new Point(388, 351);
            register_button.Name = "register_button";
            register_button.Size = new Size(113, 47);
            register_button.TabIndex = 7;
            register_button.Text = "Kayıt Ol";
            register_button.UseVisualStyleBackColor = true;
            register_button.Click += Register_Button_Click;
            // 
            // Input
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 450);
            Controls.Add(register_button);
            Controls.Add(input_button);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password_textBox);
            Controls.Add(back_button);
            Controls.Add(email_textBox);
            Name = "Input";
            Text = "Giriş";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox email_textBox;
        private Button back_button;
        private TextBox password_textBox;
        private Label label1;
        private Label label2;
        private Button input_button;
        private Button register_button;
    }
}
