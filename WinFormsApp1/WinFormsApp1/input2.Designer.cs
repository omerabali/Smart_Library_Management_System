using System.Windows.Forms;
using System.Drawing;

namespace WinFormsApp1
{
    partial class Input2
    {
        private System.ComponentModel.IContainer components = null;

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
            ad_textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            soyad_textBox = new TextBox();
            label3 = new Label();
            okulno_textBox = new TextBox();
            label4 = new Label();
            telefon_textBox = new TextBox();
            label5 = new Label();
            email_textBox = new TextBox();
            label6 = new Label();
            password_textBox = new TextBox();
            Register_Button = new Button();
            Back_Button = new Button();
            SuspendLayout();
            // 
            // ad_textBox
            // 
            ad_textBox.Location = new Point(312, 51);
            ad_textBox.Name = "ad_textBox";
            ad_textBox.Size = new Size(299, 27);
            ad_textBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(55, 65, 81);
            label1.Location = new Point(198, 54);
            label1.Name = "label1";
            label1.Size = new Size(38, 23);
            label1.TabIndex = 2;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(55, 65, 81);
            label2.Location = new Point(198, 110);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 4;
            label2.Text = "Soyad:";
            // 
            // soyad_textBox
            // 
            soyad_textBox.Location = new Point(312, 107);
            soyad_textBox.Name = "soyad_textBox";
            soyad_textBox.Size = new Size(299, 27);
            soyad_textBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(55, 65, 81);
            label3.Location = new Point(198, 171);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 6;
            label3.Text = "Okul No:";
            // 
            // okulno_textBox
            // 
            okulno_textBox.Location = new Point(312, 168);
            okulno_textBox.Name = "okulno_textBox";
            okulno_textBox.Size = new Size(299, 27);
            okulno_textBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(55, 65, 81);
            label4.Location = new Point(198, 226);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 8;
            label4.Text = "Telefon No:";
            // 
            // telefon_textBox
            // 
            telefon_textBox.Location = new Point(312, 223);
            telefon_textBox.Name = "telefon_textBox";
            telefon_textBox.Size = new Size(299, 27);
            telefon_textBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(55, 65, 81);
            label5.Location = new Point(198, 281);
            label5.Name = "label5";
            label5.Size = new Size(66, 23);
            label5.TabIndex = 10;
            label5.Text = "E-mail:";
            // 
            // email_textBox
            // 
            email_textBox.Location = new Point(312, 278);
            email_textBox.Name = "email_textBox";
            email_textBox.Size = new Size(299, 27);
            email_textBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(55, 65, 81);
            label6.Location = new Point(198, 331);
            label6.Name = "label6";
            label6.Size = new Size(53, 23);
            label6.TabIndex = 12;
            label6.Text = "Şifre:";
            // 
            // password_textBox
            // 
            password_textBox.Location = new Point(312, 328);
            password_textBox.Name = "password_textBox";
            password_textBox.PasswordChar = '*';
            password_textBox.Size = new Size(299, 27);
            password_textBox.TabIndex = 11;
            // 
            // Register_Button
            // 
            Register_Button.BackColor = Color.FromArgb(37, 99, 235);
            Register_Button.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Register_Button.ForeColor = Color.White;
            Register_Button.Location = new Point(198, 390);
            Register_Button.Name = "Register_Button";
            Register_Button.Size = new Size(109, 48);
            Register_Button.TabIndex = 13;
            Register_Button.Text = "Kayıt Ol";
            Register_Button.UseVisualStyleBackColor = false;
            Register_Button.Click += Register_Button_Click;
            // 
            // Back_Button
            // 
            Back_Button.BackColor = Color.FromArgb(229, 231, 235);
            Back_Button.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Back_Button.ForeColor = Color.FromArgb(0, 1, 180, 211);
            Back_Button.Location = new Point(502, 390);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new Size(109, 48);
            Back_Button.TabIndex = 14;
            Back_Button.Text = "Geri";
            Back_Button.UseVisualStyleBackColor = false;
            Back_Button.Click += Back_Button_Click;
            // 
            // Input2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 481);
            Controls.Add(Back_Button);
            Controls.Add(Register_Button);
            Controls.Add(label6);
            Controls.Add(password_textBox);
            Controls.Add(label5);
            Controls.Add(email_textBox);
            Controls.Add(label4);
            Controls.Add(telefon_textBox);
            Controls.Add(label3);
            Controls.Add(okulno_textBox);
            Controls.Add(label2);
            Controls.Add(soyad_textBox);
            Controls.Add(label1);
            Controls.Add(ad_textBox);
            Name = "Input2";
            Text = "Kayıt Ol";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ad_textBox;
        private Label label1;
        private Label label2;
        private TextBox soyad_textBox;
        private Label label3;
        private TextBox okulno_textBox;
        private Label label4;
        private TextBox telefon_textBox;
        private Label label5;
        private TextBox email_textBox;
        private Label label6;
        private TextBox password_textBox;
        private Button Register_Button;
        private Button Back_Button;
    }
}
