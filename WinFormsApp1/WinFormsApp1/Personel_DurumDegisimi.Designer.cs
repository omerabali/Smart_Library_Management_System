namespace WinFormsApp1
{
    partial class Personel_DurumDegisimi
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            exit_button = new Button();
            gunluk_button = new Button();
            durum_button = new Button();
            odunc_button = new Button();
            ana_button = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(191, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1484, 443);
            panel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1481, 443);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(exit_button);
            panel1.Controls.Add(gunluk_button);
            panel1.Controls.Add(durum_button);
            panel1.Controls.Add(odunc_button);
            panel1.Controls.Add(ana_button);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 444);
            panel1.TabIndex = 6;
            // 
            // exit_button
            // 
            exit_button.Location = new Point(10, 402);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(160, 35);
            exit_button.TabIndex = 4;
            exit_button.Text = "Çıkış";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_button_Click;
            // 
            // gunluk_button
            // 
            gunluk_button.Location = new Point(10, 132);
            gunluk_button.Name = "gunluk_button";
            gunluk_button.Size = new Size(160, 35);
            gunluk_button.TabIndex = 3;
            gunluk_button.Text = "Günlük İşlemler";
            gunluk_button.UseVisualStyleBackColor = true;
            gunluk_button.Click += gunluk_button_Click;
            // 
            // durum_button
            // 
            durum_button.Location = new Point(10, 91);
            durum_button.Name = "durum_button";
            durum_button.Size = new Size(160, 35);
            durum_button.TabIndex = 2;
            durum_button.Text = "Durum Değişimi";
            durum_button.UseVisualStyleBackColor = true;
            durum_button.Click += durum_button_Click;
            // 
            // odunc_button
            // 
            odunc_button.Location = new Point(10, 50);
            odunc_button.Name = "odunc_button";
            odunc_button.Size = new Size(160, 35);
            odunc_button.TabIndex = 1;
            odunc_button.Text = "Ödünç Talep Listesi";
            odunc_button.UseVisualStyleBackColor = true;
            odunc_button.Click += odunc_button_Click;
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
            // Personel_DurumDegisimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1799, 712);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Personel_DurumDegisimi";
            Text = "Personel_DurumDegisimi";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button exit_button;
        private Button gunluk_button;
        private Button durum_button;
        private Button odunc_button;
        private Button ana_button;
    }
}