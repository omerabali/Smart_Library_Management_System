namespace WinFormsApp1
{
    partial class AdminPage
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
            panel1 = new Panel();
            exit_button = new Button();
            rapor_button = new Button();
            user_man_button = new Button();
            kitap_button = new Button();
            ana_button = new Button();
            panel2 = new Panel();
            label_hosgeldiniz = new Label();

            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();

            // panel1 - Sol Menü
            panel1.Controls.Add(exit_button);
            panel1.Controls.Add(rapor_button);
            panel1.Controls.Add(user_man_button);
            panel1.Controls.Add(kitap_button);
            panel1.Controls.Add(ana_button);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 444);
            panel1.TabIndex = 0;

            // exit_button
            exit_button.Location = new Point(10, 402);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(160, 35);
            exit_button.TabIndex = 4;
            exit_button.Text = "Çıkış";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_button_Click;

            // rapor_button
            rapor_button.Location = new Point(10, 132);
            rapor_button.Name = "rapor_button";
            rapor_button.Size = new Size(160, 35);
            rapor_button.TabIndex = 3;
            rapor_button.Text = "Raporlar ve Analizler";
            rapor_button.UseVisualStyleBackColor = true;
            rapor_button.Click += rapor_button_Click;

            // user_man_button
            user_man_button.Location = new Point(10, 91);
            user_man_button.Name = "user_man_button";
            user_man_button.Size = new Size(160, 35);
            user_man_button.TabIndex = 2;
            user_man_button.Text = "Kullanıcı Yönetimi";
            user_man_button.UseVisualStyleBackColor = true;
            user_man_button.Click += user_man_button_Click;

            // kitap_button
            kitap_button.Location = new Point(10, 50);
            kitap_button.Name = "kitap_button";
            kitap_button.Size = new Size(160, 35);
            kitap_button.TabIndex = 1;
            kitap_button.Text = "Kitap Yönetimi";
            kitap_button.UseVisualStyleBackColor = true;
            kitap_button.Click += kitap_button_Click;

            // ana_button
            ana_button.Location = new Point(10, 9);
            ana_button.Name = "ana_button";
            ana_button.Size = new Size(160, 35);
            ana_button.TabIndex = 0;
            ana_button.Text = "Ana Sayfa";
            ana_button.UseVisualStyleBackColor = true;
            ana_button.Click += ana_button_Click;

            // panel2 - Hoşgeldiniz
            panel2.Controls.Add(label_hosgeldiniz);
            panel2.Location = new Point(192, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(690, 92);
            panel2.TabIndex = 1;

            // label_hosgeldiniz
            label_hosgeldiniz.AutoSize = true;
            label_hosgeldiniz.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_hosgeldiniz.Location = new Point(41, 30);
            label_hosgeldiniz.Name = "label_hosgeldiniz";
            label_hosgeldiniz.Size = new Size(123, 28);
            label_hosgeldiniz.TabIndex = 0;
            label_hosgeldiniz.Text = "Hoşgeldiniz";

            // AdminPage
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminPage";
            Text = "AdminPage";
            Load += AdminPage_Load;

            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button exit_button;
        private Button rapor_button;
        private Button user_man_button;
        private Button kitap_button;
        private Button ana_button;
        private Panel panel2;
        private Label label_hosgeldiniz;
    }
}
