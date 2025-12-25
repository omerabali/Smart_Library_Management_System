namespace WinFormsApp1
{
    partial class Kitap_List
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
            dataGridViewKitaplar = new DataGridView();
            panel2 = new Panel();
            ana_button = new Button();
            exit_button = new Button();
            odunc_takip_button = new Button();
            odunc_talep_button = new Button();
            kitap_aara_button = new Button();
            kitap_list_button = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewKitaplar);
            panel1.Location = new Point(182, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1583, 447);
            panel1.TabIndex = 3;
            // 
            // dataGridViewKitaplar
            // 
            dataGridViewKitaplar.BackgroundColor = SystemColors.Control;
            dataGridViewKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKitaplar.Location = new Point(3, 3);
            dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            dataGridViewKitaplar.RowHeadersWidth = 51;
            dataGridViewKitaplar.Size = new Size(1577, 444);
            dataGridViewKitaplar.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(ana_button);
            panel2.Controls.Add(exit_button);
            panel2.Controls.Add(odunc_takip_button);
            panel2.Controls.Add(odunc_talep_button);
            panel2.Controls.Add(kitap_aara_button);
            panel2.Controls.Add(kitap_list_button);
            panel2.Location = new Point(6, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(170, 447);
            panel2.TabIndex = 2;
            // 
            // ana_button
            // 
            ana_button.Location = new Point(6, 10);
            ana_button.Name = "ana_button";
            ana_button.Size = new Size(160, 35);
            ana_button.TabIndex = 5;
            ana_button.Text = "Ana Sayfa";
            ana_button.UseVisualStyleBackColor = true;
            ana_button.Click += ana_button_Click;
            // 
            // exit_button
            // 
            exit_button.Location = new Point(6, 409);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(160, 35);
            exit_button.TabIndex = 4;
            exit_button.Text = "Çıkış";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_button_Click;
            // 
            // odunc_takip_button
            // 
            odunc_takip_button.Location = new Point(6, 171);
            odunc_takip_button.Name = "odunc_takip_button";
            odunc_takip_button.Size = new Size(160, 35);
            odunc_takip_button.TabIndex = 3;
            odunc_takip_button.Text = "Geçmiş Ödünçlerim";
            odunc_takip_button.UseVisualStyleBackColor = true;
            odunc_takip_button.Click += odunc_takip_button_Click;
            // 
            // odunc_talep_button
            // 
            odunc_talep_button.Location = new Point(6, 130);
            odunc_talep_button.Name = "odunc_talep_button";
            odunc_talep_button.Size = new Size(160, 35);
            odunc_talep_button.TabIndex = 2;
            odunc_talep_button.Text = "Ödünç Talep";
            odunc_talep_button.UseVisualStyleBackColor = true;
            odunc_talep_button.Click += odunc_talep_button_Click;
            // 
            // kitap_aara_button
            // 
            kitap_aara_button.Location = new Point(6, 89);
            kitap_aara_button.Name = "kitap_aara_button";
            kitap_aara_button.Size = new Size(160, 35);
            kitap_aara_button.TabIndex = 1;
            kitap_aara_button.Text = "Kitap Ara";
            kitap_aara_button.UseVisualStyleBackColor = true;
            kitap_aara_button.Click += kitap_aara_button_Click;
            // 
            // kitap_list_button
            // 
            kitap_list_button.Location = new Point(6, 51);
            kitap_list_button.Name = "kitap_list_button";
            kitap_list_button.Size = new Size(160, 35);
            kitap_list_button.TabIndex = 0;
            kitap_list_button.Text = "Kitap Liste";
            kitap_list_button.UseVisualStyleBackColor = true;
            kitap_list_button.Click += kitap_list_button_Click;
            // 
            // Kitap_List
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1777, 696);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Kitap_List";
            Text = "Kitap_List";
            Load += Kitap_List_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private DataGridView dataGridViewKitaplar;
        private Panel panel2;
        private Button ana_button;
        private Button exit_button;
        private Button odunc_takip_button;
        private Button odunc_talep_button;
        private Button kitap_aara_button;
        private Button kitap_list_button;
    }
}