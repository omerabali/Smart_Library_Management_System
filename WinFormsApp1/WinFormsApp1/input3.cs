using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Input3 : Form
    {
        private const int RequiredRoleId = 3;

        public Input3()
        {
            InitializeComponent();
        }

        private void Input_Button_Click(object sender, EventArgs e)
        {
            string email = email_textBox.Text.Trim();
            string password = password_textBox.Text.Trim();

            UserInfo user = DbHelper.ValidateLoginAndGetUser(email, password, RequiredRoleId);

            if (user != null)
            {
                AdminPage page = new AdminPage(user.FullName, user.Email);
                page.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email veya şifre hatalı!",
                    "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }
    }
}
