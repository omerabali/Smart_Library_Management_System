using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Drawing;

namespace WinFormsApp1
{
    public partial class UserPage : Form
    {
        private readonly string _userName;
        private readonly string _userEmail;

        public UserPage(string userName, string email)
        {
            InitializeComponent();
            _userName = userName;
            _userEmail = email;

            
            Color userMenuColor = Color.DarkGoldenrod; 
            Color activeColor = Color.Goldenrod; 
            Color exitColor = Color.Firebrick; 
            Color foregroundColor = Color.White; 

            
            ana_button.BackColor = activeColor;
            ana_button.ForeColor = foregroundColor;

            kitap_list_button.BackColor = userMenuColor;
            kitap_list_button.ForeColor = foregroundColor;

            kitap_aara_button.BackColor = userMenuColor;
            kitap_aara_button.ForeColor = foregroundColor;

            odunc_talep_button.BackColor = userMenuColor;
            odunc_talep_button.ForeColor = foregroundColor;

            odunc_takip_button.BackColor = userMenuColor;
            odunc_takip_button.ForeColor = foregroundColor;

            exit_button.BackColor = exitColor;
            exit_button.ForeColor = foregroundColor;

            
            labelhosgeldiniz.ForeColor = Color.SaddleBrown;
            labelhosgeldiniz.Font = new Font(labelhosgeldiniz.Font.FontFamily, 16, FontStyle.Bold);

           
            labelAktifOdunc.ForeColor = Color.Black;           
            label1.ForeColor = Color.DarkOrange;               
            label2.ForeColor = Color.Black;                 
            label3.ForeColor = Color.ForestGreen;            

            
        }

        
        private int GetUserId(SqlConnection conn)
        {
            string q = "SELECT KullaniciID FROM Kullanicilar WHERE Email=@mail";
            using (SqlCommand cmd = new SqlCommand(q, conn))
            {
                cmd.Parameters.AddWithValue("@mail", _userEmail);
                object result = cmd.ExecuteScalar();
                return result == null ? 0 : Convert.ToInt32(result);
            }
        }

        private int GetAktifOdunc(SqlConnection conn, int id)
        {
            string q = "SELECT COUNT(*) FROM OduncIslemleri WHERE KullaniciID=@id AND DurumID IN (1,2,3,5)";
            using (SqlCommand cmd = new SqlCommand(q, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private int GetBekleyen(SqlConnection conn, int id)
        {
            string q = "SELECT COUNT(*) FROM OduncIslemleri WHERE KullaniciID=@id AND DurumID = 1";
            using (SqlCommand cmd = new SqlCommand(q, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private int GetGecikmis(SqlConnection conn, int id)
        {
            string q = @"SELECT COUNT(*) FROM OduncIslemleri
                         WHERE KullaniciID=@id AND DurumID <> 4 AND SonIadeTarihi < GETDATE()";
            using (SqlCommand cmd = new SqlCommand(q, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private int GetOkunan(SqlConnection conn, int id)
        {
            string q = "SELECT COUNT(*) FROM OduncIslemleri WHERE KullaniciID=@id AND DurumID = 4";
            using (SqlCommand cmd = new SqlCommand(q, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            labelhosgeldiniz.Text = "Hoşgeldiniz, " + _userName;

            using (SqlConnection conn = new SqlConnection(
                "Data Source=DESKTOP-99QGAEU\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;Encrypt=False;"))
            {
                conn.Open();
                int userId = GetUserId(conn);

                
                labelAktifOdunc.Text = $"Aktif Ödünç: {GetAktifOdunc(conn, userId)}";
                label1.Text = $"Bekleyen: {GetBekleyen(conn, userId)}";
                label2.Text = $"Gecikmiş: {GetGecikmis(conn, userId)}";
                label3.Text = $"Okunan: {GetOkunan(conn, userId)}";
            }
        }

        
        private void ana_button_Click(object sender, EventArgs e)
        {
            UserPage page = new UserPage(_userName, _userEmail);
            page.Show();
            this.Hide();
        }

        private void kitap_list_button_Click(object sender, EventArgs e)
        {
            Kitap_List kl = new Kitap_List(_userName, _userEmail);
            kl.Show();
            this.Hide();
        }

        private void kitap_aara_button_Click(object sender, EventArgs e)
        {
            Kitap_ara ka = new Kitap_ara(_userName, _userEmail);
            ka.Show();
            this.Hide();
        }

        private void odunc_talep_button_Click(object sender, EventArgs e)
        {
            Odunc_Talep ot = new Odunc_Talep(_userName, _userEmail);
            ot.Show();
            this.Hide();
        }

        private void odunc_takip_button_Click(object sender, EventArgs e)
        {
            Odunc_Takip ot = new Odunc_Takip(_userName, _userEmail);
            ot.Show();
            this.Hide();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }
    }
}