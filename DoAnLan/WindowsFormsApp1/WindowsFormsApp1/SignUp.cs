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
    public partial class SignUp : Form 
    {       
        public SignUp()
        {




           InitializeComponent();
        }

    
        private void lbSignClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }


        //-------------------Watermark--------------------------
        //-------------- Empty + Fill Textbox --------------
        //Password
        private void tbPassword_Enter(object sender, EventArgs e)
        {          
                tbPassword.Text = "";
                tbPassword.isPassword = true;            
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Password";
                tbPassword.isPassword = false;
            }
        }

        // Re-Enter Password
        private void tbRePassword_Enter(object sender, EventArgs e)
        {        
                tbRePassword.Text = "";
                tbRePassword.isPassword = true;         
            
        }

        private void tbRePassword_Leave(object sender, EventArgs e)
        {
            if (tbRePassword.Text == "")
            {
                tbRePassword.Text = "Re-Enter Password";
                tbRePassword.isPassword = false;
            }
        }

        //User Name
        private void tbSignUserName_Leave(object sender, EventArgs e)
        {
            if (tbSignUserName.Text == "")
            {
                tbSignUserName.Text = "User Name";                
            }
        }


        private void tbSignUserName_KeyDown(object sender, KeyEventArgs e)
        {
            tbSignUserName.Text = "";
        }

        //Your Name
        private void tbName_Enter(object sender, EventArgs e)
        {
            tbName.Text = "";
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                tbName.Text = "Your Name";
            }
        }

        private void lbLogin_MouseHover(object sender, EventArgs e)
        {
            lbLogin.ForeColor = Color.FromArgb(255, 125, 0);
        }

        private void lbLogin_MouseLeave(object sender, EventArgs e)
        {
            lbLogin.ForeColor = Color.White;
        }

    }
    }

