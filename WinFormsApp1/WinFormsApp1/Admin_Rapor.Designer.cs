namespace WinFormsApp1
{
    partial class Admin_Rapor
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
            filtre_button = new Button();
            panel5 = new Panel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            panel4 = new Panel();
            dtBit = new DateTimePicker();
            label2 = new Label();
            dtBas = new DateTimePicker();
            label1 = new Label();
            panel3 = new Panel();
            rbAylık = new RadioButton();
            rbHaftalık = new RadioButton();
            rbGunluk = new RadioButton();
            panel6 = new Panel();
            dvgAlt = new DataGridView();
            dvgUst = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgAlt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgUst).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(exit_button);
            panel1.Controls.Add(rapor_button);
            panel1.Controls.Add(user_man_button);
            panel1.Controls.Add(kitap_button);
            panel1.Controls.Add(ana_button);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 631);
            panel1.TabIndex = 3;
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
            panel2.Controls.Add(filtre_button);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(191, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1595, 112);
            panel2.TabIndex = 4;
            // 
            // filtre_button
            // 
            filtre_button.Location = new Point(1436, 28);
            filtre_button.Name = "filtre_button";
            filtre_button.Size = new Size(102, 47);
            filtre_button.TabIndex = 3;
            filtre_button.Text = "Filtrele";
            filtre_button.UseVisualStyleBackColor = true;
            filtre_button.Click += filtre_button_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(checkBox2);
            panel5.Controls.Add(checkBox1);
            panel5.Location = new Point(1023, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(350, 110);
            panel5.TabIndex = 2;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(40, 67);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(225, 24);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "En Çok Ödünç Alınan Kitaplar";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(40, 17);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(152, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Ödünç İstatislikleri";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(dtBit);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(dtBas);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(509, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(508, 108);
            panel4.TabIndex = 1;
            // 
            // dtBit
            // 
            dtBit.Location = new Point(158, 62);
            dtBit.Name = "dtBit";
            dtBit.Size = new Size(250, 27);
            dtBit.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 62);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 2;
            label2.Text = "Bitiş:";
            // 
            // dtBas
            // 
            dtBas.Location = new Point(158, 16);
            dtBas.Name = "dtBas";
            dtBas.Size = new Size(250, 27);
            dtBas.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 16);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Başlangıç:";
            // 
            // panel3
            // 
            panel3.Controls.Add(rbAylık);
            panel3.Controls.Add(rbHaftalık);
            panel3.Controls.Add(rbGunluk);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 108);
            panel3.TabIndex = 0;
            // 
            // rbAylık
            // 
            rbAylık.AutoSize = true;
            rbAylık.Location = new Point(366, 47);
            rbAylık.Name = "rbAylık";
            rbAylık.Size = new Size(62, 24);
            rbAylık.TabIndex = 7;
            rbAylık.TabStop = true;
            rbAylık.Text = "Aylık";
            rbAylık.UseVisualStyleBackColor = true;
            // 
            // rbHaftalık
            // 
            rbHaftalık.AutoSize = true;
            rbHaftalık.Location = new Point(192, 47);
            rbHaftalık.Name = "rbHaftalık";
            rbHaftalık.Size = new Size(82, 24);
            rbHaftalık.TabIndex = 6;
            rbHaftalık.TabStop = true;
            rbHaftalık.Text = "Haftalık";
            rbHaftalık.UseVisualStyleBackColor = true;
            // 
            // rbGunluk
            // 
            rbGunluk.AutoSize = true;
            rbGunluk.Location = new Point(15, 47);
            rbGunluk.Name = "rbGunluk";
            rbGunluk.Size = new Size(75, 24);
            rbGunluk.TabIndex = 5;
            rbGunluk.TabStop = true;
            rbGunluk.Text = "Günlük";
            rbGunluk.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(dvgAlt);
            panel6.Controls.Add(dvgUst);
            panel6.Location = new Point(196, 123);
            panel6.Name = "panel6";
            panel6.Size = new Size(1500, 509);
            panel6.TabIndex = 5;
            // 
            // dvgAlt
            // 
            dvgAlt.BackgroundColor = SystemColors.Control;
            dvgAlt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgAlt.Location = new Point(10, 194);
            dvgAlt.Name = "dvgAlt";
            dvgAlt.RowHeadersWidth = 51;
            dvgAlt.Size = new Size(1490, 188);
            dvgAlt.TabIndex = 1;
            // 
            // dvgUst
            // 
            dvgUst.BackgroundColor = SystemColors.Control;
            dvgUst.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgUst.Location = new Point(7, 0);
            dvgUst.Name = "dvgUst";
            dvgUst.RowHeadersWidth = 51;
            dvgUst.Size = new Size(1490, 188);
            dvgUst.TabIndex = 0;
            // 
            // Admin_Rapor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1828, 682);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Admin_Rapor";
            Text = "Admin_Rapor";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgAlt).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgUst).EndInit();
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
        private Panel panel4;
        private Panel panel3;
        private RadioButton rbAylık;
        private RadioButton rbHaftalık;
        private RadioButton rbGunluk;
        private DateTimePicker dtBas;
        private DateTimePicker dtBit;
        private Label label2;
        private Label label1;
        private Panel panel5;
        private Panel panel6;
        private DataGridView dvgAlt;
        private DataGridView dvgUst;
        private Button filtre_button;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}