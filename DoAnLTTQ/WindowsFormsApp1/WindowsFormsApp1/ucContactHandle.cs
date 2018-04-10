using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ucContactHandle : UserControl
    {
        private static ucContactHandle _instance;
        public static ucContactHandle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucContactHandle();
                }
                return _instance;
            }

        }

        // set status to handle contact
        // 1 is Add handle
        // 0 is Delete handle
        int StatusHandle;


        public ucContactHandle()
        {
            InitializeComponent();
        }

        private void txtContact_Leave(object sender, EventArgs e)
        {
            if (txtContact.Text == String.Empty)
            {
                txtContact.Text = "Enter your friend's name";
            }
        }

        private void txtContact_Enter(object sender, EventArgs e)
        {
            if(txtContact.Text == "Enter your friend's name")
            {
                txtContact.Text = String.Empty;
            }
        }

        private void btnAddFriend_Click(object sender, EventArgs e)
        {
            StatusHandle = 1;
            lbContactHandleScript1.Text = "ADD FRIEND";
            lbContactHandleScript2.Text = "You can add a friend with their Id";
        }

        private void btnDeleteFriend_Click(object sender, EventArgs e)
        {
            StatusHandle = 1;
            lbContactHandleScript1.Text = "DELETE FRIEND";
            lbContactHandleScript2.Text = "You can delete a friend with their Id";
        }
    }
}
