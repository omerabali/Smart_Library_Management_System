using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using BCrypt.Net;

namespace WinFormsApp1
{
    public partial class Input2 : Form
    {
        private readonly string ConnectionString =
            "Data Source=DESKTOP-99QGAEU\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;Encrypt=False;";

        public Input2()
        {
            InitializeComponent();
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            string ad = ad_textBox.Text.Trim();
            string soyad = soyad_textBox.Text.Trim();
            string email = email_textBox.Text.Trim();
            string sifre = password_textBox.Text;
            string okulNo = okulno_textBox.Text.Trim();
            string telefon = telefon_textBox.Text.Trim();

          
            if (string.IsNullOrWhiteSpace(ad))
            {
                MessageBox.Show("Ad alanı boş bırakılamaz.");
                return;
            }

            if (string.IsNullOrWhiteSpace(soyad))
            {
                MessageBox.Show("Soyad alanı boş bırakılamaz.");
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("E-posta alanı boş bırakılamaz.");
                return;
            }

            if (string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Parola alanı boş bırakılamaz.");
                return;
            }

            if (string.IsNullOrWhiteSpace(okulNo))
            {
                MessageBox.Show("Okul numarası alanı boş bırakılamaz.");
                return;
            }

            if (string.IsNullOrWhiteSpace(telefon))
            {
                MessageBox.Show("Telefon alanı boş bırakılamaz.");
                return;
            }

            
            if (!email.Contains("@") || email.StartsWith("@") || email.EndsWith("@"))
            {
                MessageBox.Show("Geçerli bir e-posta adresi giriniz.");
                return;
            }

            
            if (telefon.Length != 11 || !telefon.All(char.IsDigit))
            {
                MessageBox.Show("Telefon numarası 11 haneli ve sadece rakamlardan oluşmalıdır.");
                return;
            }

            
            if (!okulNo.All(char.IsDigit))
            {
                MessageBox.Show("Okul numarası sadece rakamlardan oluşmalıdır.");
                return;
            }

            
            bool buyukHarf = sifre.Any(char.IsUpper);
            bool kucukHarf = sifre.Any(char.IsLower);
            bool rakam = sifre.Any(char.IsDigit);

            if (sifre.Length < 8 || !buyukHarf || !kucukHarf || !rakam)
            {
                MessageBox.Show(
                    "Parola en az 8 karakter olmalı ve bir büyük harf, bir küçük harf ile bir sayı içermelidir."
                );
                return;
            }

            
            try
            {
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(sifre);

                using SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                string sql = @"
                    INSERT INTO Kullanicilar
                    (Ad, Soyad, Email, Telefon, Sifre, OkulNo, RolID)
                    VALUES
                    (@ad, @soyad, @mail, @tel, @sifre, @okul, 1)";

                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@soyad", soyad);
                cmd.Parameters.AddWithValue("@mail", email);
                cmd.Parameters.AddWithValue("@tel", telefon);
                cmd.Parameters.AddWithValue("@sifre", hashedPassword);
                cmd.Parameters.AddWithValue("@okul", okulNo);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Kayıt başarılı!");

                new Input().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt sırasında hata oluştu:\n" + ex.Message);
            }
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            new Input().Show();
            this.Hide();
        }
    }
}
