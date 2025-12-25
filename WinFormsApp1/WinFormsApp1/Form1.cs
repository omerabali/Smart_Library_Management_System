using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            User_Button.Click += User_Button_Click;
            Employee_Button.Click += Employee_Button_Click;
            Manager_Button.Click += Manager_Button_Click;
        }

        private void User_Button_Click(object sender, EventArgs e)
        {
            Input inputPage = new Input();
            inputPage.Show();
            this.Hide();
        }

        private void Employee_Button_Click(object sender, EventArgs e)
        {
            Input1 input1Page = new Input1();
            input1Page.Show();
            this.Hide();
        }

        private void Manager_Button_Click(object sender, EventArgs e)
        {
            Input3 input3Page = new Input3();
            input3Page.Show();
            this.Hide();
        }
    }
}
