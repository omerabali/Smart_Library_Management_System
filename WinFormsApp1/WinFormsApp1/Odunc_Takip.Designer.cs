namespace WinFormsApp1
{
    partial class Odunc_Takip
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
            panel1 = new Panel();
            ana_button = new Button();
            exit_button = new Button();
            odunc_takip_button = new Button();
            odunc_talep_button = new Button();
            kitap_aara_button = new Button();
            kitap_list_button = new Button();
            dataGridViewTakip = new DataGridView();
            panel3 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTakip).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(ana_button);
            panel2.Controls.Add(exit_button);
            panel2.Controls.Add(odunc_takip_button);
            panel2.Controls.Add(odunc_talep_button);
            panel2.Controls.Add(kitap_aara_button);
            panel2.Controls.Add(kitap_list_button);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(170, 447);
            panel2.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Location = new Point(176, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 444);
            panel1.TabIndex = 7;
            // 
            // ana_button
            // 
            ana_button.Location = new Point(10, 3);
            ana_button.Name = "ana_button";
            ana_button.Size = new Size(160, 35);
            ana_button.TabIndex = 5;
            ana_button.Text = "Ana Sayfa";
            ana_button.UseVisualStyleBackColor = true;
            ana_button.Click += ana_button_Click_1;
            // 
            // exit_button
            // 
            exit_button.Location = new Point(10, 403);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(160, 35);
            exit_button.TabIndex = 4;
            exit_button.Text = "Çıkış";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_button_Click_1;
            // 
            // odunc_takip_button
            // 
            odunc_takip_button.Location = new Point(7, 172);
            odunc_takip_button.Name = "odunc_takip_button";
            odunc_takip_button.Size = new Size(160, 35);
            odunc_takip_button.TabIndex = 3;
            odunc_takip_button.Text = "Geçmiş Ödünçlerim";
            odunc_takip_button.UseVisualStyleBackColor = true;
            odunc_takip_button.Click += odunc_takip_button_Click_1;
            // 
            // odunc_talep_button
            // 
            odunc_talep_button.Location = new Point(7, 131);
            odunc_talep_button.Name = "odunc_talep_button";
            odunc_talep_button.Size = new Size(160, 35);
            odunc_talep_button.TabIndex = 2;
            odunc_talep_button.Text = "Ödünç Talep";
            odunc_talep_button.UseVisualStyleBackColor = true;
            odunc_talep_button.Click += odunc_talep_button_Click_1;
            // 
            // kitap_aara_button
            // 
            kitap_aara_button.Location = new Point(7, 90);
            kitap_aara_button.Name = "kitap_aara_button";
            kitap_aara_button.Size = new Size(160, 35);
            kitap_aara_button.TabIndex = 1;
            kitap_aara_button.Text = "Kitap Ara";
            kitap_aara_button.UseVisualStyleBackColor = true;
            kitap_aara_button.Click += kitap_aara_button_Click_1;
            // 
            // kitap_list_button
            // 
            kitap_list_button.Location = new Point(10, 49);
            kitap_list_button.Name = "kitap_list_button";
            kitap_list_button.Size = new Size(160, 35);
            kitap_list_button.TabIndex = 0;
            kitap_list_button.Text = "Kitap Liste";
            kitap_list_button.UseVisualStyleBackColor = true;
            kitap_list_button.Click += kitap_list_button_Click_1;
            // 
            // dataGridViewTakip
            // 
            dataGridViewTakip.BackgroundColor = SystemColors.Control;
            dataGridViewTakip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTakip.Location = new Point(3, 3);
            dataGridViewTakip.Name = "dataGridViewTakip";
            dataGridViewTakip.RowHeadersWidth = 51;
            dataGridViewTakip.Size = new Size(1414, 431);
            dataGridViewTakip.TabIndex = 7;
            
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewTakip);
            panel3.Location = new Point(176, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1420, 441);
            panel3.TabIndex = 8;
            // 
            // Odunc_Takip
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1646, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Odunc_Takip";
            Text = "Odunc_Takip";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTakip).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Button ana_button;
        private Button exit_button;
        private Button odunc_takip_button;
        private Button odunc_talep_button;
        private Button kitap_aara_button;
        private Button kitap_list_button;
        private DataGridView dataGridViewTakip;
        private Panel panel3;
    }
}