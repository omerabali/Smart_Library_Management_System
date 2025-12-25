using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Input : Form
    {
        private const int RequiredRoleId = 1; 

        public Input()
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
                UserPage page = new UserPage(user.FullName, user.Email);
                page.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email veya şifre hatalı!",
                    "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            Input2 frm = new Input2();
            frm.Show();
            this.Hide();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }
    }
}
