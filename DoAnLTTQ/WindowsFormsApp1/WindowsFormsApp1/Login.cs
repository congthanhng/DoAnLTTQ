using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
           
        }
        //---
        private void TextBoxEmpty(Control c)
        {

        }
        //--
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

      

        private void lbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }


        

        //---------------------- Active color-----------------------
        //-----------------and Handle Fill+ Empty Textbox---------
        private void lbChangePassword_MouseHover(object sender, EventArgs e)
        {
            lbChangePassword.ForeColor = Color.FromArgb(255, 125, 0);
        }

        private void lbChangePassword_MouseLeave(object sender, EventArgs e)
        {
            lbChangePassword.ForeColor = Color.White;
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if(tbPassword.Text == "")
            {
                tbPassword.Text = "Password";
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            tbPassword.Text = "";
        }


        private void lbSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
        private void lbSignUp_MouseHover(object sender, EventArgs e)
        {
            lbSignUp.ForeColor = Color.FromArgb(255, 125, 0);
        }

        private void lbSignUp_MouseLeave(object sender, EventArgs e)
        {
            lbSignUp.ForeColor = Color.White;
        }
    }
}
