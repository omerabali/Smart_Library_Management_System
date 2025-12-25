using System;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormsApp1
{
    public partial class AdminPage : Form
    {
        private readonly string _adminName;
        private readonly string _adminEmail;

        public AdminPage(string adminName, string adminEmail)
        {
            InitializeComponent();

            _adminName = adminName;
            _adminEmail = adminEmail;

            

           
            Color menuColor = Color.FromArgb(100, 43, 137); // Koyu Mor (Ana Menü)
            Color activeColor = Color.FromArgb(120, 63, 157); // Aktif/Vurgulu Menü Rengi
            Color exitColor = Color.Firebrick; // Kırmızı (Çıkış)
            Color foregroundColor = Color.White; // Beyaz yazı

            
            ana_button.BackColor = activeColor;
            ana_button.ForeColor = foregroundColor;

            kitap_button.BackColor = menuColor;
            kitap_button.ForeColor = foregroundColor;

            user_man_button.BackColor = menuColor;
            user_man_button.ForeColor = foregroundColor;

            rapor_button.BackColor = menuColor;
            rapor_button.ForeColor = foregroundColor;

            exit_button.BackColor = exitColor;
            exit_button.ForeColor = foregroundColor;

           
            label_hosgeldiniz.ForeColor = Color.DarkGreen; // Koyu Yeşil
            label_hosgeldiniz.Font = new Font(label_hosgeldiniz.Font.FontFamily, 16, FontStyle.Bold);

         

            // Event Atamaları
            ana_button.Click += ana_button_Click;
            kitap_button.Click += kitap_button_Click;
            user_man_button.Click += user_man_button_Click;
            rapor_button.Click += rapor_button_Click;
            exit_button.Click += exit_button_Click;
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            label_hosgeldiniz.Text = "Hoşgeldiniz, " + _adminName;
        }

       
        private void ana_button_Click(object sender, EventArgs e)
        {
            AdminPage page = new AdminPage(_adminName, _adminEmail);
            page.Show();
            this.Hide();
        }

        
        private void kitap_button_Click(object sender, EventArgs e)
        {
            Admin_Kitap k = new Admin_Kitap(_adminName, _adminEmail);
            k.Show();
            this.Hide();
        }

       
        private void user_man_button_Click(object sender, EventArgs e)
        {
            Admin_UserManagement um = new Admin_UserManagement(_adminName, _adminEmail);
            um.Show();
            this.Hide();
        }

      
        private void rapor_button_Click(object sender, EventArgs e)
        {
            Admin_Rapor r = new Admin_Rapor(_adminName, _adminEmail);
            r.Show();
            this.Hide();
        }

        
        private void exit_button_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
    }
}