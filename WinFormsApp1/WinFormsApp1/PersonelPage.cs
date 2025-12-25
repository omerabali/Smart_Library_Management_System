using System;
using System.Windows.Forms;
using System.Drawing; // Renkleri kullanmak için eklendi

namespace WinFormsApp1
{
    public partial class PersonelPage : Form
    {
        private readonly string _personelName;
        private readonly string _personelEmail;

        public PersonelPage(string fullName, string email)
        {
            InitializeComponent();
            _personelName = fullName;
            _personelEmail = email;


            
            Color personelMenuColor = Color.FromArgb(0, 71, 160); 
            Color activeColor = Color.FromArgb(0, 100, 200); 
            Color exitColor = Color.Firebrick; 
            Color foregroundColor = Color.White; 
            Color hosgeldinizColor = Color.DarkGreen; 

            
            ana_button.BackColor = activeColor;
            ana_button.ForeColor = foregroundColor;

            
            odunc_button.BackColor = personelMenuColor;
            odunc_button.ForeColor = foregroundColor;

            durum_button.BackColor = personelMenuColor;
            durum_button.ForeColor = foregroundColor;

            gunluk_button.BackColor = personelMenuColor;
            gunluk_button.ForeColor = foregroundColor;

           
            exit_button.BackColor = exitColor;
            exit_button.ForeColor = foregroundColor;

          
            lblHosgeldiniz.ForeColor = hosgeldinizColor;
            lblHosgeldiniz.Font = new Font(lblHosgeldiniz.Font.FontFamily, 16, FontStyle.Bold);

          

            ana_button.Click += ana_button_Click;
            odunc_button.Click += odunc_button_Click;
            durum_button.Click += durum_button_Click;
            gunluk_button.Click += gunluk_button_Click;
            exit_button.Click += exit_button_Click;
        }

       

        private void ana_button_Click(object sender, EventArgs e)
        {
            // Bulunduğumuz sayfa --> Personel Ana Sayfa
            MessageBox.Show("Zaten ana sayfadasınız.");
        }

        private void odunc_button_Click(object sender, EventArgs e)
        {
            Personel_OduncListe p = new Personel_OduncListe(_personelName, _personelEmail);
            p.Show();
            this.Hide();
        }

        private void durum_button_Click(object sender, EventArgs e)
        {
            Personel_DurumDegisimi p = new Personel_DurumDegisimi(_personelName, _personelEmail);
            p.Show();
            this.Hide();
        }

        private void gunluk_button_Click(object sender, EventArgs e)
        {
            Personel_GunlukIslemler p = new Personel_GunlukIslemler(_personelName, _personelEmail);
            p.Show();
            this.Hide();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void PersonelPage_Load_1(object sender, EventArgs e)
        {
            lblHosgeldiniz.Text = "Hoşgeldiniz, " + _personelName;
        }
    }
}