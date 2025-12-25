namespace WinFormsApp1
{
    partial class Kitap_ara
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
            filtreleButton = new Button();
            kitapAdiTextBox = new TextBox();
            yazarTextBox = new TextBox();
            yilComboBox = new ComboBox();
            kategoriComboBox = new ComboBox();
            dataGridViewKitaplar = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(ana_button);
            panel2.Controls.Add(exit_button);
            panel2.Controls.Add(odunc_takip_button);
            panel2.Controls.Add(odunc_talep_button);
            panel2.Controls.Add(kitap_aara_button);
            panel2.Controls.Add(kitap_list_button);
            panel2.Location = new Point(1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(170, 447);
            panel2.TabIndex = 4;
            // 
            // ana_button
            // 
            ana_button.Location = new Point(7, 9);
            ana_button.Name = "ana_button";
            ana_button.Size = new Size(160, 35);
            ana_button.TabIndex = 5;
            ana_button.Text = "Ana Sayfa";
            ana_button.UseVisualStyleBackColor = true;
            ana_button.Click += ana_button_Click;
            // 
            // exit_button
            // 
            exit_button.Location = new Point(7, 409);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(160, 35);
            exit_button.TabIndex = 4;
            exit_button.Text = "Çıkış";
            exit_button.UseVisualStyleBackColor = true;
            // 
            // odunc_takip_button
            // 
            odunc_takip_button.Location = new Point(7, 171);
            odunc_takip_button.Name = "odunc_takip_button";
            odunc_takip_button.Size = new Size(160, 35);
            odunc_takip_button.TabIndex = 3;
            odunc_takip_button.Text = "Geçmiş Ödünçlerim";
            odunc_takip_button.UseVisualStyleBackColor = true;
            // 
            // odunc_talep_button
            // 
            odunc_talep_button.Location = new Point(7, 130);
            odunc_talep_button.Name = "odunc_talep_button";
            odunc_talep_button.Size = new Size(160, 35);
            odunc_talep_button.TabIndex = 2;
            odunc_talep_button.Text = "Ödünç Talep";
            odunc_talep_button.UseVisualStyleBackColor = true;
            // 
            // kitap_aara_button
            // 
            kitap_aara_button.Location = new Point(7, 91);
            kitap_aara_button.Name = "kitap_aara_button";
            kitap_aara_button.Size = new Size(160, 35);
            kitap_aara_button.TabIndex = 1;
            kitap_aara_button.Text = "Kitap Ara";
            kitap_aara_button.UseVisualStyleBackColor = true;
            // 
            // kitap_list_button
            // 
            kitap_list_button.Location = new Point(7, 51);
            kitap_list_button.Name = "kitap_list_button";
            kitap_list_button.Size = new Size(160, 35);
            kitap_list_button.TabIndex = 0;
            kitap_list_button.Text = "Kitap Liste";
            kitap_list_button.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(filtreleButton);
            panel1.Controls.Add(kitapAdiTextBox);
            panel1.Controls.Add(yazarTextBox);
            panel1.Controls.Add(yilComboBox);
            panel1.Controls.Add(kategoriComboBox);
            panel1.Controls.Add(dataGridViewKitaplar);
            panel1.Location = new Point(177, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1595, 447);
            panel1.TabIndex = 5;
            // 
            // filtreleButton
            // 
            filtreleButton.Location = new Point(1254, 53);
            filtreleButton.Name = "filtreleButton";
            filtreleButton.Size = new Size(177, 29);
            filtreleButton.TabIndex = 6;
            filtreleButton.Text = "Filtrele";
            filtreleButton.UseVisualStyleBackColor = true;
            // 
            // kitapAdiTextBox
            // 
            kitapAdiTextBox.Location = new Point(868, 50);
            kitapAdiTextBox.Name = "kitapAdiTextBox";
            kitapAdiTextBox.Size = new Size(271, 27);
            kitapAdiTextBox.TabIndex = 5;
            kitapAdiTextBox.Text = "Kitap Adini Giriniz:";
            // 
            // yazarTextBox
            // 
            yazarTextBox.Location = new Point(529, 51);
            yazarTextBox.Name = "yazarTextBox";
            yazarTextBox.Size = new Size(271, 27);
            yazarTextBox.TabIndex = 4;
            yazarTextBox.Text = "Kitap Yazarini Giriniz:";
            // 
            // yilComboBox
            // 
            yilComboBox.FormattingEnabled = true;
            yilComboBox.Location = new Point(280, 50);
            yilComboBox.Name = "yilComboBox";
            yilComboBox.Size = new Size(177, 28);
            yilComboBox.TabIndex = 3;
            yilComboBox.Text = "Yılı Seç";
            // 
            // kategoriComboBox
            // 
            kategoriComboBox.FormattingEnabled = true;
            kategoriComboBox.Location = new Point(47, 50);
            kategoriComboBox.Name = "kategoriComboBox";
            kategoriComboBox.Size = new Size(177, 28);
            kategoriComboBox.TabIndex = 1;
            kategoriComboBox.Text = "Kategori Seç";
            // 
            // dataGridViewKitaplar
            // 
            dataGridViewKitaplar.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKitaplar.Location = new Point(3, 170);
            dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            dataGridViewKitaplar.RowHeadersWidth = 51;
            dataGridViewKitaplar.Size = new Size(1369, 274);
            dataGridViewKitaplar.TabIndex = 0;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Kitap_ara
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1784, 458);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Kitap_ara";
            Text = "Kitap_ara";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button ana_button;
        private Button exit_button;
        private Button odunc_takip_button;
        private Button odunc_talep_button;
        private Button kitap_aara_button;
        private Button kitap_list_button;
        private Panel panel1;
        private DataGridView dataGridViewKitaplar;
        private TextBox yazarTextBox;
        private ComboBox yilComboBox;
        private ComboBox kategoriComboBox;
        private Button filtreleButton;
        private TextBox kitapAdiTextBox;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}