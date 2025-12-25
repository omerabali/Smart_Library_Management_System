namespace WinFormsApp1
{
    partial class Admin_UserManagement
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
            panel1 = new Panel();
            exit_button = new Button();
            rapor_button = new Button();
            user_man_button = new Button();
            kitap_button = new Button();
            ana_button = new Button();
            panel2 = new Panel();
            btnEkle = new Button();
            txtRol = new TextBox();
            label8 = new Label();
            txtTelefon = new TextBox();
            txtSifre = new TextBox();
            txtOkulNo = new TextBox();
            txtEmail = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            dataGridViewOgrenciler = new DataGridView();
            panel4 = new Panel();
            dataGridViewPersoneller = new DataGridView();
            panel5 = new Panel();
            cmbGunRol = new ComboBox();
            guncelle_button = new Button();
            label7 = new Label();
            txtGunTelefon = new TextBox();
            txtGunSifre = new TextBox();
            txtGunOkulNo = new TextBox();
            txtGunEmail = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtGunSoyad = new TextBox();
            txtGunAd = new TextBox();
            label13 = new Label();
            label14 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciler).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersoneller).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(exit_button);
            panel1.Controls.Add(rapor_button);
            panel1.Controls.Add(user_man_button);
            panel1.Controls.Add(kitap_button);
            panel1.Controls.Add(ana_button);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 631);
            panel1.TabIndex = 2;
            // 
            // exit_button
            // 
            exit_button.Location = new Point(10, 583);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(160, 35);
            exit_button.TabIndex = 4;
            exit_button.Text = "Çıkış";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_button_Click;
            // 
            // rapor_button
            // 
            rapor_button.Location = new Point(10, 132);
            rapor_button.Name = "rapor_button";
            rapor_button.Size = new Size(160, 35);
            rapor_button.TabIndex = 3;
            rapor_button.Text = "Raporlar ve Analizler";
            rapor_button.UseVisualStyleBackColor = true;
            rapor_button.Click += rapor_button_Click;
            // 
            // user_man_button
            // 
            user_man_button.Location = new Point(10, 91);
            user_man_button.Name = "user_man_button";
            user_man_button.Size = new Size(160, 35);
            user_man_button.TabIndex = 2;
            user_man_button.Text = "Kullanıcı Yönetimi";
            user_man_button.UseVisualStyleBackColor = true;
            user_man_button.Click += user_man_button_Click;
            // 
            // kitap_button
            // 
            kitap_button.Location = new Point(10, 50);
            kitap_button.Name = "kitap_button";
            kitap_button.Size = new Size(160, 35);
            kitap_button.TabIndex = 1;
            kitap_button.Text = "Kitap Ekle";
            kitap_button.UseVisualStyleBackColor = true;
            kitap_button.Click += kitap_button_Click;
            // 
            // ana_button
            // 
            ana_button.Location = new Point(10, 9);
            ana_button.Name = "ana_button";
            ana_button.Size = new Size(160, 35);
            ana_button.TabIndex = 0;
            ana_button.Text = "Ana Sayfa";
            ana_button.UseVisualStyleBackColor = true;
            ana_button.Click += ana_button_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEkle);
            panel2.Controls.Add(txtRol);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtTelefon);
            panel2.Controls.Add(txtSifre);
            panel2.Controls.Add(txtOkulNo);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtSoyad);
            panel2.Controls.Add(txtAd);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(191, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1524, 94);
            panel2.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(1222, 52);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(232, 29);
            btnEkle.TabIndex = 12;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // txtRol
            // 
            txtRol.Location = new Point(1213, 17);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(252, 27);
            txtRol.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1153, 19);
            label8.Name = "label8";
            label8.Size = new Size(34, 20);
            label8.TabIndex = 8;
            label8.Text = "Rol:";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(877, 54);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(252, 27);
            txtTelefon.TabIndex = 7;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(492, 54);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(252, 27);
            txtSifre.TabIndex = 7;
            // 
            // txtOkulNo
            // 
            txtOkulNo.Location = new Point(877, 17);
            txtOkulNo.Name = "txtOkulNo";
            txtOkulNo.Size = new Size(252, 27);
            txtOkulNo.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(492, 15);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(252, 27);
            txtEmail.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(771, 60);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 5;
            label5.Text = "Telefon:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(390, 60);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 5;
            label3.Text = "Şifre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(771, 23);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 4;
            label6.Text = "OkulNo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(390, 20);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 4;
            label4.Text = "E-Mail:";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(100, 54);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(252, 27);
            txtSoyad.TabIndex = 3;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(100, 16);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(252, 27);
            txtAd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 57);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewOgrenciler);
            panel3.Location = new Point(191, 101);
            panel3.Name = "panel3";
            panel3.Size = new Size(1524, 212);
            panel3.TabIndex = 4;
            // 
            // dataGridViewOgrenciler
            // 
            dataGridViewOgrenciler.BackgroundColor = SystemColors.Control;
            dataGridViewOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOgrenciler.Location = new Point(0, 3);
            dataGridViewOgrenciler.Name = "dataGridViewOgrenciler";
            dataGridViewOgrenciler.RowHeadersWidth = 51;
            dataGridViewOgrenciler.Size = new Size(1521, 206);
            dataGridViewOgrenciler.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridViewPersoneller);
            panel4.Location = new Point(191, 319);
            panel4.Name = "panel4";
            panel4.Size = new Size(1524, 212);
            panel4.TabIndex = 5;
            // 
            // dataGridViewPersoneller
            // 
            dataGridViewPersoneller.BackgroundColor = SystemColors.Control;
            dataGridViewPersoneller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPersoneller.Location = new Point(2, 3);
            dataGridViewPersoneller.Name = "dataGridViewPersoneller";
            dataGridViewPersoneller.RowHeadersWidth = 51;
            dataGridViewPersoneller.Size = new Size(1521, 206);
            dataGridViewPersoneller.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(cmbGunRol);
            panel5.Controls.Add(guncelle_button);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(txtGunTelefon);
            panel5.Controls.Add(txtGunSifre);
            panel5.Controls.Add(txtGunOkulNo);
            panel5.Controls.Add(txtGunEmail);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(txtGunSoyad);
            panel5.Controls.Add(txtGunAd);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label14);
            panel5.Location = new Point(194, 537);
            panel5.Name = "panel5";
            panel5.Size = new Size(1524, 94);
            panel5.TabIndex = 6;
            // 
            // cmbGunRol
            // 
            cmbGunRol.FormattingEnabled = true;
            cmbGunRol.Location = new Point(1222, 20);
            cmbGunRol.Name = "cmbGunRol";
            cmbGunRol.Size = new Size(232, 28);
            cmbGunRol.TabIndex = 13;
            // 
            // guncelle_button
            // 
            guncelle_button.Location = new Point(1222, 52);
            guncelle_button.Name = "guncelle_button";
            guncelle_button.Size = new Size(232, 29);
            guncelle_button.TabIndex = 12;
            guncelle_button.Text = "Guncelle";
            guncelle_button.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1153, 19);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 8;
            label7.Text = "Rol:";
            // 
            // txtGunTelefon
            // 
            txtGunTelefon.Location = new Point(877, 54);
            txtGunTelefon.Name = "txtGunTelefon";
            txtGunTelefon.Size = new Size(252, 27);
            txtGunTelefon.TabIndex = 7;
            // 
            // txtGunSifre
            // 
            txtGunSifre.Location = new Point(492, 54);
            txtGunSifre.Name = "txtGunSifre";
            txtGunSifre.Size = new Size(252, 27);
            txtGunSifre.TabIndex = 7;
            // 
            // txtGunOkulNo
            // 
            txtGunOkulNo.Location = new Point(877, 17);
            txtGunOkulNo.Name = "txtGunOkulNo";
            txtGunOkulNo.Size = new Size(252, 27);
            txtGunOkulNo.TabIndex = 6;
            // 
            // txtGunEmail
            // 
            txtGunEmail.Location = new Point(492, 15);
            txtGunEmail.Name = "txtGunEmail";
            txtGunEmail.Size = new Size(252, 27);
            txtGunEmail.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(771, 60);
            label9.Name = "label9";
            label9.Size = new Size(61, 20);
            label9.TabIndex = 5;
            label9.Text = "Telefon:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(390, 60);
            label10.Name = "label10";
            label10.Size = new Size(42, 20);
            label10.TabIndex = 5;
            label10.Text = "Şifre:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(771, 23);
            label11.Name = "label11";
            label11.Size = new Size(62, 20);
            label11.TabIndex = 4;
            label11.Text = "OkulNo:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(390, 20);
            label12.Name = "label12";
            label12.Size = new Size(55, 20);
            label12.TabIndex = 4;
            label12.Text = "E-Mail:";
            // 
            // txtGunSoyad
            // 
            txtGunSoyad.Location = new Point(100, 54);
            txtGunSoyad.Name = "txtGunSoyad";
            txtGunSoyad.Size = new Size(252, 27);
            txtGunSoyad.TabIndex = 3;
            // 
            // txtGunAd
            // 
            txtGunAd.Location = new Point(100, 16);
            txtGunAd.Name = "txtGunAd";
            txtGunAd.Size = new Size(252, 27);
            txtGunAd.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 57);
            label13.Name = "label13";
            label13.Size = new Size(53, 20);
            label13.TabIndex = 1;
            label13.Text = "Soyad:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 16);
            label14.Name = "label14";
            label14.Size = new Size(31, 20);
            label14.TabIndex = 0;
            label14.Text = "Ad:";
            // 
            // Admin_UserManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1771, 690);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Admin_UserManagement";
            Text = "Admin_UserManagement";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciler).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersoneller).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private Button btnEkle;
        private TextBox txtRol;
        private Label label8;
        private TextBox txtTelefon;
        private TextBox txtSifre;
        private TextBox txtOkulNo;
        private TextBox txtEmail;
        private Label label5;
        private Label label3;
        private Label label6;
        private Label label4;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private DataGridView dataGridViewOgrenciler;
        private Panel panel4;
        private DataGridView dataGridViewPersoneller;
        private Panel panel5;
        private ComboBox cmbGunRol;
        private Button guncelle_button;
        private Label label7;
        private TextBox txtGunTelefon;
        private TextBox txtGunSifre;
        private TextBox txtGunOkulNo;
        private TextBox txtGunEmail;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtGunSoyad;
        private TextBox txtGunAd;
        private Label label13;
        private Label label14;
    }
}