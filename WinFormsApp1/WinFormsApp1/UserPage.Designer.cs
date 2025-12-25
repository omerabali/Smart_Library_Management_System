namespace WinFormsApp1
{
    partial class UserPage
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
            panel2 = new Panel();
            ana_button = new Button();
            exit_button = new Button();
            odunc_takip_button = new Button();
            odunc_talep_button = new Button();
            kitap_aara_button = new Button();
            kitap_list_button = new Button();
            panel1 = new Panel();
            labelhosgeldiniz = new Label();
            panel3 = new Panel();
            labelAktifOdunc = new Label();
            panel4 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            label2 = new Label();
            panel6 = new Panel();
            label3 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(249, 250, 251);
            panel2.Controls.Add(ana_button);
            panel2.Controls.Add(exit_button);
            panel2.Controls.Add(odunc_takip_button);
            panel2.Controls.Add(odunc_talep_button);
            panel2.Controls.Add(kitap_aara_button);
            panel2.Controls.Add(kitap_list_button);
            panel2.Location = new Point(0, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(170, 447);
            panel2.TabIndex = 1;
            // 
            // ana_button
            // 
            ana_button.Location = new Point(7, 11);
            ana_button.Name = "ana_button";
            ana_button.Size = new Size(160, 35);
            ana_button.TabIndex = 5;
            ana_button.Text = "Ana Sayfa";
            ana_button.UseVisualStyleBackColor = true;
            ana_button.Click += ana_button_Click;
            // 
            // exit_button
            // 
            exit_button.Location = new Point(7, 402);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(160, 35);
            exit_button.TabIndex = 4;
            exit_button.Text = "Çıkış";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_button_Click;
            // 
            // odunc_takip_button
            // 
            odunc_takip_button.Location = new Point(7, 171);
            odunc_takip_button.Name = "odunc_takip_button";
            odunc_takip_button.Size = new Size(160, 35);
            odunc_takip_button.TabIndex = 3;
            odunc_takip_button.Text = "Geçmiş Ödünçlerim";
            odunc_takip_button.UseVisualStyleBackColor = true;
            odunc_takip_button.Click += odunc_takip_button_Click;
            // 
            // odunc_talep_button
            // 
            odunc_talep_button.Location = new Point(7, 131);
            odunc_talep_button.Name = "odunc_talep_button";
            odunc_talep_button.Size = new Size(160, 35);
            odunc_talep_button.TabIndex = 2;
            odunc_talep_button.Text = "Ödünç Talep";
            odunc_talep_button.UseVisualStyleBackColor = true;
            odunc_talep_button.Click += odunc_talep_button_Click;
            // 
            // kitap_aara_button
            // 
            kitap_aara_button.Location = new Point(7, 91);
            kitap_aara_button.Name = "kitap_aara_button";
            kitap_aara_button.Size = new Size(160, 35);
            kitap_aara_button.TabIndex = 1;
            kitap_aara_button.Text = "Kitap Ara";
            kitap_aara_button.UseVisualStyleBackColor = true;
            kitap_aara_button.Click += kitap_aara_button_Click;
            // 
            // kitap_list_button
            // 
            kitap_list_button.Location = new Point(7, 51);
            kitap_list_button.Name = "kitap_list_button";
            kitap_list_button.Size = new Size(160, 35);
            kitap_list_button.TabIndex = 0;
            kitap_list_button.Text = "Kitap Liste";
            kitap_list_button.UseVisualStyleBackColor = true;
            kitap_list_button.Click += kitap_list_button_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelhosgeldiniz);
            panel1.Location = new Point(176, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(627, 68);
            panel1.TabIndex = 2;
            // 
            // labelhosgeldiniz
            // 
            labelhosgeldiniz.AutoSize = true;
            labelhosgeldiniz.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelhosgeldiniz.Location = new Point(48, 16);
            labelhosgeldiniz.Name = "labelhosgeldiniz";
            labelhosgeldiniz.Size = new Size(129, 28);
            labelhosgeldiniz.TabIndex = 0;
            labelhosgeldiniz.Text = "Hoşgeldiniz ";
            // 
            // panel3
            // 
            panel3.Controls.Add(labelAktifOdunc);
            panel3.Location = new Point(195, 101);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 90);
            panel3.TabIndex = 3;
            // 
            // labelAktifOdunc
            // 
            labelAktifOdunc.Font = new Font("Segoe UI", 9F);
            labelAktifOdunc.Location = new Point(10, 5);
            labelAktifOdunc.Name = "labelAktifOdunc";
            labelAktifOdunc.Size = new Size(250, 25);
            labelAktifOdunc.TabIndex = 0;
            labelAktifOdunc.Text = "Aktif Ödünç Sayısı:";
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Location = new Point(195, 225);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 90);
            panel4.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "Bekleyen Talepler";
            // 
            // panel5
            // 
            panel5.Controls.Add(label2);
            panel5.Location = new Point(508, 101);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 90);
            panel5.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 5);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 1;
            label2.Text = "Gecikmiş Kitaplar";
            // 
            // panel6
            // 
            panel6.Controls.Add(label3);
            panel6.Location = new Point(511, 225);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 90);
            panel6.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 1;
            label3.Text = "Okunan Kitap Sayisi";
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 450);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "UserPage";
            Text = "UserPage";
            Load += UserPage_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button exit_button;
        private Button odunc_takip_button;
        private Button odunc_talep_button;
        private Button kitap_aara_button;
        private Button kitap_list_button;
        private Panel panel1;
        private Label labelhosgeldiniz;
        private Panel panel3;
        private Label labelAktifOdunc;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button ana_button;
    }
}