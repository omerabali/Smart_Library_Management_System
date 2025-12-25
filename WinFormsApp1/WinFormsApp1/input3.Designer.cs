namespace WinFormsApp1
{
    partial class Input3
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
            Input_Button = new Button();
            label2 = new Label();
            label1 = new Label();
            password_textBox = new TextBox();
            Back_Button = new Button();
            email_textBox = new TextBox();
            SuspendLayout();
            // 
            // Input_Button
            // 
            Input_Button.BackColor = Color.FromArgb(37, 99, 235);
            Input_Button.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Input_Button.ForeColor = Color.White;
            Input_Button.Location = new Point(190, 265);
            Input_Button.Name = "Input_Button";
            Input_Button.Size = new Size(113, 47);
            Input_Button.TabIndex = 18;
            Input_Button.Text = "Giriş Yap";
            Input_Button.UseVisualStyleBackColor = false;
            Input_Button.Click += Input_Button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(190, 171);
            label2.Name = "label2";
            label2.Size = new Size(53, 23);
            label2.TabIndex = 17;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(55, 65, 81);
            label1.Location = new Point(190, 96);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 16;
            label1.Text = "E-posta:";
            // 
            // password_textBox
            // 
            password_textBox.Location = new Point(292, 168);
            password_textBox.Name = "password_textBox";
            password_textBox.PasswordChar = '*';
            password_textBox.Size = new Size(310, 27);
            password_textBox.TabIndex = 15;
            password_textBox.UseSystemPasswordChar = true;
            // 
            // Back_Button
            // 
            Back_Button.BackColor = Color.FromArgb(229, 231, 235);
            Back_Button.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Back_Button.ForeColor = Color.FromArgb(17, 24, 39);
            Back_Button.Location = new Point(489, 265);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new Size(113, 47);
            Back_Button.TabIndex = 14;
            Back_Button.Text = "Geri";
            Back_Button.UseVisualStyleBackColor = false;
            Back_Button.Click += Back_Button_Click;
            // 
            // email_textBox
            // 
            email_textBox.Location = new Point(292, 96);
            email_textBox.Name = "email_textBox";
            email_textBox.Size = new Size(310, 27);
            email_textBox.TabIndex = 13;
            // 
            // Input3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Input_Button);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password_textBox);
            Controls.Add(Back_Button);
            Controls.Add(email_textBox);
            Name = "Input3";
            Text = "Yönetici Girişi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Input_Button;
        private Label label2;
        private Label label1;
        private TextBox password_textBox;
        private Button Back_Button;
        private TextBox email_textBox;
    }
}
