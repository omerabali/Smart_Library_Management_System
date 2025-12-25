namespace WinFormsApp1
{
    partial class Odunc_Talep
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
            dataGridViewTalep = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTalep).BeginInit();
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
            panel2.Location = new Point(0, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(170, 447);
            panel2.TabIndex = 5;
            // 
            // ana_button
            // 
            ana_button.Location = new Point(7, 3);
            ana_button.Name = "ana_button";
            ana_button.Size = new Size(160, 35);
            ana_button.TabIndex = 5;
            ana_button.Text = "Ana Sayfa";
            ana_button.UseVisualStyleBackColor = true;
            ana_button.Click += ana_button_Click_1;
            // 
            // exit_button
            // 
            exit_button.Location = new Point(3, 392);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(160, 35);
            exit_button.TabIndex = 4;
            exit_button.Text = "Çıkış";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_button_Click_1;
            // 
            // odunc_takip_button
            // 
            odunc_takip_button.Location = new Point(7, 170);
            odunc_takip_button.Name = "odunc_takip_button";
            odunc_takip_button.Size = new Size(160, 35);
            odunc_takip_button.TabIndex = 3;
            odunc_takip_button.Text = "Geçmiş Ödünçlerim";
            odunc_takip_button.UseVisualStyleBackColor = true;
            odunc_takip_button.Click += odunc_takip_button_Click_1;
            // 
            // odunc_talep_button
            // 
            odunc_talep_button.Location = new Point(7, 129);
            odunc_talep_button.Name = "odunc_talep_button";
            odunc_talep_button.Size = new Size(160, 35);
            odunc_talep_button.TabIndex = 2;
            odunc_talep_button.Text = "Ödünç Talep";
            odunc_talep_button.UseVisualStyleBackColor = true;
            odunc_talep_button.Click += odunc_talep_button_Click_1;
            // 
            // kitap_aara_button
            // 
            kitap_aara_button.Location = new Point(7, 91);
            kitap_aara_button.Name = "kitap_aara_button";
            kitap_aara_button.Size = new Size(160, 35);
            kitap_aara_button.TabIndex = 1;
            kitap_aara_button.Text = "Kitap Ara";
            kitap_aara_button.UseVisualStyleBackColor = true;
            kitap_aara_button.Click += kitap_aara_button_Click_1;
            // 
            // kitap_list_button
            // 
            kitap_list_button.Location = new Point(7, 50);
            kitap_list_button.Name = "kitap_list_button";
            kitap_list_button.Size = new Size(160, 35);
            kitap_list_button.TabIndex = 0;
            kitap_list_button.Text = "Kitap Liste";
            kitap_list_button.UseVisualStyleBackColor = true;
            kitap_list_button.Click += kitap_list_button_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewTalep);
            panel1.Location = new Point(176, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1343, 447);
            panel1.TabIndex = 6;
            // 
            // dataGridViewTalep
            // 
            dataGridViewTalep.BackgroundColor = SystemColors.Control;
            dataGridViewTalep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTalep.Location = new Point(0, 0);
            dataGridViewTalep.Name = "dataGridViewTalep";
            dataGridViewTalep.RowHeadersWidth = 51;
            dataGridViewTalep.Size = new Size(1340, 441);
            dataGridViewTalep.TabIndex = 0;
            // 
            // Odunc_Talep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1531, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Odunc_Talep";
            Text = "Odunc_Talep";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTalep).EndInit();
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
        private DataGridView dataGridViewTalep;
    }
}