using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class FrmLogin : Form
    {
        int tries = 1;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = LoginNew.GetUName;
            //username = AdamK
            string Password = LoginNew.GetPass;
            //password = Password1

            if (Username.Equals(txtusername.Text) && (Password.Equals(txtpassword.Text)))
            {
                MessageBox.Show("Login Successful");
                FrmMainPg frm2 = new FrmMainPg(Username);
                ActiveForm.Hide();
                frm2.Show();
            }
            else if(tries <3)
            {
                MessageBox.Show("Not Logged In Try Again");
                tries++;
            }
            else
            {
                MessageBox.Show("No more tries, the details entered are invalid");
                Environment.Exit(0);
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }


    }
}
