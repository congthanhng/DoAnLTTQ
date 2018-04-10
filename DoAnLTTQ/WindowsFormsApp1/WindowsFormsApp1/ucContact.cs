using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace WindowsFormsApp1
{
    public partial class ucContact : UserControl
    {
        private static ucContact _instance;
        public static ucContact Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucContact();
                }
                return _instance;
            }

        }

        public ucContact()
        {
            InitializeComponent();
            //AddUserToListContact();
        }

        // static value to access and create control
    

        void AddUserToListContact()
        {   
            for (int i =0; i < 15; i++)
            {  String strText = ("User " + i.ToString());
                BunifuFlatButton btnUser = new BunifuFlatButton();
                btnUser.Width = pnlContactList.Width-50;
                btnUser.Height = 50;
                btnUser.Text = strText;
                btnUser.BackColor = Color.FromArgb(26, 30, 41);
                btnUser.Normalcolor = Color.FromArgb(26, 30, 41);
                
                pnlContactList.Controls.Add(btnUser);
            }
          
        }

        private void btnFriend_Click(object sender, EventArgs e)
        {
            MainMessenger.AddUserControl(MainMessenger.pnlMainMiddle, ucContactHandle.Instance);

        }

    }
}
